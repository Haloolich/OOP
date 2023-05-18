using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace LabW19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayComputerInformation();
        }
        private void DisplayComputerInformation()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string manufacturer = queryObj["Manufacturer"]?.ToString() ?? "N/A";
                    string model = queryObj["Product"]?.ToString() ?? "N/A";
                    string serialNumber = queryObj["SerialNumber"]?.ToString() ?? "N/A";
                    textBoxOutput.AppendText($"Motherboard Manufacturer: {manufacturer}\n");
                    textBoxOutput.AppendText($"Motherboard Model: {model}\n");
                    textBoxOutput.AppendText($"Motherboard Serial Number: {serialNumber}\n");
                }
                searcher.Query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter WHERE Manufacturer != 'Microsoft'");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string name = queryObj["Name"]?.ToString() ?? "N/A";
                    string macAddress = queryObj["MACAddress"]?.ToString() ?? "N/A";
                    textBoxOutput.AppendText($"\nNetwork Adapter Name: {name}\n");
                    textBoxOutput.AppendText($"MAC Address: {macAddress}\n");
                }
                searcher.Query = new ObjectQuery("SELECT * FROM Win32_BIOS");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string biosVersion = queryObj["SMBIOSBIOSVersion"]?.ToString() ?? "N/A";
                    textBoxOutput.AppendText($"\nBIOS Version: {biosVersion}\n");
                }
                searcher.Query = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string name = queryObj["Name"]?.ToString() ?? "N/A";
                    textBoxOutput.AppendText($"\nHardware: {name}\n");
                }
                searcher.Query = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    textBoxOutput.AppendText($"Manufacturer: {queryObj["Manufacturer"]}\n");
                    textBoxOutput.AppendText($"Model: {queryObj["Model"]}\n");
                    textBoxOutput.AppendText($"System Type: {queryObj["SystemType"]}\n");
                    textBoxOutput.AppendText($"Total Physical Memory: {queryObj["TotalPhysicalMemory"]} bytes\n");
                }
                ManagementObjectSearcher sercher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject obj in sercher.Get())
                {
                    textBoxOutput.AppendText($"Serial Number: {obj.GetPropertyValue("SerialNumber")}\n");
                }
                ManagementObjectSearcher procecorSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject obj in procecorSearcher.Get())
                {
                    string processorName = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
                    textBoxOutput.AppendText($"\nProcessor: {processorName}\n");
                }
                ManagementObjectSearcher videoSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                foreach (ManagementObject obj in videoSearcher.Get())
                {
                    string name = obj["Name"]?.ToString();
                    textBoxOutput.AppendText($"\nVideoController: {name}\n");
                }
                ManagementObjectSearcher diskSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject obj in diskSearcher.Get())
                {
                    string name = obj["Model"]?.ToString();
                    textBoxOutput.AppendText($"\nDiscDrive: {name}\n");
                }
                ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                foreach (ManagementObject obj in ramSearcher.Get())
                {
                    string name = obj["Capacity"]?.ToString();
                    textBoxOutput.AppendText($"\nPhisical Memory: {name}\n");
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying WMI: " + ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveComputerInformation();
        }

        private void SaveComputerInformation()
        {
            try
            {
                string fileName = "hardware_info.txt";
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Computer Hardware Information");
                    writer.WriteLine("-----------------------------");
                    writer.WriteLine();
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        string manufacturer = queryObj["Manufacturer"]?.ToString() ?? "N/A";
                        string model = queryObj["Product"]?.ToString() ?? "N/A";
                        string serialNumber = queryObj["SerialNumber"]?.ToString() ?? "N/A";
                        writer.WriteLine($"Motherboard Manufacturer: {manufacturer}");
                        writer.WriteLine($"Motherboard Model: {model}");
                        writer.WriteLine($"Motherboard Serial Number: {serialNumber}");
                    }
                    searcher.Query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter WHERE Manufacturer != 'Microsoft'");
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        string name = queryObj["Name"]?.ToString() ?? "N/A";
                        string macAddress = queryObj["MACAddress"]?.ToString() ?? "N/A";
                        writer.WriteLine($"\nNetwork Adapter Name: {name}\n");
                        writer.WriteLine($"MAC Address: {macAddress}\n");
                    }
                    searcher.Query = new ObjectQuery("SELECT * FROM Win32_BIOS");
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        string biosVersion = queryObj["SMBIOSBIOSVersion"]?.ToString() ?? "N/A";
                        writer.WriteLine($"\nBIOS Version: {biosVersion}\n");
                    }
                    searcher.Query = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'");
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        string name = queryObj["Name"]?.ToString() ?? "N/A";
                        writer.WriteLine($"\nHardware: {name}\n");
                    }
                    searcher.Query = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        writer.WriteLine($"Manufacturer: {queryObj["Manufacturer"]}\n");
                        writer.WriteLine($"Model: {queryObj["Model"]}\n");
                        writer.WriteLine($"System Type: {queryObj["SystemType"]}\n");
                        writer.WriteLine($"Total Physical Memory: {queryObj["TotalPhysicalMemory"]} bytes\n");
                    }
                    ManagementObjectSearcher sercher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                    foreach (ManagementObject obj in sercher.Get())
                    {
                        writer.WriteLine($"Serial Number: {obj.GetPropertyValue("SerialNumber")}\n");
                    }
                    ManagementObjectSearcher procecorSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                    foreach (ManagementObject obj in procecorSearcher.Get())
                    {
                        string processorName = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
                        writer.WriteLine($"\nProcessor: {processorName}\n");
                    }
                    ManagementObjectSearcher videoSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                    foreach (ManagementObject obj in videoSearcher.Get())
                    {
                        string name = obj["Name"]?.ToString();
                        writer.WriteLine($"\nVideoController: {name}\n");
                    }
                    ManagementObjectSearcher diskSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                    foreach (ManagementObject obj in diskSearcher.Get())
                    {
                        string name = obj["Model"]?.ToString();
                        writer.WriteLine($"\nDiscDrive: {name}\n");
                    }
                    ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                    foreach (ManagementObject obj in ramSearcher.Get())
                    {
                        string name = obj["Capacity"]?.ToString();
                        writer.WriteLine($"\nPhisical Memory: {name}\n");
                    }
                }
                MessageBox.Show("Computer information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the computer information: " + ex.Message);
            }
        }
    }
}

