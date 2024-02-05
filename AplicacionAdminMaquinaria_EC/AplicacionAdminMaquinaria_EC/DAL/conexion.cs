using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAdminMaquinaria_EC.DAL
{
    class conexion
    {
        public bool Pruebaconectar()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-3DMQH4C\\SQLEXPRESS;Initial Catalog=dbSistema; Integrated Security = True");
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "SELECT * FROM Empleados";
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                return true;

            }catch (Exception ex)
            {
                return false;
            }
        }

    }
}
