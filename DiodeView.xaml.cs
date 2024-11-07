using ReferenceChecker;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace ReferenceChecker
{
    public partial class DiodeView : UserControl
    {
        public DiodeView()
        {
            InitializeComponent();

            var xPositive = new double[] { -0.56, -0.76, -1, -2, -3, -4, -5, -6, -6.95, -6.96, -6.97, -6.98, -6.99, -7, 0.5, 0.75, 1, 1.5, 2, 3, 4, 5, 6 };
            var yPositive = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, -0.44, -0.95, -1.81, -3, -3.96, -5, 0, 0, 0.278, 0.646, 1.16, 2.17, 3.24, 4.14, 5.24 };
            var xNegative = new double[] { -0.56, -0.76, -1, -2, -3, -4, -5, -6, -6.95, -6.96, -6.97, -6.98, -6.99, -7 };
            var yNegative = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, -0.44, -0.95, -1.81, -3, -3.96, -5 };

            DiodeChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Polarización Directa",
                    Values = new ChartValues<double>(yPositive),
                    PointGeometry = DefaultGeometries.Circle,
                    Stroke = System.Windows.Media.Brushes.Blue
                },
                new LineSeries
                {
                    Title = "Polarización Inversa",
                    Values = new ChartValues<double>(yNegative),
                    PointGeometry = DefaultGeometries.Cross,
                    Stroke = System.Windows.Media.Brushes.Red
                }
            };
        }

        public void SetTitle(string title)
        {
            TitleTextBlock.Text = title;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Window.GetWindow(this)).ShowMainView();
        }
    }
}
