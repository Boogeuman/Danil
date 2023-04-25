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

namespace WpfApp1
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
            try
            {

                int number = int.Parse(polN.Text);
                switch (number)
                {
                    case 1:
                        otv.Content = ("Понедельник");
                        break;
                    case 2:
                        otv.Content = ("Вторник");
                        break;
                    case 3:
                        otv.Content = (" Среда");
                        break;
                    case 4:
                        otv.Content = (" Четверг");
                        break;
                    case 5:
                        otv.Content = ("Пятница");
                        break;
                    case 6:
                        otv.Content = ("Суббота");
                        break;
                    case 7:
                        otv.Content = (" Воскресенье");
                        break;
                    case 8:
                        otv.Content = ("Неверный день недели");
                        break;
                }

            }



            catch (FormatException)
            {
                MessageBox.Show("Введены некоректные данные");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


