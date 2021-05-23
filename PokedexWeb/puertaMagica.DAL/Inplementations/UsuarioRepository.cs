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
    public class UsuarioRepository : IUsuarioRepository
    {
        public ConcesionarioContext context { get; set; }
        public UsuarioRepository(ConcesionarioContext context)
        {
            this.context = context;
        }

        public int Insertar(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "INSERT INTO Usuarios (username,password) VALUES (@username,@password)";

            MySqlCommand command = new MySqlCommand(query, conn);


            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.Password);


            conn.Open();
            try {
               command.ExecuteNonQuery();

                /* if (result < 0) {
                     Console.WriteLine("Error inserting data into DataBase");
                 }*/
                Console.WriteLine(200);
                return 200;

                

            }
            catch (MySqlException ex) {

                if (ex.Number == 1062) {
                    Console.WriteLine(409);
                    return 409;
                }
                else {
                    Console.WriteLine(500);
                    return 500;
                }




            }




        }

        public void Actualizar(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "Update Usuarios SET password =  @password WHERE username = @username";

            MySqlCommand command = new MySqlCommand(query, conn);


            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.Password);


            conn.Open();
            int result = command.ExecuteNonQuery();

            if (result < 0) {
                Console.WriteLine("Error updating data into DataBase");
            }
        }

        public void Delete(string username)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "DELETE FROM usuarios WHERE username = @username";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", username);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error updating data into Database!");
        }
    }
}




