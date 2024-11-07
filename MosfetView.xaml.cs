using ReferenceChecker;
using System.Windows;
using System.Windows.Controls;

namespace ReferenceChecker
{
    public partial class MosfetView : UserControl
    {
        public MosfetView()
        {
            InitializeComponent();
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
