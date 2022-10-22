using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;


namespace Domain
{
     public class DatosP
    {
        private CrudDatosP objetoCD = new CrudDatosP();
        public DataTable MostrarDat()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarDat(string Nombre, string Apellido, string Telefono, string Correo, string Pais, string Departamento, string Ciudad, string Direccion, string Tipo_trabajo, string Seguimiento, string Fecha, string Fecha_cita)
        {
            objetoCD.Insertar(Nombre,Apellido,Convert.ToInt32(Telefono),Correo,Pais,Departamento,Ciudad,Direccion,Tipo_trabajo,Seguimiento, Fecha,Fecha_cita);


        }

        public void EditarDat(string Nombre, string Apellido, string Telefono, string Correo, string Pais, string Departamento, string Ciudad, string Direccion, string Tipo_trabajo, string Seguimiento, string Fecha,string Fecha_cita , string Id)
        {

            objetoCD.Editar(Nombre, Apellido, Convert.ToInt32(Telefono), Correo, Pais, Departamento, Ciudad, Direccion, Tipo_trabajo, Seguimiento, Fecha,Fecha_cita, Id);

        }

    }
 }

