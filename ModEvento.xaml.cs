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
    /// Interaction logic for ModEvento.xaml
    /// </summary>
    public partial class ModEvento : Window
    {
        public ModEvento()
        {
            InitializeComponent();
        }

        private void btModifica_Click(object sender, RoutedEventArgs e)
        {
            int res = -1;
            if (dpFecha.SelectedDate != null)
            {
                DateTime fecha1 = dpFecha.DisplayDate;
                String fecha = fecha1.ToString("yyyy-MM-dd");
                String hora = txHoras.Text + ":" + txMin.Text + ":00.00";
                Evento a = new Evento(Int16.Parse(txCu.Text), txLugar.Text, fecha, hora);
                res = a.modificar(a);

            }
                
            if (res > 0)
                MessageBox.Show("Evento actualizado.");
            else
                MessageBox.Show("Evento no actualizado.");

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

        private void BtHrsMas_Click(object sender, RoutedEventArgs e)
        {
            int a = ((Convert.ToInt32(txHoras.Text) + 1) % 24);
            if (a < 10)
                txHoras.Text = "0" + Convert.ToString(a);
            else
                txHoras.Text = a.ToString();
        }

        private void TxHrsMin_Click(object sender, RoutedEventArgs e)
        {
            int a = ((Convert.ToInt32(txHoras.Text) - 1) % 24);
            if (a < 10)
                txHoras.Text = "0" + Convert.ToString(a);
            else
                txHoras.Text = a.ToString();
        }

        private void BtMinMas_Click(object sender, RoutedEventArgs e)
        {
            int a = ((Convert.ToInt32(txMin.Text) + 1) % 60);
            if (a < 10)
                txMin.Text = "0" + Convert.ToString(a);
            else
                txMin.Text = a.ToString();
        }

        private void TxMinMenos_Click(object sender, RoutedEventArgs e)
        {
            int a = ((Convert.ToInt32(txMin.Text) - 1) % 60);
            if (a < 10)
                txMin.Text = "0" + Convert.ToString(a);
            else
                txMin.Text = a.ToString();
        }
    }
}
