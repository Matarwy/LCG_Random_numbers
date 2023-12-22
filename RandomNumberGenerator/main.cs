using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RandomNumberGenerator
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            randomNumbersTable.Rows.Clear();
            if (seedTextBox.Text.Equals(String.Empty) || multiplierTextBox.Text.Equals(String.Empty) || incrementTextBox.Equals(String.Empty) || modulusTextBox.Equals(String.Empty) || numberOfIterationsTextBox.Equals(String.Empty))
            {
                MessageBox.Show("Invalid Input, Please Enter Valid Input");
            }else
            {

                double seed = double.Parse(seedTextBox.Text);
                double multiplier = double.Parse(multiplierTextBox.Text);
                double increment = double.Parse(incrementTextBox.Text);
                double modulus = double.Parse(modulusTextBox.Text);
                double iteration = double.Parse(numberOfIterationsTextBox.Text);

                if (validateInput(multiplier, increment, modulus, seed))
                {
                    List<double> randomNumber = LCG_Generator(multiplier, increment, modulus, seed, iteration);
                    double LongestPeriod = calculateActualPeriodLenth(randomNumber, multiplier, increment, modulus, seed);
                    for (int i = 0; i < randomNumber.Count; i++)
                    {
                        randomNumbersTable.Rows.Add(i + 1, randomNumber[i]);
                    }
                    cycleLengthTextBox.Text = LongestPeriod.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Input, Please Enter Valid Input");
                }


            }
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
        public bool validateInput(double multiplier, double increment, double modulus, double x0)
        {
            if ((modulus > 0) && (modulus > multiplier) && (modulus > increment) && (x0 < modulus))
                return true;

            return false;
        }


        public List<double> LCG_Generator(double multiplier, double increment, double modulus, double x0, double iteration)
        {
            List<double> lcg = new List<double>();
            double seed_i = x0;

            for (int i = 1; i <= iteration; i++)
            {
                seed_i = ((multiplier * seed_i) + increment) % modulus;
                lcg.Add(seed_i);
            }
            return lcg;
        }


        public double calculateActualPeriodLenth(List<double> randomNumber, double multiplier, double increment, double modulus, double x0)
        {
            double LongestPeriod = 0;
            double k = modulus - 1;
            bool check1 = true, check2 = true, check3 = true;

            if (IsPowerOfTwo(modulus) && (increment != 0))
            {
                if (IsRelativelyPrime(increment, modulus))
                {
                    LongestPeriod = modulus;
                    check1 = false;
                }
            }
            if (IsPowerOfTwo(modulus) && (increment == 0))
            {
                if (IsSeedOdd(x0) && (multiplier == (5 + 8 * k)))
                {
                    LongestPeriod = modulus / 4;
                    check2 = false;
                }
            }
            if (IsPrime(modulus) && (increment == 0))
            {
                if (IsDivisible((Math.Pow(multiplier, k) - 1), modulus))
                {
                    LongestPeriod = modulus - 1;
                    check3 = false;
                }
            }
            if (check1 && check2 && check3)
            {
                double first_element = randomNumber[0];
                double second_element = randomNumber[1];
                LongestPeriod++;
                for (int i = 2; i < randomNumber.Count; i++)
                {
                    if (randomNumber[i] == second_element && randomNumber[i - 1] == first_element)
                        break;
                    else
                        LongestPeriod++;
                }
            }

            return LongestPeriod;
        }



        public bool IsPrime(double modulus)
        {
            if (modulus <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(modulus); i++)
            {
                if (modulus % i == 0)
                    return false;

            }
            return true;
        }


        public bool IsDivisible(double a, double b)
        {
            double cDouble = a / b;
            int cInteger = (int)cDouble;
            if (cInteger == cDouble)
                return true;
            return false;
        }


        public bool IsPowerOfTwo(double num)
        {
            if (num == 0)
                return false;
            while (num != 1)
            {
                if (num % 2 != 0)
                    return false;
                num = num / 2;
            }
            return true;
        }


        public bool IsSeedOdd(double seed)
        {
            if (seed % 2 != 0)
                return true;
            return false;
        }


        public bool IsRelativelyPrime(double increment, double modulus)
        {
            double num = Math.Min(modulus, increment);
            for (int i = 2; i <= num; i++)
            {
                if (IsDivisible(increment, i) && IsDivisible(modulus, i))
                    return false;
            }
            return true;
        }


        public List<double> getPrimeNumbers(double number)
        {
            List<double> primeNumbers = new List<double>();
            bool isPrime = true;

            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
                isPrime = true;
            }

            return primeNumbers;
        }
    }
}
