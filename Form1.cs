using System.Resources;
using System.Text.RegularExpressions;

namespace _10._7_hm
{
    public partial class Form1 : Form
    {
        TimeSpan ts;
        ResourceManager resource = new ResourceManager(typeof(Form1)); 
        bool areValid;
        public Form1()
        {
            InitializeComponent();
            ts = dateTimePickerEnd.Value - dateTimePickerStart.Value;
            areValid = ts.TotalDays + 1 > 0;
        }

        public void Update(bool check)
        {
            ts = dateTimePickerEnd.Value - dateTimePickerStart.Value;
            if (check)
                label4.Text = string.Format(resource.GetString("costString")!, ((int)ts.TotalDays + 1) * int.Parse(textBox1.Text));
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            if (ts.TotalDays + 1 < 0)
            {
                textBox1.Enabled = areValid;
                errorProvider1.SetError(dateTimePickerStart, resource.GetString("errorDateStart"));
            }
            ValidateDate();
            //ValidateText();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            ValidateDate();
            if (!(ts.TotalDays + 1 > 0))
            {
                textBox1.Enabled = areValid;
                errorProvider1.SetError(dateTimePickerEnd, resource.GetString("errorDateEnd"));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }



        public void ValidateDate()
        {
            if (dateTimePickerEnd.Value < DateTime.Today || dateTimePickerStart.Value < DateTime.Today)
            {
                textBox1.Enabled = false;
                errorProvider1.SetError(dateTimePickerEnd, resource.GetString("errorDatePast"));
            }
            else
            {
                errorProvider1.Clear();
                textBox1.Enabled = true;
            }
        }
        public void ValidateText()
        {
            label4.Text = resource.GetString("cost");
            if (new Regex("[0-9]").IsMatch(textBox1.Text) == false)
            {
                errorProvider1.SetError(textBox1, resource.GetString("errorNotDigit"));
            }
            else if (int.Parse(textBox1.Text) <= 0)
            {
                errorProvider1.SetError(textBox1, resource.GetString("errorPrice"));
            }
            else
            {
                errorProvider1.Clear();
                Update(true);
            }
            Update(false);
        }

        private void dateTimePickerEnd_Leave(object sender, EventArgs e)
        {
            ValidateText();
        }
    }
}
