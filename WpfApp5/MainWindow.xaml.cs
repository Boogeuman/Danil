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

namespace WpfApp5
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
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            double deposit = 1000;
            int p = Convert.ToInt32(polp.Text);
            int months = 0;

            while (deposit <= 1100)
            {
                deposit += deposit * (p % 100);
                months++;
            }

           otv.Content=($"Размер вклада превысит 1100 руб.через { months} месяцев.\n Итоговый размер вклада: { deposit} руб.");

        }
    }
    }  
     