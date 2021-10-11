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

namespace Capitulo8y9
{
    /// <summary>
    /// Interaction logic for Ejercicio1_3_4.xaml
    /// </summary>
    public partial class Ejercicio1_3_4 : Window
    {
        public Ejercicio1_3_4()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio4_9 ejercicio4 = new rEjercicio4_9();
            ejercicio4.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            rEjercicio3_9 ejercicio3 = new rEjercicio3_9();
            ejercicio3.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            rEjercicio1_9 ejercicio1_9 = new rEjercicio1_9();
            ejercicio1_9.Show();
        }
    }
}
