using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConeccionSQL
    {
        private readonly string connectionString;
        public ConeccionSQL()
        {
            connectionString = "server=mssql-56075-0.cloudclusters.net,16704;DataBase = DatosLogin ;user id=Proyecto; password= Pass1234";
            


            //"Persist Security Info=False;User ID=Proyecto;Password=Pass1234;Initial Catalog=AdventureWorks;Server=mssql-54907-0.cloudclusters.net,11798";

            //"mssql-54907-0.cloudclusters.net,11798;DataBase = master;User ID=Proyecto;Password=Pass1234";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
