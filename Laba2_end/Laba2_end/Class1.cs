using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_end
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }

        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            numerator = num;
            denominator = denom;
            Reduce();
        }

        public Fraction(Fraction other)
        {
            numerator = other.numerator;
            denominator = other.denominator;
        }

        ~Fraction()
        {
            Console.WriteLine("Fraction object destroyed");
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero");
                }
                denominator = value;
                Reduce();
            }
        }

        public Fraction Reduce()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            return this;
        }

        private int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.numerator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            int num = f1.numerator * f2.denominator;
            int denom = f1.denominator * f2.numerator;
            return new Fraction(num, denom);
        }

        public Fraction Power(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Power cannot be negative");
            }
            return new Fraction((int)Math.Pow(numerator, n), (int)Math.Pow(denominator, n));
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.numerator == f2.numerator && f1.denominator == f2.denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1.numerator * f2.denominator > f2.numerator * f1.denominator;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.numerator * f2.denominator < f2.numerator * f1.denominator;
        }

        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return f1 > f2 || f1 == f2;
        }

        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return f1 < f2 || f1 == f2;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }

}
