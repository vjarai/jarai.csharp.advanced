using System;
using System.Windows.Forms;
using Jarai.CSharp.Globalization.WinForms.Properties;

namespace Jarai.CSharp.Globalization.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Form1_button1_Click_Hallo);
        }
    }
}