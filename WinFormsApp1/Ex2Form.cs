using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Ex2Form : Form
    {
        double number1;
        double number2;
        double result;
        string operation = "";
        public Ex2Form()
        {
            InitializeComponent();
            AddRadioButton.Checked = true;
            operation = "+";
        }

        private void Ex2Form_Load(object sender, EventArgs e)
        {

        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void SubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void MultiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void DivineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(FirstNumberTextBox.Text);
            number2 = Convert.ToDouble(SecondNumberTextBox.Text);
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    CalculateLabel.Text = "Результат: " + result.ToString();
                    break;
                case "-":
                    result = number1 - number2;
                    CalculateLabel.Text = "Результат: " + result.ToString(); ;
                    break;
                case "*":
                    result = number2 * number1;
                    CalculateLabel.Text = "Результат: " + result.ToString();
                    break;
                case "/":
                    result = number1 / number2;
                    CalculateLabel.Text = "Результат: " + result.ToString();
                    break;

            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            CalculateLabel.Text = "Результат: ";
        }
    }
}
