using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            result.Clear();
            int num1 = Convert.ToInt32(box1.Text);
            int num2 = Convert.ToInt32(box2.Text);
            LinkedList<int> nums = new LinkedList<int>();
            LinkedList<int> primes = new LinkedList<int>();
            //int lineCount = 0;

            /*if (num1 > 1)
            {
                for (int i = num1; i < num2 + 1; i++)
                {
                    nums.AddLast(i);
                }

                foreach (var num in nums)
                {
                    if (primeNumber(num))
                    {
                        primes.AddLast(num);
                    }
                }

                foreach (var p in primes)
                {
                    if (lineCount == 5)
                    {
                        result.AppendText("\r\n");
                        lineCount = 0;
                    }
                    lineCount++;
                    result.AppendText(Convert.ToString(p + " "));
                }
            }
            else
            {
                label.Visible = true;
            }*/

            //sort if num1 is bigger than num2 or vice versa
            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    nums.AddLast(i);
                }
            }
            else
            {
                for (int i = num2; i <= num1; i++)
                {
                    nums.AddLast(i);
                }
            }
            
            //sorts numbers from a list to another primes list
            /*foreach (var num in nums)
            {
                if (primeNumber(num) && num > 1)
                {
                    primes.AddLast(num);
                }
            }*/

            primes = sortPrimes(nums);

            //Displays all prime numbers to third text box with a linesize of 5 numbers
            /*foreach (var p in primes)
            {
                if (lineCount == 5)
                {
                    result.AppendText("\r\n");
                    lineCount = 0;
                }
                lineCount++;
                result.AppendText(Convert.ToString(p + " "));
            }*/

            displayPrimes(primes);


        }

        public bool primeNumber(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public LinkedList<int> sortPrimes(LinkedList<int> nums)
        {
            LinkedList<int> lst = new LinkedList<int>();
            foreach (var num in nums)
            {
                if (primeNumber(num) && num > 1)
                {
                    lst.AddLast(num);
                }
            }
            return lst;
        }

        public void displayPrimes(LinkedList<int> primes)
        {
            int lineCount = 0;

            foreach (var p in primes)
            {
                if (lineCount == 5)
                {
                    result.AppendText("\r\n");
                    lineCount = 0;
                }
                lineCount++;
                result.AppendText(Convert.ToString(p + " "));
            }
        }
    }
}