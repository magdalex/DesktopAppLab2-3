using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace TestScoresWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a1 = Convert.ToDouble(grade1.Text);
            double a2 = Convert.ToDouble(grade2.Text);
            double a3 = Convert.ToDouble(grade3.Text);
            double total = a1 + a2 + a3;
            double averageDouble = (total / 3);
            string letterString = gradeToLetter(averageDouble);
            average.Text = averageDouble.ToString();
            letter.Text = letterString;
        }

        private string gradeToLetter(double average)
        {
            if (average >= 90 && average <= 100)
            {
                return "A";
            }
            else if (average >= 80 && average <= 89)
            {
                return "B";
            }
            else if (average >= 70 && average <= 79)
            {
                return "C";
            }
            else if (average >= 60 && average <= 69)
            {
                return "D";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
