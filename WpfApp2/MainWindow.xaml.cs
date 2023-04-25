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

namespace WpfApp2
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

                    int N = int.Parse(polN.Text);
                    switch (N)
                    {
                        case 6:
                            otv.Content = ("шестерка");
                            break;
                        case 7:
                            otv.Content = ("семерка");
                            break;
                        case 8:
                            otv.Content = ("восьмерка");
                            break;
                        case 9:
                            otv.Content = ("девятка");
                            break;
                        case 10:
                            otv.Content = ("десятка");
                            break;
                        case 11:
                            otv.Content = ("валет");
                            break;
                        case 12:
                            otv.Content = ("дама");
                            break;
                        case 13:
                            otv.Content = ("король");
                            break;
                        case 14:
                            otv.Content = ("туз");
                            break;
                        default:
                            otv.Content = ("Ошибка значения достоинства карты");
                            break;
                            otv.Content = $"Ответ: N={N}   ";
                    }


                    double M = double.Parse(polM.Text);
                    switch (M)
                    {
                        case 1:
                            otv.Content = ("пик");
                            break;
                        case 2:
                            otv.Content = ("треф");
                            break;
                        case 3:
                            otv.Content = ("бубен");
                            break;
                        case 4:
                            otv.Content = ("червей");
                            break;
                        default:
                            otv.Content = ("Ошибка значения масти карты");
                            break;
                            otv.Content = $"Ответ:  M={M} ";
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

