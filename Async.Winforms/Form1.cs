using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Jarai.CSharp.Async.Winforms
{
    public partial class Form1 : Form
    {
        private readonly CalculationService _calculationService = new CalculationService();

        CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (new BusyIndicator(this))
            {
                label1.Text = "Calculating...";
                _cancellationTokenSource = new CancellationTokenSource();

                var result = _calculationService.Calculate(Enumerable.Range(1, 1000), _cancellationTokenSource.Token);

                label1.Text = result.Value.ToString();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (new BusyIndicator(this))
            {
                label1.Text = "Calculating...";
                _cancellationTokenSource = new CancellationTokenSource();

                try
                {
                    var result = await _calculationService.CalculateAsync(Enumerable.Range(1, 1000), _cancellationTokenSource.Token);
                    label1.Text = result.Value.ToString();
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}