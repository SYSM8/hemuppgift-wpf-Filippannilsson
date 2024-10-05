using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate.Windows
{
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void radioBtnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            //Ändrar orientation för ellipser till horizontal
            ellipseWrap.Orientation = Orientation.Horizontal;
        }

        private void radioBtnVertical_Click(object sender, RoutedEventArgs e)
        {
            //Ändrar orientation för ellipser till vertical
            ellipseWrap.Orientation = Orientation.Vertical;
        }
    }
}
