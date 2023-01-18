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

namespace ShippingChargesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] operations { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            operations = new string[] { };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = Convert.ToDouble(weightBox.Text);
            double shippingCharges = calculateShippingCharges(weight);
            chargeBox.Text = shippingCharges.ToString();
        }

        private double calculateShippingCharges(double weight)
        {
            double shippingCharges = 0.0;
            if (weight <= 2)
            {
                shippingCharges = 1.10;
            }
            else if (weight > 2 && weight <= 6)
            {
                shippingCharges = 2.20;
            }
            else if (weight > 6 && weight <= 10)
            {
                shippingCharges = 3.70;
            }
            else if (weight > 10)
            {
                shippingCharges = 4.80;
            }
            return shippingCharges;
        }
    }
}
