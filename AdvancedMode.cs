using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CalculatorApplication
{
    public partial class AdvancedMode : KryptonForm
    {
        private double valueOne = 0.0;
        private double valueTwo = 0.0;
        private double result = 0.0;
        private string operators = "";
        private readonly string mathError = "MATH Error";
        private readonly string synError = "SYNTAX Error";

        public AdvancedMode()
        {
            InitializeComponent();
        }

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator calculator = new Calculator();
            calculator.ShowDialog();
            Application.Exit();
        }

        private void Button_Clear_Click(Object senderm, EventArgs e)
        {
            textBoxOutput.Text = "0";
        }

        private void Button_ClearEntry_Click(Object sender, EventArgs e)
        {
            valueOne = 0.0;
            valueTwo = 0.0;
            result = 0.0;
            textBoxCalculation.Clear();
            textBoxOutput.Text = "0";
            operators = "";
        }

        private void Button_ClearRight_Click(Object sender, EventArgs e)
        {
            if (textBoxOutput.Text.Length > 1)
            {
                textBoxOutput.Text = textBoxOutput.Text.Remove(textBoxOutput.Text.Length - 1, 1);
            }
            else
            {
                textBoxOutput.Text = "0";
            }
        }

        private void Button_Click(Object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0")
            {
                textBoxOutput.Text = (sender as Button).Text;
            }
            else
            {
                textBoxOutput.Text += (sender as Button).Text;
            }
        }

        private void Button0_Click(Object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0")
            {
                textBoxOutput.Text = "0";
            }
            else
            {
                textBoxOutput.Text += "0";
            }
        }

        private void Button_Decimal_Click(Object sender, EventArgs e)
        {
            if (!textBoxOutput.Text.Contains("."))
            {
                textBoxOutput.Text += ".";
            }
        }

        private void Button_Pi_Click(Object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            textBoxOutput.Text = Math.PI.ToString();
        }

        private void Button_Euler_Click(Object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            textBoxOutput.Text = Math.E.ToString();
        }

        private void Button_MinusPlus_Click(Object sender, EventArgs e)
        {
            if (textBoxOutput.Text.Contains("-"))
            {
                textBoxOutput.Text = textBoxOutput.Text.Trim('-');
            }
            else
            {
                textBoxOutput.Text = "-" + textBoxOutput.Text;
            }
        }

        private void Button_Subtraction_Click(Object sender, EventArgs e)
        {
            valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = valueOne + " - ";
            operators = "-";
        }

        private void Button_Multiplication_Click(Object sender, EventArgs e)
        {
            valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = valueOne + " x ";
            operators = "*";
        }

        public void Button_Divison_Click(Object sender, EventArgs e)
        {
            valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = valueOne + " ÷ ";
            operators = "/";
        }

        private void Button_Addittion_Click(Object sender, EventArgs e)
        {
            valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = valueOne + " + ";
            operators = "+";
        }

        private void Button_Abs_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                result = Math.Abs(valueOne);
                textBoxCalculation.Text = "Abs(" + valueOne + ")";
                textBoxOutput.Text = result.ToString();
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_Pow_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                textBoxOutput.Clear();
                textBoxCalculation.Text = valueOne + " ^ ";
                operators = "**";
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_Factorial_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                result = 1.0;
                for (double i = 1; i <= valueOne; i++)
                {
                    result *= i;
                }
                textBoxCalculation.Text = "fact(" + valueOne + ")";
                textBoxOutput.Text = result.ToString();
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_TenPow_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                result = Math.Pow(10, valueOne);
                textBoxCalculation.Text = "10^(" + valueOne + ")";
                textBoxOutput.Text = result.ToString();
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_OneOver_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                if (valueOne == 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = mathError;
                }
                else
                {
                    result = 1.0 / valueOne;
                    textBoxCalculation.Text = "1/(" + valueOne + ")";
                    textBoxOutput.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_Log_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                if (valueOne == 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = mathError;
                }
                else
                {
                    result = Math.Log10(valueOne);
                    textBoxCalculation.Text = "log(" + valueOne + ")";
                    textBoxOutput.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_Ln_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                if (valueOne == 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = mathError;
                }
                else
                {
                    result = Math.Log(valueOne);
                    textBoxCalculation.Text = "ln(" + valueOne + ")";
                    textBoxOutput.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_Square_Click(Object sender, EventArgs e)
        {
            try
            {
                valueOne = double.Parse(textBoxOutput.Text);
                textBoxOutput.Clear();
                textBoxCalculation.Text = "√(" + valueOne + ")";
                operators = "/*";
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void Button_Equals_Click(Object sender, EventArgs e)
        {
            try
            {
                if (textBoxCalculation.Text.Contains("="))
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = synError;
                }
                else
                {
                    switch (operators)
                    {
                        case "-":
                            valueTwo = double.Parse(textBoxOutput.Text);
                            result = valueOne - valueTwo;
                            textBoxCalculation.Text += valueTwo + " = ";
                            textBoxOutput.Text = result.ToString();
                            break;
                        case "+":
                            valueTwo = double.Parse(textBoxOutput.Text);
                            result = valueOne + valueTwo;
                            textBoxCalculation.Text += valueTwo + " = ";
                            textBoxOutput.Text = result.ToString();
                            break;
                        case "*":
                            valueTwo = double.Parse(textBoxOutput.Text);
                            result = valueOne * valueTwo;
                            textBoxCalculation.Text += valueTwo + " = ";
                            textBoxOutput.Text = result.ToString();
                            break;
                        case "/":
                            valueTwo = double.Parse(textBoxOutput.Text);
                            if (valueTwo == 0)
                            {
                                textBoxCalculation.Clear();
                                textBoxOutput.Text = mathError;
                            }
                            else
                            {
                                result = valueOne / valueTwo;
                                textBoxCalculation.Text += valueTwo + " = ";
                                textBoxOutput.Text = result.ToString();
                            }
                            break;
                        case "/*":
                            if (valueOne < 0)
                            {
                                textBoxCalculation.Clear();
                                textBoxOutput.Text = mathError;
                            }
                            else
                            {
                                valueTwo = double.Parse(textBoxOutput.Text);
                                result = Math.Pow(valueOne, (double)1.0 / valueTwo);
                                textBoxCalculation.Text = valueTwo + textBoxCalculation.Text + " = ";
                                textBoxOutput.Text = result.ToString();
                            }
                            break;
                        case "**":
                            valueTwo = double.Parse(textBoxOutput.Text);
                            result = Math.Pow(valueOne, valueTwo);
                            textBoxCalculation.Text += valueTwo + " = ";
                            textBoxOutput.Text = result.ToString();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = synError;
            }
        }

        private void TextBoxOutput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOutput.Text.Length > 8 && textBoxOutput.Text != mathError && textBoxOutput.Text != synError)
            {
                textBoxOutput.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                textBoxOutput.Location = new Point(3, 63);
            }
            else
            {
                textBoxOutput.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Regular);
                textBoxOutput.Location = new Point(3, 53);
            }
        }
    }
}