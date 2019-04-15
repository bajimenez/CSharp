using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet ejecutarConsulta(string query) {

           
                SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-MQ0SN5H\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
                conexion.Open();

                DataSet DS = new DataSet();
                SqlDataAdapter DA = new SqlDataAdapter(query,conexion);

                DA.Fill(DS);

                conexion.Close();
                return DS;
        }
    }
    
}
