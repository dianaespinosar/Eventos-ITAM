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
    /// Interaction logic for EditPerfil.xaml
    /// </summary>
    public partial class EditPerfil : Window
    {
        public EditPerfil()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Perfil w = new Perfil();
            w.Show();

        }
    }
}
