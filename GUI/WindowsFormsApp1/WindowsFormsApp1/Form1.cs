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
            int num1 = Int32.Parse(box1.Text);
            int num2 = Int32.Parse(box2.Text);
            //Check number orientation
            if (num1 > 0 || num2 > 0)
            {
                handleBoxNum(num1, num2);
            }
            
                    
        }
        //Checks number orientation then runs sorted numbers(low to high) handlePrimes
        public void handleBoxNum(int num1, int num2)
        {
            int highNum;
            int lowNum;
            //Check number orientation
            if(num1 > num2)
            {
                highNum = num1;
                lowNum = num2;
            }
            else
            {
                highNum = num2;
                lowNum = num1;
            }
            //Handle all prime numbers
            handlePrimes(lowNum, highNum);
        }
        //Check if number is prime and display it from the lowest number to the highest
        public void handlePrimes(int lowNum, int highNum)
        {
            //Added at top so the for loop doesn't keep it as the same value
            int lineCount = 0;
            //Loop for all numbers between box1 and box2 
            //Start condition is lowest box number. 
            //End condition is highest box number
            for(int i = lowNum; i <= highNum; i++)
            {
                //Check if number is prime
                if(primeNumber(i))
                {
                    //Add new line at fifth number
                    if(lineCount == 5)
                    {
                        result.AppendText("\r\n");
                        lineCount = 0;
                    }
                    //Update lineCount because it gets set back to 0
                    lineCount++;
                    // Display prime numbers to third box
                    result.AppendText(Convert.ToString(i + " "));
                }
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
                        return false;
                    }
                }
            }
            //If it is a prime number
            return true;
        }
    }
}