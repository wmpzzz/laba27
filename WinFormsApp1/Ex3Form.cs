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
    public partial class Ex3Form : Form
    {
        public Ex3Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            if(DepatureCityTextBox.Text != "" && ArrivalCityTextBox.Text != "" && ArrivalDateTimePicker2.Value > DepatureDateTimePicker.Value)
            {
                if (NeedReturnTicketCheckBox.Checked)
                {
                    text = "Билет: " + DepatureDateTimePicker.Value.Day + "." + DepatureDateTimePicker.Value.Month + "." + DepatureDateTimePicker.Value.Year + " " + DepatureCityTextBox.Text + " - " + ArrivalCityTextBox.Text + "\r\n Обратный билет: " + ArrivalDateTimePicker2.Value.Day + "." + ArrivalDateTimePicker2.Value.Month + "." + ArrivalDateTimePicker2.Value.Year + " " + ArrivalCityTextBox.Text + " - " + DepatureCityTextBox.Text;
                }
                else
                {
                    text = "Билет: " + DepatureDateTimePicker.Value.Day + "." + DepatureDateTimePicker.Value.Month + "." + DepatureDateTimePicker.Value.Year + " " + DepatureCityTextBox.Text + " - " + ArrivalCityTextBox.Text;
                }
                MessageBox.Show(text, "Message");
            }
            else
            {
                MessageBox.Show("Не корректные данные", "Error");
            }
        }
    }
}
