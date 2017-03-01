using System;
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
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        OperationType? operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
      
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            
            input += "3";
            this.textBox1.Text = input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            operation = null;
        
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void decpoint_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void squared_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Squared);
            
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Root);
        }

        private void minusplus_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = result.ToString();
            textBox1.Text += input;

        }

        private void sin_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Sin);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Cos);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Tan);
        }

        private void log_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Log);
        }

        private void exp_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Exp);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += Math.PI;
            this.textBox1.Text += input;
        }

        private void ClickOperator(OperationType op)
        {
            if (operation != null)
            {
                calculate();
            }
            operand1 = input;
            operation = op;
            input = string.Empty;

        }
        private void mult_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Multiplication);
            
        }

        private void divi_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Division);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Addition);
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            ClickOperator(OperationType.Subtraction);
        }



        private void calculate()
        {
            operand2 = input;
            double num1, num2;
           if (operation == OperationType.Squared)
            {
                double.TryParse(operand1, out num1);
                result = num1 * num1;
                textBox1.Text = result.ToString(); 
                // this works but can't be used within an equation yet
            }
           else if (operation==OperationType.Sin)
            {
                double.TryParse(operand1, out num1);
                result = Math.Sin(num1); //gives answer in rad
                textBox1.Text = result.ToString();
            }
           else if (operation==OperationType.Tan)
            {
                double.TryParse(operand1, out num1);
                result = Math.Tan(num1);
                textBox1.Text = result.ToString();
            }
            else if (operation == OperationType.Cos)
            {
                double.TryParse(operand1, out num1);
                result = Math.Cos(num1);
                textBox1.Text = result.ToString();
            }
            else if (operation == OperationType.Exp)
            {
                double.TryParse(operand1, out num1);
                result = Math.Exp(num1);
                textBox1.Text = result.ToString();
            }
            else if (!double.TryParse(operand1, out num1) || !double.TryParse(operand2, out num2))
            {
                textBox1.Text = "Error";
            }
            else if (operation == OperationType.Addition)
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == OperationType.Subtraction)
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == OperationType.Division)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/ZERO";
                }
            }
            else if (operation == OperationType.Multiplication)
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();

            }
            else if (operation == OperationType.Squared)
            {
                result = num1 * num1; // Error...
                textBox1.Text = result.ToString();
            }
            input = result.ToString();
        }
        private void equals_Click(object sender, EventArgs e)
        {
            calculate();
            operation = null;
        }
    }
    }

