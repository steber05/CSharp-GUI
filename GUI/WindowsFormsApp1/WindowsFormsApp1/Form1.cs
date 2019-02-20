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
            int num1 = Int32.parse(box1.Text);//Box 1
            int num2 = Int32.parse(box2.Text);//Box 2
            int highNum;
            //Check number orientation
            if (Int32.parse(box1.Text) > Int32.parse(box2.Text))
            {
                highNum = num1;
            }
            else
            {
                highNum = num2
            }
            //Check if number is prime and display it
            for(int i = num1; i <= highNum; i++)
            {
                primeNumber(i);
            }
        }
        //Check if number is prime
        public bool primeNumber(int n)
        {
            //All the conditions for if it is not a prime number
            //Cancel out 1 and 0
            if(n < 2)
            {
                return false;
            }
            //Cancel all even numbers except 2
            else if (n % 2 == 0 && n != 2)
            {
                return false;
            }
            //Loop condition is i*i <= n (Square root)
            else
            {
                for(int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return;
                    }
                }
            }
            //If it is a prime number
            displayPrime(n);
        }
        //Display prime numbers to third text box with linesize of 5
        public void displayPrimes(int prime)
        {
            int lineCount = 0;

            if (lineCount == 5)
            {
                result.AppendText("\r\n");
                lineCount = 0;
            }
            lineCount++;
            result.AppendText(Convert.ToString(prime + " "));
        }
    }
}