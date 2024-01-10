using System.Reflection;

namespace Jarai.CSharp.Async.Winforms
{
    public partial class Form1 : Form
    {
        private readonly CalculationService _calculationService = new();

        private CancellationTokenSource _cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();

            _calculationService.ProgressChanged += (sender, args) =>
            {
                progressBar1.Value = args.ProgressPercentage;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (new BusyIndicator(this))
            {
                label1.Text = "Calculating...";
                _cancellationTokenSource = new CancellationTokenSource();

                var result = _calculationService.Calculate(Enumerable.Range(1, 100), _cancellationTokenSource.Token);

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
                    var result =
                        await _calculationService.CalculateAsync(Enumerable.Range(1, 100),
                            _cancellationTokenSource.Token);
                    label1.Text = result.Value.ToString();
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }
                finally
                {
                    progressBar1.Value = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}