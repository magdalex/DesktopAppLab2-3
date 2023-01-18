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

namespace BankChargesWPF
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
            double balance = Convert.ToDouble(currentBalanceBox.Text);
            int cheques = Convert.ToInt32(amountChequesBox.Text);
            double serviceFees;
            serviceFees = calculateServiceFees(balance, cheques);
            double endingBalance = balance - serviceFees;
            serviceFeesBox.Text = serviceFees.ToString();
            chequesBox2.Text = cheques.ToString();
            endBalanceBox.Text = endingBalance.ToString();
        }

        private double calculateServiceFees(double balance, int numberCheques)
        {
            double serviceFees = 0;
            serviceFees += 10;


            if (balance < 400)
                serviceFees += 15;

            if (numberCheques < 20)
            {
                serviceFees += (.10 * numberCheques);
            }
            else if (numberCheques >= 20 && numberCheques <= 39)
            {
                serviceFees += (.08 * numberCheques);
            }
            else if (numberCheques >= 40 && numberCheques <= 59)
            {
                serviceFees += (.06 * numberCheques);
            }
            else if (numberCheques >= 60)
            {
                serviceFees += (.04 * numberCheques);
            }
            return serviceFees;
        }
    }
}
