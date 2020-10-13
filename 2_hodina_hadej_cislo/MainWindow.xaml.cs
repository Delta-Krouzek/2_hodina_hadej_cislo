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

namespace _2_hodina_hadej_cislo
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd;
        int hadaneCislo;

        public MainWindow()
        {
            InitializeComponent();

            rnd = new Random();
            hadaneCislo = rnd.Next(11);
        }

        private void buttonOdeslat_Click(object sender, RoutedEventArgs e)
        {
            int zadalCislo = Convert.ToInt32(textBoxMyslim.Text);
            if (zadalCislo > hadaneCislo)
            {
                labelNadpis.Content = "Číslo je menší";
            }
            else if (zadalCislo < hadaneCislo)
            {
                labelNadpis.Content = "Číslo je větší";
            }
            else
            {
                labelNadpis.Content = "Uhádnul jsi to!";
            }
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            hadaneCislo = rnd.Next(11);
        }
    }
}
