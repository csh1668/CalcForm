using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    enum Operator
    {
        NONE = 0, ADD, SUB, MUL, DIV
    }
    public partial class Form1 : Form
    {
        string operand1 = "0", operand2 = "0";
        bool operand_check = false, is_first_input = true;
        Operator my_operator = Operator.NONE;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 22;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            var s = sender as Button;
            if (s == null)
            {
                Console.WriteLine("이럴리가 없는데..");
                return;
            }

            if (is_first_input == true)
            {
                textBox1.Text = s.Text;
                is_first_input = false;
                if (operand_check == false)
                {
                    operand1 = s.Text;
                }
                else
                {
                    operand2 = s.Text;
                }
            }
            else
            {
                textBox1.Text += s.Text;
                if (operand_check == false)
                {
                    operand1 += s.Text;
                }
                else
                {
                    operand2 += s.Text;
                }
            }
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            var s = sender as Button;
            if (s == null)
            {
                Console.WriteLine("이럴리가 없는데..");
                return;
            }

            switch (s.Text)
            {
                case "+":
                    textBox2.Text = operand1 + " + ";
                    my_operator = Operator.ADD;
                    break;
                case "-":
                    textBox2.Text = operand1 + " - ";
                    my_operator = Operator.SUB;
                    break;
                case "×":
                    textBox2.Text = operand1 + " × ";
                    my_operator = Operator.MUL;
                    break;
                case "÷":
                    textBox2.Text = operand1 + " ÷ ";
                    my_operator = Operator.DIV;
                    break;
                default:
                    break;
            }
            operand2 = operand1;
            operand_check = true;
            is_first_input = true;
        }
        private void Calc_Click(object sender, EventArgs e)
        {
            double result = 0;
            switch (my_operator)
            {
                case Operator.ADD:
                    textBox2.Text = $"{operand1} + {operand2} =";
                    result = double.Parse(operand1) + double.Parse(operand2);
                    break;
                case Operator.SUB:
                    textBox2.Text = $"{operand1} - {operand2} =";
                    result = double.Parse(operand1) - double.Parse(operand2);
                    break;
                case Operator.MUL:
                    textBox2.Text = $"{operand1} × {operand2} =";
                    result = double.Parse(operand1) * double.Parse(operand2);
                    break;
                case Operator.DIV:
                    textBox2.Text = $"{operand1} ÷ {operand2} =";
                    result = double.Parse(operand1) / double.Parse(operand2);
                    break;
                default:
                    break;
            }
            operand1 = result.ToString();
            textBox1.Text = result.ToString();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            operand1 = "0"; operand2 = "0";
            operand_check = false; is_first_input = true;
            my_operator = Operator.NONE;
            textBox1.Text = "0";
            textBox2.Text = "";
        }
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (operand_check == false)
            {
                if (operand1 == null) return;
                else if (operand1.Length > 1)
                {
                    operand1 = operand1.Substring(0, operand1.Length - 1);
                }
                else
                {
                    operand1 = "0";
                    is_first_input = true;
                }
                textBox1.Text = operand1;
            }
        }
    }

}
