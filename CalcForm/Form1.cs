using System;
using System.Windows.Forms;

namespace CalcForm
{
    internal enum Operator
    {
        NONE = 0, ADD, SUB, MUL, DIV
    }

    public partial class Form1 : Form
    {
        private string operand1 = "0", operand2 = "0";
        private bool operand_check = false, is_first_input = true;
        private Operator my_operator = Operator.NONE;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 22;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            KeyPreview = true;
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
                if (operand_check == false)
                {
                    operand1 = s.Text;
                }
                else
                {
                    operand2 = s.Text;
                }

                is_first_input = false;
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
            double result;
            switch (my_operator)
            {
                case Operator.ADD:
                    textBox2.Text = (double.Parse(operand2) > 0) ?
                        $"{operand1} + {operand2} =" : $"{operand1} + ({operand2}) =";
                    result = double.Parse(operand1) + double.Parse(operand2);
                    break;

                case Operator.SUB:
                    textBox2.Text = (double.Parse(operand2) > 0) ?
                        $"{operand1} - {operand2} =" : $"{operand1} - ({operand2}) =";
                    result = double.Parse(operand1) - double.Parse(operand2);
                    break;

                case Operator.MUL:
                    textBox2.Text = (double.Parse(operand2) > 0) ?
                        $"{operand1} × {operand2} =" : $"{operand1} × ({operand2}) =";
                    result = double.Parse(operand1) * double.Parse(operand2);
                    break;

                case Operator.DIV:
                    textBox2.Text = (double.Parse(operand2) > 0) ?
                        $"{operand1} ÷ {operand2} =" : $"{operand1} ÷ ({operand2}) =";
                    result = double.Parse(operand1) / double.Parse(operand2);
                    break;

                default:
                    textBox2.Text = $"{operand1} =";
                    result = double.Parse(operand1);
                    break;
            }
            is_first_input = true;
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
                if (operand1.Length > 1)
                {
                    operand1 = operand1.Substring(0, operand1.Length - 1);
                }
                else
                {
                    operand1 = "0";
                    is_first_input = true;
                }

                if (operand1 == "-")
                {
                    operand1 = "0";
                    is_first_input = true;
                }
                textBox1.Text = operand1;
            }
            else
            {
                if (operand2.Length > 1)
                {
                    operand2 = operand2.Substring(0, operand2.Length - 1);
                }
                else
                {
                    operand2 = "0";
                    is_first_input = true;
                }

                if (operand2 == "-")
                {
                    operand2 = "0";
                    is_first_input = true;
                }
                textBox1.Text = operand2;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".") == false)
            {
                if (operand_check == false)
                {
                    operand1 += ".";
                }
                else
                {
                    operand2 += ".";
                }
                textBox1.Text += ".";
            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (operand_check == false)
            {
                double n = double.Parse(operand1);
                textBox1.Text = (-n).ToString();
                operand1 = (-n).ToString();
            }
            else
            {
                double n = double.Parse(operand2);
                textBox1.Text = (-n).ToString();
                operand2 = (-n).ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    Number_Click(number0, EventArgs.Empty);
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    Number_Click(number1, EventArgs.Empty);
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    Number_Click(number2, EventArgs.Empty);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    Number_Click(number3, EventArgs.Empty);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    Number_Click(number4, EventArgs.Empty);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    Number_Click(number5, EventArgs.Empty);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    Number_Click(number6, EventArgs.Empty);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    Number_Click(number7, EventArgs.Empty);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    if (e.Shift)
                    {
                        Operator_Click(mult_b, EventArgs.Empty);
                    }
                    else
                    {
                        Number_Click(number8, EventArgs.Empty);
                    }
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    Number_Click(number9, EventArgs.Empty);
                    break;
                case Keys.Decimal:
                    Dot_Click(dot_b, EventArgs.Empty);
                    break;
                case Keys.Oemplus:
                    if (e.Shift)
                    {
                        Operator_Click(plus_b, EventArgs.Empty);
                    }
                    else
                    {
                        Calc_Click(calc_b, EventArgs.Empty);
                    }
                    break;
                case Keys.Add:
                    Operator_Click(plus_b, EventArgs.Empty);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    Operator_Click(minus_b, EventArgs.Empty);
                    break;
                case Keys.Multiply:
                    Operator_Click(mult_b, EventArgs.Empty);
                    break;
                case Keys.OemQuestion:
                case Keys.Divide:
                    Operator_Click(div_b, EventArgs.Empty);
                    break;
                case Keys.Back:
                    Backspace_Click(button1, EventArgs.Empty);
                    break;
                case Keys.Enter:
                    Calc_Click(calc_b, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }
    }
}