using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CrudDatosP
    {
        private ConeccionSQL2 conexion = new ConeccionSQL2();


        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDatosP";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public void Insertar(string Nombre, string Apellido, int Telefono, string Correo, string Pais, string Departamento, string Ciudad, string Direccion, string Tipo_trabajo, string Seguimiento, string Fecha, string Fecha_cita)
        {

            
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsetarDatos";
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@apellido", Apellido);
                comando.Parameters.AddWithValue("@telefono", Telefono);
                comando.Parameters.AddWithValue("@correo", Correo);
                comando.Parameters.AddWithValue("@pais", Pais);
                comando.Parameters.AddWithValue("@departamento", Departamento);
                comando.Parameters.AddWithValue("@ciudad", Ciudad);
                comando.Parameters.AddWithValue("@direccion", Direccion);
                comando.Parameters.AddWithValue("@tipo_de_trabajo", Tipo_trabajo);
                comando.Parameters.AddWithValue("@seguimiento", Seguimiento);
                comando.Parameters.AddWithValue("@fecha_de_ingreso", Fecha);
                comando.Parameters.AddWithValue("@fecha_de_cita", Fecha_cita);
                
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

        }


        public void Editar (string Nombre, string Apellido, int Telefono, string Correo, string Pais, string Departamento, string Ciudad, string Direccion, string Tipo_trabajo, string Seguimiento, string Fecha, string Fecha_cita ,string Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@apellido", Apellido);
            comando.Parameters.AddWithValue("@telefono", Telefono);
            comando.Parameters.AddWithValue("@correo", Correo);
            comando.Parameters.AddWithValue("@pais", Pais);
            comando.Parameters.AddWithValue("@departamento", Departamento);
            comando.Parameters.AddWithValue("@ciudad",Ciudad );
            comando.Parameters.AddWithValue("@direccion",Direccion );
            comando.Parameters.AddWithValue("@tipo_de_trabajo",Tipo_trabajo );
            comando.Parameters.AddWithValue("@seguimiento",Seguimiento );
            comando.Parameters.AddWithValue("@fecha_de_ingreso", Fecha);
            comando.Parameters.AddWithValue("@fecha_de_cita", Fecha_cita);
            comando.Parameters.AddWithValue("@id",Id );
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            
            conexion.CerrarConexion();

        }

      


    }
}
