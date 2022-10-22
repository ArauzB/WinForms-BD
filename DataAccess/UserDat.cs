using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDeSoporte.Cache;

namespace DataAccess
{
    public class UserDat:ConeccionSQL
    {
        public bool Login(string user,string pass)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select *from Usuarios where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            CacheLogin.IdUser = reader.GetInt32(0);
                            CacheLogin.FirstName = reader.GetString(3);
                            CacheLogin.LastName = reader.GetString(4);
                            CacheLogin.Position = reader.GetString(5);
                            CacheLogin.Email = reader.GetString(6);
                        }
                        

                        return true;
                    }
                    else
                        return false;
                }
            }
        }

    }

}
