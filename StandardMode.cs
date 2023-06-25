using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Calculator : KryptonForm
    {
        private double _valueOne;
        private double _valueTwo;
        private double _result;
        private string _operators = "";
        private const string MathError = "MATH Error";
        private const string SynError = "SYNTAX Error";

        public Calculator() => InitializeComponent();

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new AdvancedMode();
            form2.ShowDialog();
            Application.Exit();
        }

        private void Button_Clear_Click(Object sender, EventArgs e) => textBoxOutput.Text = "0";

        private void Button_ClearEntry_Click(Object sender, EventArgs e)
        {
            _valueOne = 0.0;
            _valueTwo = 0.0;
            _result = 0.0;
            _operators = "";
            textBoxOutput.Text = "0";
            textBoxCalculation.Clear();
        }

        private void Button_ClearRight_Click(Object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text.Length > 1 ? textBoxOutput.Text.Remove(textBoxOutput.Text.Length - 1, 1) : "0";
        }

        private void Button_Click(Object sender, EventArgs e)
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
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " - ";
            _operators = "-";
        }

        private void Button_Addition_Click(Object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " + ";
            _operators = "+";
        }

        private void Button_Multiplication_Click(Object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " x ";
            _operators = "*";
        }

        private void Button_Remainder_Click(Object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " % ";
            _operators = "%";
        }

        private void Button_Division_Click(Object sender, EventArgs e)
        {
            _valueOne = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
            textBoxCalculation.Text = _valueOne + " ÷ ";
            _operators = "/";
        }

        private void Button_Square_Click(Object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                textBoxCalculation.Text = "sqr(" + _valueOne + ")";
                _result = _valueOne * _valueOne;
                textBoxOutput.Text = _result.ToString();
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_SquareRoot_Click(Object sender, EventArgs e)
        {
            try
            {
                _valueOne = double.Parse(textBoxOutput.Text);
                if (_valueOne < 0)
                {
                    textBoxCalculation.Clear();
                    textBoxOutput.Text = MathError;
                }
                else
                {
                    textBoxCalculation.Text = "√(" + _valueOne + ")";
                    _result = Math.Sqrt(_valueOne);
                    textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Over_Click(object sender, EventArgs e)
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
                    textBoxCalculation.Text = "1/(" + _valueOne + ")";
                    _result = 1.0 / _valueOne;
                    textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                }
            }
            catch (Exception)
            {
                textBoxCalculation.Clear();
                textBoxOutput.Text = SynError;
            }
        }

        private void Button_Equals_Click(Object sender, EventArgs e)
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
                        case "%":
                            _valueTwo = double.Parse(textBoxOutput.Text);
                            if (_valueTwo == 0)
                            {
                                textBoxCalculation.Clear();
                                textBoxOutput.Text = MathError;
                            }
                            else
                            {
                                _result = _valueOne % _valueTwo;
                                textBoxCalculation.Text += _valueTwo + " = ";
                                textBoxOutput.Text = _result.ToString(CultureInfo.CurrentCulture);
                            }

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