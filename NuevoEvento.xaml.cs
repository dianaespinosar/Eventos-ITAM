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
    /// Interaction logic for NuevoEvento.xaml
    /// </summary>
    public partial class NuevoEvento : Window
    {
        public NuevoEvento()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, RoutedEventArgs e)
        {



            int res = -1;
            if (dtpFecha.SelectedDate != null) {
                DateTime fecha1 = dtpFecha.DisplayDate;
                String fecha = fecha1.ToString("yyyy-MM-dd");
                String hora = txHoras.Text + ":" + txMin.Text + ":00.00";

                Evento a = new Evento(Int16.Parse(txClaveUnica.Text), txNom.Text, cbCarreras.SelectedIndex, txOrg.Text, txLugar.Text, fecha, hora, txDescrip.Text);
                res = a.agregar(a);
            }
            
            if (res > 0)
                MessageBox.Show("Evento dado de alta.");
            else
                MessageBox.Show("Evento no dado de alta.");

            this.Hide();
            PagPrincAdmin w = new PagPrincAdmin();
            w.Show();

        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PagPrincAdmin w = new PagPrincAdmin();
            w.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarComboAlta(cbCarreras);
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
    }
}
