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
    /// Interaction logic for rEjercicio5.xaml
    /// </summary>
    public partial class rEjercicio5 : Window
    {
        public rEjercicio5()
        {
            InitializeComponent();
        }

        private void Alfabetico_Click(object sender, RoutedEventArgs e)
        {
            string cadena1 = "";
            string cadena2 = "";
            cadena1 = Cadena1.Text;
            cadena2 = Cadena2.Text;

            string ordenado1 = new string(cadena1.OrderBy(x => x).ToArray());
            string ordenado2 = new string(cadena2.OrderBy(x => x).ToArray());

            MessageBox.Show($" {cadena1} orden alfabetico es:" +
                $" {ordenado1}\n {cadena2} orden alfabetico es: {ordenado2}",
                "Ordenar", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
