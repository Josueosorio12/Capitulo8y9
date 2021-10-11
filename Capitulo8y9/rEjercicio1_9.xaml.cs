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
    /// Interaction logic for rEjercicio1_9.xaml
    /// </summary>
    public partial class rEjercicio1_9 : Window
    {
        public int cantidad=0;
        public rEjercicio1_9()
        {
            InitializeComponent();
        }

        public struct Productos
        {
            
            public string Nombre;
            public float Precio;
            public int Id;
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Id: {Id}, Nombre: {Nombre}, Precio: {Precio}");
                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            cantidad = Convert.ToInt32(CantidadTextBox.Text);
            Productos[] productos = new Productos[cantidad];

            for (int x = 0; x < cantidad; x++)
            {
                productos[x].Id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Id del Producto: {x + 1}", " Id del Producto ", " ", 75, 0));
                productos[x].Nombre = Microsoft.VisualBasic.Interaction.InputBox($"Nombre del Producto : {x + 1}", "Nombre del Producto ", " ", 75, 0);
                productos[x].Precio = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Precio del Producto: {x + 1}", " Precio del Producto ", " ", 75, 0));

            }

            for (int y = 0; y < cantidad; y++)
            {

                Mostrar.Items.Add(productos[y].ToString());
            }
        }
    }
}
       