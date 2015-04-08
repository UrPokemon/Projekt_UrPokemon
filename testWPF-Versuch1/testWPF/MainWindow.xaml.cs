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
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Windows.MouseEventArgs;

namespace testWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        

        private void A3_Click_1(object sender, RoutedEventArgs e)
        {
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke a 3";
            weitera.Visibility = Visibility.Visible;
        }

        private void weitera_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
            TextBlock1.Text = "";
            weitera.Visibility = Visibility.Hidden;
        }

        private void A1_Click_1(object sender, RoutedEventArgs e)
        {
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke a 1";
            weitera.Visibility = Visibility.Visible;
        }

        private void A2_Click_1(object sender, RoutedEventArgs e)
        {
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke a 2";
            weitera.Visibility = Visibility.Visible;
        }

        private void A4_Click_1(object sender, RoutedEventArgs e)
        {
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke a 4";
            weitera.Visibility = Visibility.Visible;
        }

        private void b1_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Hidden;
            b4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke b 1";
            weiterb.Visibility = Visibility.Visible;
        }

        private void b2_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Hidden;
            b4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke b 2";
            weiterb.Visibility = Visibility.Visible;
        }

        private void b3_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Hidden;
            b4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke b 3";
            weiterb.Visibility = Visibility.Visible;
        }

        private void b4_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Hidden;
            b4.Visibility = Visibility.Hidden;
            TextBlock1.Text = "ein Text attacke b 4";
            weiterb.Visibility = Visibility.Visible;
        }

        private void weiterb_Click_1(object sender, RoutedEventArgs e)
        {
            A1.Visibility = Visibility.Visible;
            A2.Visibility = Visibility.Visible;
            A3.Visibility = Visibility.Visible;
            A4.Visibility = Visibility.Visible;
            TextBlock1.Text = "";
            weiterb.Visibility = Visibility.Hidden;
        }

       

    }
}
