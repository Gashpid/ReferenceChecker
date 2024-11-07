using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReferenceChecker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComponentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (componentComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedText = selectedItem.Content.ToString();

                // Oculta la vista principal cuando cambia a una vista de componente
                MainView.Visibility = Visibility.Collapsed;

                switch (selectedText)
                {
                    case "MOSFET N CHANNEL":
                    case "MOSFET P CHANNEL":
                        MosfetView.Visibility = Visibility.Visible;
                        MosfetView.SetTitle(selectedText);
                        break;

                    case "RECTIFIER DIODE":
                    case "LED DIODE":
                    case "ZENER DIODE":
                        DiodeView.Visibility = Visibility.Visible;
                        DiodeView.SetTitle(selectedText);
                        break;
                }
            }
        }

        public void ShowMainView()
        {
            // Muestra la vista principal y oculta las vistas de componentes
            MainView.Visibility = Visibility.Visible;
            MosfetView.Visibility = Visibility.Collapsed;
            DiodeView.Visibility = Visibility.Collapsed;
        }
    }
}