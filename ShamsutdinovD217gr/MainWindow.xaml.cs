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
using static System.Math;

namespace ShamsutdinovD217gr
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
            int n = Convert.ToInt32(poln.Text);
            double p;

            double R, L, S, D;

            switch (n)
            {
                case 1:
                    p = 3.14;
                    R = Convert.ToInt32( numberCC.Text);
                    D = 2 * R;
                    L = 2 * p * R;
                    S = p * Math.Pow(R, 2);
                    otv.Content = " 2. = " + D + "\n 3. = " + L + "\n 4. = " + S;
                    break;

                case 2:
                    p = 3.14;
                    D = Convert.ToInt32(numberCC.Text);
                    R = D / 2;
                    L = 2 * p * R;
                    S = 2 * Math.Pow(R, 2);
                    otv.Content = " 1. = " + R + "\n 3. = " + L + "\n 4. = " + S;
                    break;

                case 3:
                    p = 3.14;
                    L = Convert.ToInt32(numberCC.Text);
                    R = L / 2 / p;
                    D = 2 * R;
                    S = 2 * Math.Pow(R, 2);
                    otv.Content = " 1. = " + R + "\n 2. = " + D + "\n 4. = " + S;
                    break;

                case 4:
                    p = 3.14;
                    S = Convert.ToInt32(numberCC.Text);
                    R = Math.Sqrt(S) / 2;
                    D = 2 * R;
                    L = 2 * p * R;
                    otv.Content = " 1. = " + R + "\n 2. = " + D + "\n 3. = " + L;
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





