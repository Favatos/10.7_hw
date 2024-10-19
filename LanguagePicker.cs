using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._7_hm
{
    public partial class LanguagePicker : Form
    {
        string _language;
        public LanguagePicker()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) _language = "en-EN";
            else _language = "ru-RU";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_language == null) return;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(_language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_language);
            Form1 form = new Form1();
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
