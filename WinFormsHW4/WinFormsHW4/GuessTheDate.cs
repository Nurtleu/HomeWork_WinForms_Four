using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW4
{
    public partial class GuessTheDate : Form
    {
        public GuessTheDate()
        {
            InitializeComponent();            
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Date_textBox.Clear();
            Year_textBox.Clear();
            Month_textBox.Clear();
            Day_textBox.Clear();
            Minute_textBox.Clear();
            Time_textBox.Clear();
        }

        private void Year_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Year_radioButton.Checked)
            {
                int year = Int32.Parse(Date_textBox.Text);
                int dateTimeYear = DateTime.Now.Year;
                year -= dateTimeYear;
                Year_textBox.Text = year.ToString();
            }Year_radioButton.Checked = false;
        }

        private void Month_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Month_radioButton.Checked)
            {
                int month = Int32.Parse(Date_textBox.Text);
                int dataTimeMonth = DateTime.Now.Month;
                month -= dataTimeMonth;
                Month_textBox.Text = month.ToString();
            }Month_radioButton.Checked = false;
        }

        private void Day_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Day_radioButton.Checked)
            {
                int day = Int32.Parse(Day_textBox.Text);
                int dataTimeDay = DateTime.Now.Day;
                day -= dataTimeDay;
                Day_textBox.Text = day.ToString();
            }Day_radioButton.Checked = false;
        }

        private void Minutes_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Minute_radioButton.Checked)
            {
                int minute = Int32.Parse(Time_textBox.Text);
                int dataTimeMinute = DateTime.Now.Minute;
                minute -= dataTimeMinute;
                Minute_textBox.Text = minute.ToString();
            }Minute_radioButton.Checked = false;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog Savefile = new SaveFileDialog();
            Savefile.ShowDialog();
        }

        private void Second_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Second_radioButton.Checked)
            {
                int second = Int32.Parse(Time_textBox.Text);
                int dataTimeSecond = DateTime.Now.Second;
                second -= dataTimeSecond;
                Minute_textBox.Text = second.ToString();
            }Second_radioButton.Checked = false;
        }
    }
}
