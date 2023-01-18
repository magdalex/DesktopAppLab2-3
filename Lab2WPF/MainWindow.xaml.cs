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

namespace Lab2WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testButton_Checked(object sender, RoutedEventArgs e)
        {
            testScores objTestScores = new testScores();
            this.Visibility = Visibility.Hidden;
            objTestScores.Show();
        }

        private void bankButton_Checked(object sender, RoutedEventArgs e)
        {
            bankCharges objBankCharges = new bankCharges();
            this.Visibility = Visibility.Hidden;
            objBankCharges.Show();
        }

        private void shippingButton_Checked(object sender, RoutedEventArgs e)
        {
            shippingCharges objShippingCharges = new shippingCharges();
            this.Visibility = Visibility.Hidden;
            objShippingCharges.Show();
        }

        private void distanceButton_Checked(object sender, RoutedEventArgs e)
        {
            distanceTraveled objDistanceTraveled = new distanceTraveled();
            this.Visibility = Visibility.Hidden;
            objDistanceTraveled.Show();
        }
    }
}
