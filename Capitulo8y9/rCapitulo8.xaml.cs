using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Capitulo8y9
{
    /// <summary>
    /// Interaction logic for rCapitulo8.xaml
    /// </summary>
    public partial class rCapitulo8 : Window
    {
      
        public rCapitulo8()
        {
            InitializeComponent();

            DispatcherTimer tiempo = new DispatcherTimer();
            tiempo.Tick += new EventHandler(EventoFecha);
            tiempo.Interval = new TimeSpan(0, 0, 1);
            tiempo.Start();
        }

        private void EventoFecha(object ob, EventArgs evt)
        {
            MostrarFechaTextBox.Text = DateTime.Now.ToString();
        }

    }
}
