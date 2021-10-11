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
    /// Interaction logic for Ejercicio3y5.xaml
    /// </summary>
    public partial class Ejercicio3y5 : Window
    {
        public Ejercicio3y5()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCapitulo8 capitulo8 = new rCapitulo8();
            capitulo8.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            rEjercicio5 ejercicio5 = new rEjercicio5();
            ejercicio5.Show();
        }
    }
}
