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
    /// Interaction logic for PagPrincAdmin.xaml
    /// </summary>
    public partial class PagPrincAdmin : Window
    {
        public PagPrincAdmin()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AccesoAdmin w = new AccesoAdmin();
            w.Show();
        }

        private void btAgrEvento_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
             NuevoEvento w = new NuevoEvento();
            w.Show();
        }

        private void btMod_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ModEvento w = new ModEvento();
            w.Show();


        }

        private void btElim_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ElimEvento w = new ElimEvento();
            w.Show();
        }
    }
}
