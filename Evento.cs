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
    class Evento
    {
        public Int16 claveUnica { get; set; }
        public String nombre { get; set; }

        public int idCarrera { get; set; }
        public String organizadores { get; set; }
        public String lugar { get; set; }
        public String fecha { get; set; }
        public String hora{ get; set; }
        public String descripcion { get; set; }


        public Evento()
        {
        }

        public Evento(short claveUnica)
        {
            this.claveUnica = claveUnica;
        }

        public Evento(string nombre)
        {
            this.nombre = nombre;

        }

        public Evento(short claveUnica, string lugar, string fecha, string hora)
        {
            this.claveUnica = claveUnica;
            this.lugar = lugar;
            this.fecha = fecha;
            this.hora = hora;
        }

        public Evento(short claveUnica, string nombre, int idCarrera, string organizadores, string lugar, string fecha, string hora, string descripcion)
        {
            this.claveUnica = claveUnica;
            this.nombre = nombre;
            this.idCarrera = idCarrera;
            this.organizadores = organizadores;
            this.lugar = lugar;
            this.fecha = fecha;
            this.hora = hora;
            this.descripcion = descripcion;
        }



        /*función de agregar un Evento a la tabla Evento
         y regresa un entero positivo si lo pudo agregar
         o un entero negativo si no lo agregó.
         */

        public int agregar(Evento a)
        {
            int res = 0;
            //abrir la conexión

            SqlConnection con;
            con = Conexion.conectar();
            //command para ejecutar ek query (insert)
            SqlCommand cmd = new SqlCommand(String.Format("insert into Eventos (idEvento, nombre,cu, organizadores,lugar,fecha,hora,descripcion) values ({0}, '{1}',{2},'{3}','{4}','{5}','{6}','{7}') ", a.claveUnica, a.nombre, a.idCarrera, a.organizadores, a.lugar, a.fecha, a.hora,a.descripcion), con);
            res = cmd.ExecuteNonQuery(); //núm de registros afectos 
            //CERRAR CONEXIÓN
            con.Close();
            return res;
        }

        public int eliminar(int cu)
        {
            int res = 0;
            //abrir la conexión
            SqlConnection con;
            con = Conexion.conectar();
            //command para ejecutar ek query (delete)
            SqlCommand cmd = new SqlCommand(String.Format("delete from Eventos where idEvento = {0}", cu), con);
            res = cmd.ExecuteNonQuery(); //núm de registros afectos 
            //CERRAR CONEXIÓN
            con.Close();
            return res;
        }


        public int modificar(Evento a)
        {
            int res = 0;
            //abrir la conexión
            SqlConnection con;
            con = Conexion.conectar();
            //command para ejecutar ek query (update)
            SqlCommand cmd = new SqlCommand(String.Format("update Eventos set lugar = '{0}',  fecha = '{1}' , hora = '{2}'  where idEvento = {3}", a.lugar,a.fecha,a.hora, a.claveUnica), con);
            res = cmd.ExecuteNonQuery(); //núm de registros afectos 
            //CERRAR CONEXIÓN
            con.Close();
            return res;
        }

        public List<Evento> buscar(String nombre)
        {

            List<Evento> lis = new List<Evento>();
            Evento a;
            SqlDataReader rd;
            //abrir la conexión
            SqlConnection con;
            con = Conexion.conectar();
            //command para ejecutar ek query ()
            SqlCommand cmd = new SqlCommand(String.Format("select * from Eventos where nombre like '%{0}%'", nombre), con);
            //ejecutar el query
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                //lectura y establecimiento de la información
                a = new Evento();
                a.claveUnica = rd.GetInt16(0);
                a.nombre = rd.GetString(1);
                a.idCarrera = rd.GetInt16(2);
                a.organizadores = rd.GetString(3);
                a.lugar = rd.GetString(4);
                a.fecha = rd.GetString(5);
                a.hora = rd.GetString(6) ;
                a.descripcion = rd.GetString(7);
                lis.Add(a);

            }

            con.Close();

            return lis;
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Nombre " + nombre).Append(" idEvento " + claveUnica);
            return res.ToString();
        }

    }
}
