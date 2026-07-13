using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_30___Simple_Calculator_Form__
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        Nullable<Double> Operand1 = null, Operand2 = null;

        Nullable<char> Operator = null;

        enum enCurrentOperand { Operand1, Operand2, Result }

        enCurrentOperand CurrentOperand = enCurrentOperand.Operand1;

        private void ClearValues()
        {
            Operand1 = null;
            Operand2 = null;
            Operator = null;

            CurrentOperand = enCurrentOperand.Operand1;
        }

        private void Clear()
        {
            txtScreen.Clear();

            ClearValues();
        }

        private bool IsLastIndexEqualOperator()
        {
            char LastCharacter = txtScreen.Text[txtScreen.TextLength - 1];

            return (LastCharacter == '+' || LastCharacter == '-' || LastCharacter == '×' || LastCharacter == '÷');
        }

        private void DeleteOperator()
        {
            Operator = null;
            CurrentOperand = enCurrentOperand.Operand1;

            DeleteLastCharacterInScreen();
        }

        private bool IsLastIndexEqualPercentage()
        {
            return (txtScreen.Text[txtScreen.TextLength - 1] == '%');
        }

        private void DeletePercentageFromOperand1()
        {
            Operand1 *= 100;
        }

        private void DeletePercentageFromOperand2()
        {
            Operand2 *= 100;
        }

        private void DeletePercentage()
        {
            if (IsOperand1EqualCurrent())
            {
                DeletePercentageFromOperand1();
            }
            else
            {
                DeletePercentageFromOperand2();
            }

            DeleteLastCharacterInScreen();
        }

        private bool IsOperand2EqualCurrent()
        {
            return (CurrentOperand == enCurrentOperand.Operand2);
        }

        private bool IsOperand1EqualCurrent()
        {
            return (CurrentOperand == enCurrentOperand.Operand1);
        }

        private bool IsLastIndexEqualPoint()
        {
            return (txtScreen.Text[txtScreen.TextLength - 1] == '.');
        }

        private void DeleteLastCharacterInScreen()
        {
            txtScreen.Text = txtScreen.Text.Remove(txtScreen.TextLength - 1);
        }

        private void DeleteLastDigitFromOperand2()
        {
            DeleteLastCharacterInScreen();

            string SecondOperand = Operand2.ToString();

            if (SecondOperand.Length==1)
            {
                Operand2 = null;
            }
            else if (SecondOperand[SecondOperand.Length - 2] == '.')
            {
                Operand2 = Convert.ToDouble(SecondOperand.Remove(SecondOperand.Length - 2));
            }
            else
            {
                Operand2 = Convert.ToDouble(SecondOperand.Remove(SecondOperand.Length - 1));
            }
        }

        private bool IsEmptyScreen()
        {
            return (string.IsNullOrEmpty(txtScreen.Text));
        }

        private void DeleteLastDigitFromOperand1()
        {
            DeleteLastCharacterInScreen();

            if (IsEmptyScreen())
            {
                Clear();
                return;
            }

            if (txtScreen.Text[txtScreen.TextLength - 1] == '.')
            {
                Operand1 = Convert.ToDouble(txtScreen.Text.Remove(txtScreen.TextLength-1));
            }
            else
            {
                Operand1 = Convert.ToDouble(txtScreen.Text);
            }
        }

        private bool IsResultEqualCurrent()
        {
            return CurrentOperand == enCurrentOperand.Result;
        }

        private void DeleteResult()
        {
            while (txtScreen.Text[txtScreen.TextLength - 1] != '=')
            {
                DeleteLastCharacterInScreen();
            }

            DeleteLastCharacterInScreen();

            CurrentOperand = enCurrentOperand.Operand2;
        }

        private void Delete()
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                if (IsResultEqualCurrent())
                {
                    DeleteResult();
                }
                else if (IsLastIndexEqualOperator())
                {
                    DeleteOperator();
                }
                else if (IsLastIndexEqualPercentage())
                {
                    DeletePercentage();
                }
                else if (IsLastIndexEqualPoint())
                {
                    DeleteLastCharacterInScreen();
                }
                else if (IsOperand2EqualCurrent())
                {
                    DeleteLastDigitFromOperand2();
                }
                else
                {
                    DeleteLastDigitFromOperand1();
                }
            }
        }

        private void AddPercentageToOperand2()
        {
            Operand2 /= 100;
        }

        private void AddPercentageToOperand1()
        {
            Operand1 /= 100;
        }

        private void AddPercentageToScreen()
        {
            txtScreen.Text += '%';
        }

        private void AddPercentage()
        {
            if (IsOperand2EqualCurrent())
            {
                AddPercentageToOperand2();
            }
            else
            {
                AddPercentageToOperand1();
            }

            AddPercentageToScreen();
        }

        private void AddDigitToOperand2()
        {
            string[] Operands = txtScreen.Text.Split(Convert.ToChar(Operator));

            Operand2 = Convert.ToDouble(Operands[1]);
        }

        private void AddDigitToOperand1()
        {
            Operand1 = Convert.ToDouble(txtScreen.Text);
        }

        private void AddDigit(Button btn)
        {
            AddCharacterToScreen(btn.Tag.ToString());

            if (IsOperand2EqualCurrent())
            {
                AddDigitToOperand2();
            }
            else
            {
                AddDigitToOperand1();
            }
        }

        private void AddCharacterToScreen(string Tag)
        {
            txtScreen.Text += Tag;
        }

        private void AddOperator(Button btn)
        {
            AddCharacterToScreen(btn.Tag.ToString());

            Operator = Convert.ToChar(btn.Tag);

            CurrentOperand = enCurrentOperand.Operand2;
        }

        private double CalculateResult()
        {
            switch (Operator)
            {
                case '+':
                    return Convert.ToDouble(Operand1 + Operand2);

                case '-':
                    return Convert.ToDouble(Operand1 - Operand2);

                case '×':
                    return Convert.ToDouble(Operand1 * Operand2);

                case '÷':
                    return Convert.ToDouble(Operand1 / Operand2);
            }

            return Convert.ToDouble(Operand1);
        }

        private bool IsDividingByZero()
        {
            return (Operator == '÷' && Operand2 == 0);
        }

        private void ShowMathErrorMessage()
        {
            txtScreen.Text = "Math Error!";

            txtScreen.Text += Environment.NewLine + "Press C To Clear";
        }

        private void ShowResult()
        {
            if (IsDividingByZero())
            {
                ShowMathErrorMessage();
                return;
            }

            CurrentOperand = enCurrentOperand.Result;

            txtScreen.Text += '=' + Environment.NewLine;

            txtScreen.Text += CalculateResult().ToString();
        }

        private void AddFractionPoint()
        {
            txtScreen.Text += '.';
        }

        private void ChangeToLightTheme()
        {
            this.BackColor = Color.White;
            txtScreen.BackColor = Color.White;
            txtScreen.ForeColor = Color.Black;
        }

        private void ChangeToDarkTheme()
        {
            this.BackColor = Color.Black;
            txtScreen.BackColor = Color.Black;
            txtScreen.ForeColor = Color.White;
        }

        private void ChangeTheme()
        {
            if (this.BackColor == Color.Black)
            {
                ChangeToLightTheme();
            }
            else
            {
                ChangeToDarkTheme();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Clear":
                    Clear();
                    break;

                case "Delete":
                    Delete();
                    break;

                case "%":
                    AddPercentage();
                    break;

                case "=":
                    ShowResult();
                    break;

                case ".":
                    AddFractionPoint();
                    break;

                case "ChangeTheme":
                    ChangeTheme();
                    break;

                default:
                    break;
            }
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            AddDigit((Button)sender);
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            AddOperator((Button)sender);
        }
    }
}
