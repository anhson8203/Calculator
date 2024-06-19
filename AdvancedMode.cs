using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CalculatorApplication
{
    public partial class AdvancedMode : KryptonForm
    {
        private double _valueOne;
        private double _valueTwo;
        private double _result;
        private string _operators = "";
        private const string MathError = "MATH Error";
        private const string SynError = "SYNTAX Error";

        public AdvancedMode() => InitializeComponent();

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            Hide();
            var calculator = new Calculator();
            calculator.ShowDialog();
            Application.Exit();
        }

        private void Button_Clear_Click(object sender, EventArgs e) => textBoxOutput.Text = "0";

        private void Button_ClearEntry_Click(object sender, EventArgs e)
        {
            _valueOne = 0.0;
            _valueTwo = 0.0;
            _result = 0.0;
            textBoxCalculation.Clear();
            textBoxOutput.Text = "0";
            _operators = "";
        }

        private void Button_ClearRight_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == MathError || textBoxOutput.Text == SynError)
            {
                textBoxOutput.Text = "0";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text.Length > 1 ? textBoxOutput.Text.Remove(textBoxOutput.Text.Length - 1, 1) : "0";
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0")
            {
                textBoxOutput.Text = ((Button)sender).Text;
            }
            else
            {
                textBoxOutput.Text += ((Button)sender).Text;
            }
        }

        private void Button0_Click(object sender, EventArgs e)
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

        private void Button_Decimal_Click(object sender, EventArgs e)
        {
            if (!textBoxOutput.Text.Contains("."))
            {
                textBoxOutput.Text += ".";
            }
        }

        private void Button_Pi_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            textBoxOutput.Text = Math.PI.ToString(CultureInfo.CurrentCulture);
        }

        private void Button_Euler_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            textBoxOutput.Text = Math.E.ToString(CultureInfo.CurrentCulture);
        }

        private void Button_MinusPlus_Click(object sender, EventArgs e)
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

        private void Button_Subtraction_Click(object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " - ";
            _operators = "-";
        }

        private void Button_Multiplication_Click(object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " x ";
            _operators = "*";
        }

        private void Button_Division_Click(object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " ÷ ";
            _operators = "/";
        }

        private void Button_Addition_Click(object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " + ";
            _operators = "+";
        }

        private void Button_Abs_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                _result = Math.Abs(_valueOne);
                textBoxCalculation.Text = "Abs(" + _valueOne + ")";
                textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Pow_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                textBoxOutput.Clear();
                textBoxCalculation.Text = _valueOne + " ^ ";
                _operators = "**";
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Factorial_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                _result = 1.0;
                for (double i = 1; i <= _valueOne; i++)
                {
                    _result *= i;
                }

                textBoxCalculation.Text = "fact(" + _valueOne + ")";
                textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_TenPow_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                _result = Math.Pow(10, _valueOne);
                textBoxCalculation.Text = "10^(" + _valueOne + ")";
                textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_OneOver_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                if (_valueOne == 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = MathError;
                }
                else
                {
                    _result = 1.0 / _valueOne;
                    textBoxCalculation.Text = "1/(" + _valueOne + ")";
                    textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Log_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                if (_valueOne == 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = MathError;
                }
                else
                {
                    _result = Math.Log10(_valueOne);
                    textBoxCalculation.Text = "log(" + _valueOne + ")";
                    textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Ln_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                if (_valueOne == 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = MathError;
                }
                else
                {
                    _result = Math.Log(_valueOne);
                    textBoxCalculation.Text = "ln(" + _valueOne + ")";
                    textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Square_Click(object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                textBoxOutput.Clear();
                textBoxCalculation.Text = "√(" + _valueOne + ")";
                _operators = "/*";
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCalculation.Text.Contains("="))
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = SynError;
                }
                else
                {
                    switch (_operators)
                    {
                        case "-":
                            _valueTwo = double.Parse(textBoxOutput.Text);
                            _result = _valueOne - _valueTwo;
                            textBoxCalculation.Text += _valueTwo + " = ";
                            textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            break;
                        case "+":
                            _valueTwo = double.Parse(textBoxOutput.Text);
                            _result = _valueOne + _valueTwo;
                            textBoxCalculation.Text += _valueTwo + " = ";
                            textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            break;
                        case "*":
                            _valueTwo = double.Parse(textBoxOutput.Text);
                            _result = _valueOne * _valueTwo;
                            textBoxCalculation.Text += _valueTwo + " = ";
                            textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            break;
                        case "/":
                            _valueTwo = double.Parse(textBoxOutput.Text);
                            if (_valueTwo == 0)
                            {
                                textBoxCalculation.Clear();
                                textBoxOutput.Text = MathError;
                            }
                            else
                            {
                                _result = _valueOne / _valueTwo;
                                textBoxCalculation.Text += _valueTwo + " = ";
                                textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            }

                            break;
                        case "/*":
                            if (_valueOne < 0)
                            {
                                textBoxCalculation.Clear();
                                textBoxOutput.Text = MathError;
                            }
                            else
                            {
                                _valueTwo = double.Parse(textBoxOutput.Text);
                                _result = Math.Pow(_valueOne, 1.0 / _valueTwo);
                                textBoxCalculation.Text = _valueTwo + textBoxCalculation.Text + " = ";
                                textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            }

                            break;
                        case "**":
                            _valueTwo = double.Parse(textBoxOutput.Text);
                            _result = Math.Pow(_valueOne, _valueTwo);
                            textBoxCalculation.Text += _valueTwo + " = ";
                            textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void TextBoxOutput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOutput.Text.Length > 8 && textBoxOutput.Text != MathError && textBoxOutput.Text != SynError)
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