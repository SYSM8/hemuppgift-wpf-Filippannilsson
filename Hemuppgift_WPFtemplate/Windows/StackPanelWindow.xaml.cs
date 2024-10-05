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
    
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        private void radioBtnHorizont_Click(object sender, RoutedEventArgs e)
        {
            //Ändrar orientation för rektanglar till horizontal
            rectStack.Orientation = Orientation.Horizontal;
        }

        private void radioBtnVertical_Click(object sender, RoutedEventArgs e)
        {
            //Ändrar orientation för rektanglar till vertical
            rectStack.Orientation = Orientation.Vertical;
        }
    }
}
