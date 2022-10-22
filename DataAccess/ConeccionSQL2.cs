using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ConeccionSQL2
    {
        private SqlConnection Conexion = new SqlConnection("server=mssql-56075-0.cloudclusters.net,16704;DataBase = Datos ;user id=Proyecto; password= Pass1234");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
                
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

      
    }



}

