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
    /// Interaction logic for Acceso.xaml
    /// </summary>
    public partial class Acceso : Window
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void ingresarBT_Click(object sender, RoutedEventArgs e)
        {


            this.Hide();
            PaginaPrincipal w = new PaginaPrincipal();
            w.Show();
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow w = new MainWindow();
            w.Show();
        }
    }
}
