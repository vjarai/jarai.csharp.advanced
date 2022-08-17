using System;
using System.Linq;
using System.Windows.Forms;

namespace Jarai.Async.Winforms
{
    public partial class Form1 : Form
    {
        private readonly CalculationService _calculationService = new CalculationService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (new BusyIndicator(this))
            {
                label1.Text = "Calculating...";
                var result = _calculationService.Calculate(Enumerable.Range(1, 1000));

                label1.Text = result.Value.ToString();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (new BusyIndicator(this))
            {
                label1.Text = "Calculating...";
                var result = await _calculationService.CalculateAsync(Enumerable.Range(1, 1000));

                label1.Text = result.Value.ToString();
            }
        }
    }
}