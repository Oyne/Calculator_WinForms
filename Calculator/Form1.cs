using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Digits digits = new Digits();
        int operation = 0;
        String sign = "";
        Double tmpValue = 0;
        Double res = 0;
        Exception BigNumberException = new Exception("Too big number");
        Exception NoOperationException = new Exception("No operation choosed");

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            MainTextBox.Text = "0";
        }

        private void DisableDigitAndOperation()
        {
            ZeroButton.Enabled = false;
            OneButton.Enabled = false;
            TwoButton.Enabled = false;
            ThreeButton.Enabled = false;
            FourButton.Enabled = false;
            FiveButton.Enabled = false;
            SixButton.Enabled = false;
            SevenButton.Enabled = false;
            EightButton.Enabled = false;
            NineButton.Enabled = false;
            ComaButton.Enabled = false;
            SignButton.Enabled = false;
            AddButton.Enabled = false;
            SubstractButton.Enabled = false;
            MultiplyButton.Enabled = false;
            DivideButton.Enabled = false;
            OneDividedByButton.Enabled = false;
            CosButton.Enabled = false;
            SquareRootButton.Enabled = false;
            EqualButton.Enabled = false;
            BackspaceButton.Enabled = false;
            ClearEntryButton.Enabled = false;
        }

        private void EnableDigitAndOperation()
        {
            ZeroButton.Enabled = true;
            OneButton.Enabled = true;
            TwoButton.Enabled = true;
            ThreeButton.Enabled = true;
            FourButton.Enabled = true;
            FiveButton.Enabled = true;
            SixButton.Enabled = true;
            SevenButton.Enabled = true;
            EightButton.Enabled = true;
            NineButton.Enabled = true;
            ComaButton.Enabled = true;
            SignButton.Enabled = true;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
            OneDividedByButton.Enabled = true;
            CosButton.Enabled = true;
            SquareRootButton.Enabled = true;
            EqualButton.Enabled = true;
            BackspaceButton.Enabled = true;
            ClearEntryButton.Enabled = true;
        }

        private void DigitsAdd(object sender, EventArgs e)
        {
            tmpValue = Double.Parse(MainTextBox.Text + ((Button)sender).Text);

            if (MainTextBox.Text.Contains(",") && MainTextBox.Text.IndexOf(",") == MainTextBox.TextLength - 1)
                MainTextBox.Text = MainTextBox.Text + ((Button)sender).Text;

            else if (!MainTextBox.Text.Contains(",") && (MainTextBox.Text != "0" && sign == "" && tmpValue < 5000000
                        || MainTextBox.Text != "0" && sign == "-" && tmpValue > -3000000))
                MainTextBox.Text = MainTextBox.Text + ((Button)sender).Text;

            else if (MainTextBox.Text == "0")
                MainTextBox.Text = ((Button)sender).Text;
        }

        private void TwoDigitOperations(object sender, int op)
        {
            if (operation != 0 && MainTextBox.Text == "0")
            {
                operation = op;
                HistoryTextBox.Text = digits.ValueOfA.ToString() + " " + ((Button)sender).Text;
            }

            else if (operation != 0 && MainTextBox.Text != "0")
            {
                try
                {
                    digits.ValueOfB = Convert.ToDouble(MainTextBox.Text);
                    Calculation();
                    res = Math.Round(res, 1);
                    if (res.ToString().Length > 19) throw BigNumberException;
                    operation = op;
                    digits.ValueOfA = res;
                    res = 0;
                    HistoryTextBox.Text = digits.ValueOfA.ToString() + " " + ((Button)sender).Text;
                    MainTextBox.Text = digits.ValueOfA.ToString();
                }
                catch (Exception ex)
                {
                    DisableDigitAndOperation();
                    HistoryTextBox.Clear();
                    MainTextBox.Text = ex.Message;
                }
            }

            else
            {
                operation = op;
                digits.ValueOfA = Convert.ToDouble(MainTextBox.Text);
                HistoryTextBox.Text = MainTextBox.Text + " " + ((Button)sender).Text;
                MainTextBox.Text = "0";
            }
        }

        private void OneDigitOperations(object sender, int op)
        {
            try
            {
                if (operation != 0 && MainTextBox.Text != "0")
                {
                    digits.ValueOfB = Convert.ToDouble(MainTextBox.Text);
                    Calculation();
                    res = Math.Round(res, 1);
                    if (res.ToString().Length > 19) throw BigNumberException;

                    operation = op;
                    digits.ValueOfA = res;

                    if (operation == 7) HistoryTextBox.Text = ((Button)sender).Text.Substring(0, 2) + digits.ValueOfA.ToString();

                    else HistoryTextBox.Text = ((Button)sender).Text + digits.ValueOfA.ToString();

                    Calculation();
                    res = Math.Round(res, 1);
                    if (res.ToString().Length > 19) throw BigNumberException;
                    digits.ValueOfA = res;
                    res = 0;
                    operation = 0;
                    MainTextBox.Text = digits.ValueOfA.ToString();
                }

                else
                {
                    operation = op;
                    digits.ValueOfA = Convert.ToDouble(MainTextBox.Text);

                    if (operation == 7) HistoryTextBox.Text = ((Button)sender).Text.Substring(0, 2) + MainTextBox.Text;

                    else HistoryTextBox.Text = ((Button)sender).Text + MainTextBox.Text;

                    Calculation();
                    res = Math.Round(res, 1);
                    if (res.ToString().Length > 19) throw BigNumberException;
                    digits.ValueOfA = res;
                    res = 0;
                    operation = 0;
                    MainTextBox.Text = digits.ValueOfA.ToString();
                }
            }
            catch (Exception ex)
            {
                DisableDigitAndOperation();
                HistoryTextBox.Clear();
                MainTextBox.Text = ex.Message;
            }
        }

        private void Calculation()
        {
            switch (operation)
            {
                case 1:
                    res = MathOperations.Add(digits);
                    break;
                case 2:
                    res = MathOperations.Substract(digits);
                    break;
                case 3:
                    res = MathOperations.Multiply(digits);
                    break;
                case 4:
                    res = MathOperations.Divide(digits);
                    break;
                case 5:
                    res = MathOperations.SquareRoot(digits);
                    break;
                case 6:
                    res = MathOperations.Cos(digits);
                    break;
                case 7:
                    res = MathOperations.OneDividedBy(digits);
                    break;
                default:
                    throw NoOperationException;
            }
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            tmpValue = Double.Parse(MainTextBox.Text);
            if (sign == "" && tmpValue < 3000000) sign = "-";
            else sign = "";

            if (MainTextBox.Text[0] == '-') MainTextBox.Text = MainTextBox.Text.Remove(0, 1);
            else if (MainTextBox.Text != "0") MainTextBox.Text = sign + MainTextBox.Text;
        }

        private void ComaButton_Click(object sender, EventArgs e)
        {
            if (!MainTextBox.Text.Contains(',')) MainTextBox.Text = MainTextBox.Text + ',';
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TwoDigitOperations(sender, op: 1);
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            TwoDigitOperations(sender, op: 2);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            TwoDigitOperations(sender, op: 3);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            TwoDigitOperations(sender, op: 4);
        }
        
        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            OneDigitOperations(sender, op: 5);
        }
        
        private void CosButton_Click(object sender, EventArgs e)
        {
            OneDigitOperations(sender, op: 6);
        }

        private void OneDividedByButton_Click(object sender, EventArgs e)
        {
            OneDigitOperations(sender, op: 7);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (operation == 0)
                HistoryTextBox.Text = MainTextBox.Text + " " + EqualButton.Text;

            else if (res == 0)
            {
                digits.ValueOfB = Convert.ToDouble(MainTextBox.Text);
                try
                {
                    Calculation();
                    res = Math.Round(res, 1);
                    if (res.ToString().Length > 19) throw BigNumberException;
                    operation = 0;
                    HistoryTextBox.Text += " " + digits.ValueOfB.ToString() + " " + EqualButton.Text;
                    MainTextBox.Text = res.ToString();
                    res = 0;
                }
                catch (Exception ex)
                {
                    DisableDigitAndOperation();
                    HistoryTextBox.Clear();
                    MainTextBox.Text = ex.Message;
                }

            }
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            MainTextBox.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EnableDigitAndOperation();
            MainTextBox.Text = "0";
            HistoryTextBox.Text = "";
            digits.Clear();
            operation = 0;
            res = 0;
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (MainTextBox.TextLength > 0)
                if (MainTextBox.TextLength - 1 == 0)
                    MainTextBox.Text = "0";

                else if (MainTextBox.TextLength - 1 == 1 && MainTextBox.Text[0] == '-')
                    MainTextBox.Text = "0";

                else MainTextBox.Text = MainTextBox.Text.Substring(0, MainTextBox.TextLength - 1);
        }
    }
}