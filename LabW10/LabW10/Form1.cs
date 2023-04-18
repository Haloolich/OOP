using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;


namespace LabW10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(DrawRectangle));
            thread2 = new Thread(new ThreadStart(DrawEllipse));
            thread3 = new Thread(new ThreadStart(RandomNumber));

        }
        Thread thread1;
        Thread thread2;
        Thread thread3;
        private void DrawRectangle()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(4);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void DrawEllipse()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(4);
                    g.DrawEllipse(Pens.Yellow, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void RandomNumber()
        {
            try
            {
                Random rnd = new Random();

                Parallel.For(0, 500, i =>
                {
                    RandomNumberTextBox.Invoke((MethodInvoker)delegate ()
                    {
                        RandomNumberTextBox.Text += rnd.Next().ToString();
                    });
                });

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void StartThreadingButton_Click(object sender, EventArgs e)
        {
            try
            {
                thread1.Start();
                thread2.Start();
                thread3.Start();
            }
            catch (Exception ex) { }
        }
        private void FirstMethodButton_Click(object sender, EventArgs e)
        {

            thread1.Start();

        }
        private void SecondMethodButton_Click(object sender, EventArgs e)
        {

            thread2.Start();

        }
        private void ThirdMethodButton_Click(object sender, EventArgs e)
        {

            thread3.Start();

        }
        private void StopThreadButton_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            thread3.Suspend();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thread3.Suspend();
        }

        //my code
        private async void btnCript_Click(object sender, EventArgs e)
        {
            string plaintext = tbPlaintext.Text;
            string key = tbKey.Text;
            string ciphertext;

            // Perform CAST block encryption asynchronously
            Task<string> castTask = Task.Run(() => PerformCASTAlgorithm(plaintext, key));

            // Perform MD-4 hashing asynchronously
            Task<string> md4Task = Task.Run(() => PerformARAlgorithm(plaintext));

            // Perform SEAL encryption and authentication asynchronously
            Task<string> sealTask = Task.Run(() => PerformSEALAlgorithm(plaintext, key));

            // Wait for all tasks to complete
            await Task.WhenAll(castTask, md4Task, sealTask);

            // Get results and display in text boxes
            tbCAST.Text = castTask.Result;
            tbMD4.Text = md4Task.Result;
            tbSEAL.Text = sealTask.Result;
        }

        private string PerformCASTAlgorithm(string plaintext, string key)
        {
            // Perform CAST block encryption
            using (var cast = new RijndaelManaged())
            {
                cast.Key = System.Text.Encoding.UTF8.GetBytes(key);
                cast.Mode = CipherMode.ECB;
                cast.Padding = PaddingMode.PKCS7;

                using (var encryptor = cast.CreateEncryptor())
                {
                    var plaintextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
                    var ciphertextBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                    var ciphertext = Convert.ToBase64String(ciphertextBytes);
                    return ciphertext;
                }
            }
        }

        private string PerformARAlgorithm(string plaintext)
        {
            // Perform AR hashing
            using (var sha512 = SHA512.Create())
            {
                var plaintextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
                var hashBytes = sha512.ComputeHash(plaintextBytes);
                var hash = Convert.ToBase64String(hashBytes);
                return hash;
            }
        }

        private string PerformSEALAlgorithm(string plaintext, string key)
        {
            // Perform SEAL encryption and authentication
            using (var seal = new AesCryptoServiceProvider())
            {
                seal.Key = System.Text.Encoding.UTF8.GetBytes(key);
                seal.Mode = CipherMode.CBC;
                seal.Padding = PaddingMode.PKCS7;

                byte[] ciphertext;
                byte[] nonce = new byte[12];

                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(nonce);
                }

                using (var encryptor = seal.CreateEncryptor())
                {
                    var plaintextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
                    var messageWithNonce = new byte[plaintextBytes.Length + nonce.Length];
                    Array.Copy(plaintextBytes, 0, messageWithNonce, 0, plaintextBytes.Length);
                    Array.Copy(nonce, 0, messageWithNonce, plaintextBytes.Length, nonce.Length);

                    ciphertext = encryptor.TransformFinalBlock(messageWithNonce, 0, messageWithNonce.Length);
                }

                using (var hmac = new HMACSHA256(seal.Key))
                {
                    var messageWithNonceAndCiphertext = new byte[ciphertext.Length + nonce.Length];
                    Array.Copy(ciphertext, 0, messageWithNonceAndCiphertext, 0, ciphertext.Length);
                    Array.Copy(nonce, 0, messageWithNonceAndCiphertext, ciphertext.Length, nonce.Length);
                    var tagBytes = hmac.ComputeHash(messageWithNonceAndCiphertext);
                    var tag = Convert.ToBase64String(tagBytes);

                    var result = new byte[ciphertext.Length + nonce.Length + tagBytes.Length];
                    Array.Copy(ciphertext, 0, result, 0, ciphertext.Length);
                    Array.Copy(nonce, 0, result, ciphertext.Length, nonce.Length);
                    Array.Copy(tagBytes, 0, result, ciphertext.Length + nonce.Length, tagBytes.Length);

                    var encryptedMessage = Convert.ToBase64String(result);
                    return encryptedMessage;
                }
            }
        }
    }
}
