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
using System.Windows.Shapes;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for ZatvaranjeAplikacije.xaml
    /// </summary>
    public partial class ZatvaranjeAplikacije : Window
    {
        public ZatvaranjeAplikacije(string naslov)
        {
            InitializeComponent();
            formaPotvrde.Title = naslov;
            

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Odustajanje_Click(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                Potvrda_Click(sender, e);
            }
        }

        private void Potvrda_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Application.Current.Shutdown();
        }

        private void Odustajanje_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }


    }
}
