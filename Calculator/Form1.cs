using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        class Calculator
        {
            public List<string> Value = new List<string>();


        }

        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNumber_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text == "0")
                {
                    textBox.Text += "0"; 
                 
                }

                if (button.Text == "1")
                {
                    textBox.Text += "1";
                }
                if (button.Text == "2")
                {
                    textBox.Text += "2";
                }
                if (button.Text == "3")
                {
                    textBox.Text += "3";
                }
                if (button.Text == "4")
                {
                    textBox.Text += "4";
                }
                if (button.Text == "5")
                {
                    textBox.Text += "5";
                }
                if (button.Text == "6")
                {
                    textBox.Text += "6";
                }
                if (button.Text == "7")
                {
                    textBox.Text += "7";
                }
                if (button.Text == "8")
                {
                    textBox.Text += "8";
                }
                if (button.Text == "9")
                {
                    textBox.Text += "9";
                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {

            textBox.Text = String.Empty;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
         
            if (sender is Button button)
            {
                if (button.Text == "+")
                {
                    textBox.Text += " + ";
                }
            }


        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {


                if (button.Text == "x")
                {
                    textBox.Text += " * ";
                }

            }
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            int result = 0;
           var arrayValue=   textBox.Text.Split(' ');

           foreach (var VARIABLE in arrayValue)
           {
               calculator.Value.Add(VARIABLE.ToString());
           }

           if (arrayValue[1]=="+")
           {
               result = Convert.ToInt32(arrayValue[0]) + Convert.ToInt32(arrayValue[2]);
           }

           textBox.Text = result.ToString();

        }

        
    }
}
