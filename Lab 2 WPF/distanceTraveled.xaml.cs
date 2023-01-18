using System;
using System.Collections;
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

namespace Lab2WPF
{
    /// <summary>
    /// Interaction logic for distanceTraveled.xaml
    /// </summary>
    public partial class distanceTraveled : Window
    {
        public string[] operations { get; set; }
        public distanceTraveled()
        {
            InitializeComponent();
            operations = new string[] { };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speed = Convert.ToDouble(speedBox.Text);
            int hours = Convert.ToInt32(hoursBox.Text);

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= hours; i++)
                sb.AppendLine(string.Format(i + "         ||     " + calculateDistance(speed, i)));
            outputBox.Text = "Hour   ||     Distance Traveled\n" + sb.ToString();
        }

        private double calculateDistance(double speed, double hours)
        {
            double distance;
            distance = speed * hours;
            return distance;
        }
    }
}
