using Hemuppgift_WPFtemplate.Windows;
using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}