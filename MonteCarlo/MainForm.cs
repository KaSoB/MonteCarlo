using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo {
    public partial class MainForm : Form {
        MonteCarloAlgorithm Algorithm = new MonteCarloAlgorithm();
        Display Display;
        Task Task;
        public MainForm() {
            InitializeComponent();
            Display = new Display(MainPanel);
        }
        private void ApplyButton_Click(object sender, EventArgs e) {
            if (Task != null && !Task.IsCompleted) {
                MessageBox.Show("Program is already working.");
                return;
            }
            long dotsCount = GetDotsCount();
            // Set scale for display
            Display.AdjustBoard(dotsCount);
            Clear();
            // Set the stopwatch and execute test
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ExecuteTestAsync(dotsCount);
            sw.Stop();
            // Save results into textboxes
            NumberOfPointsTextBox.Text = Algorithm.TotalPoints.ToString();
            NumberOfPointsInCircleTextBox.Text = Algorithm.NumPointsInCircle.ToString();
            ExecutionTimeTextBox.Text = sw.Elapsed.ToString("mm':'ss'.'ffffff");
            MeasurementErrorTextBox.Text = Math.Round(Math.Abs((Math.PI - Algorithm.EstimatedPI)), 12).ToString();
            EstimatedPIValueTextBox.Text = Algorithm.EstimatedPI.ToString();


            NumberOfPointsToExecuteTextBox.Text = string.Empty;
        }
        private void ExecuteTestAsync(long dotsCount) {
            Task = new Task(() => Algorithm.Execute(dotsCount, Display));
            Task.Start();
            Task.Wait();
        }
        private long GetDotsCount() {
            try {
                return long.Parse(NumberOfPointsToExecuteTextBox.Text);
            } catch {
                MessageBox.Show("An error occurred while parsing value from TextBox.");
                return 0;
            }
        }
        private void Clear() {
            // Clear the display
            Display.Clear();

            // Clear results
            Algorithm.Clear();

            // Clear all textboxes from the Form
            NumberOfPointsTextBox.Text = string.Empty;
            NumberOfPointsInCircleTextBox.Text = string.Empty;
            ExecutionTimeTextBox.Text = string.Empty;
            MeasurementErrorTextBox.Text = string.Empty;
            EstimatedPIValueTextBox.Text = string.Empty;
        }
        private void NumberOfPointsToExecuteTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            // Accept only digit characters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

}
