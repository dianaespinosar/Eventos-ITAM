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

namespace appEventos
{
    /// <summary>
    /// Interaction logic for ElimEvento.xaml
    /// </summary>
    public partial class ElimEvento : Window
    {
        public ElimEvento()
        {
            InitializeComponent();
        }

        private void btElimina_Click(object sender, RoutedEventArgs e)
        {
            int res;
            Evento a = new Evento(Int16.Parse(txCu.Text));
            res = a.eliminar(Int16.Parse(txCu.Text));
            if (res > 0)
                MessageBox.Show("Evento dado de baja.");
            else
                MessageBox.Show("Evento no dado de baja.");
            this.Hide();
            PagPrincAdmin w = new PagPrincAdmin();
            w.Show();
        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PagPrincAdmin w = new PagPrincAdmin();
            w.Show();
        }
    }
}
