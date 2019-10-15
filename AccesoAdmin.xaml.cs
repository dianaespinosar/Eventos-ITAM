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
    /// Interaction logic for AccesoAdmin.xaml
    /// </summary>
    public partial class AccesoAdmin : Window
    {
        public AccesoAdmin()
        {
            InitializeComponent();
        }

        private void ingresarBT_Click(object sender, RoutedEventArgs e)
        {
            String res = Conexion.comprabarPwd(txAdmin.Text, txContraseña.Password);
            if (res.Equals("Contraseña Correcta"))
            {
                PagPrincAdmin w = new PagPrincAdmin();
                w.Show();
                this.Close();
            }

            else
                MessageBox.Show(res);

        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow w = new MainWindow();
            w.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txAdmin.Text = "Diana";
            txContraseña.Password = "2026";
        }
    }
}
