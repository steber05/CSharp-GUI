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
            result.Clear();//Clear third textbox
            int num1 = Convert.ToInt32(box1.Text);//Box 1
            int num2 = Convert.ToInt32(box2.Text);//Box 2
            LinkedList<int> nums = new LinkedList<int>();//Numbers between box 1 and box 2
            LinkedList<int> primes = new LinkedList<int>();//Prime numbers in nums list
            //Check number orientation
            nums = numberOrientation(num1, num2);
            //Check if number is prime
            //Add prime numbers to a list
            primes = sortPrimes(nums);
            //Display prime numbers to third text box with linesize of 5
            displayPrimes(primes);

        }
        //Check number orientation
        public LinkedList<int> numberOrientation(int num1, int num2)
        {
            LinkedList<int> nums = new LinkedList<int>();
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
            return nums;
        }
        //Check if number is prime
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
        //Add prime numbers to a list (Filters out 0 and 1)
        public LinkedList<int> sortPrimes(LinkedList<int> nums)
        {
            LinkedList<int> lst = new LinkedList<int>();
            foreach (var num in nums)
            {
                if (primeNumber(num) && num > 1)//Check if 1 and 0 are counted as prime numbers and adjust
                {
                    lst.AddLast(num);
                }
            }
            return lst;
        }
        //Display prime numbers to third text box with linesize of 5
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