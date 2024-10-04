using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate.Windows
{
    public partial class GridWindow : Window
    {
        //Variabel för att lagra senast trycka knapp
        private Button lastButton;
        public GridWindow()
        {
            InitializeComponent();

        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            
            //Hämta rad och column från inmatning
            int row = Convert.ToInt32(txtBlockRow.Text);
            int column = Convert.ToInt32(txtBlockColumn.Text);

            //Kontroll för att användaren angivit giltig rad/column
            if (row >= 0 && row <=3 && column >= 0 && column <=3)
            {
                //Tar bort tidigare knapp
                if (lastButton != null)
                {
                    Grid1.Children.Remove(lastButton);
                }

                //Skapar ny knapp
                Button newButton = new Button
                    {
                        Content = $"Row: {row}, Column: {column}",
                        Background = new SolidColorBrush(Colors.LightGreen)
                    };

                //Placera knappen korrekt i griden
                Grid.SetRow(newButton, row);
                Grid.SetColumn(newButton, column);

                //Lägger till knappen i Grid1
                Grid1.Children.Add(newButton);

                //Spara aktuell knapp så den gamla tas bort vid nästa tryck
                lastButton = newButton;

            }
            else
            {
                MessageBox.Show("Please enter 0-3 for both row and column", "Incorrect", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
