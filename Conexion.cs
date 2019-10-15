using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace appEventos
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader rd;

        public static SqlConnection conectar()
        {
            SqlConnection cnn;
            try
            { //112SALAS02 ingenierias     Password = sqladmin       CC102-14\\SA pwd = adminadmin
                cnn = new SqlConnection("Data Source=112SALAS06;Initial Catalog=baseEventosITAM;User ID=sa;Password=sqladmin");
                cnn.Open();
                MessageBox.Show("Sí se pudo hacer la conexión.");
            }
            catch (Exception ex)
            {
                cnn = null;
                MessageBox.Show("No se pudo hacer la conexión" + ex);
            }
            return cnn;
        }

        public static String comprabarPwd(String admin, String contra)
        {
            String res = "Error!!";
            SqlDataReader rd;
            SqlConnection con;
            try
            {
                con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select contraseña from Administrador where nombre = '{0}'", admin), con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (rd.GetString(0).Equals(contra))
                        res = "Contraseña Correcta";
                    else
                        res = "Contraseña Incorrecta";
                }
                else
                {
                    res = "Usuario Incorrecto";
                }
                con.Close();
                rd.Close();

            }
            catch (Exception ex)
            {
                res = "Error!!" + ex;
            }
            return res;

        }

        public void llenarComboAlta(ComboBox cb)
        {
            try
            {
                SqlConnection con;
                con = Conexion.conectar();
                cmd = new SqlCommand("select carrera from carrera", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                        
                    cb.Items.Add(rd["carrera"].ToString());
                }
                cb.SelectedIndex = 0;
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo" + ex);
            }
        }

    }
}
