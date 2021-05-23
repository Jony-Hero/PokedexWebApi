using MySql.Data.MySqlClient;
using puertaMagica.DAL.Contracts;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.DAL.Inplementations
{
    public class LoginRepository : ILoginRepository
    {
        public ConcesionarioContext context { get; set; }

        public LoginRepository(ConcesionarioContext context)
        {
            this.context = context;
        }
        public bool Login(Usuario usuario)
        {
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("Select * from usuarios" +
                    " where username = '{0}' and" +
                    " password = '{1}' ",usuario.Username,usuario.Password), conn);

                using (var reader = cmd.ExecuteReader()) 
                {

                    while (reader.Read()) {
                        return true;
                    }
                }

            }
            return false;

        }
    }
}
