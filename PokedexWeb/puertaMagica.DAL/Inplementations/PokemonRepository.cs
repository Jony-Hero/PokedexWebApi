using MySql.Data.MySqlClient;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using puertaMagica.DAL.Contracts;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.DAL.Inplementations
{
    public class PokemonRepository : IPokemonRepository
    {

        public ConcesionarioContext context { get; set; }
        public PokemonRepository(ConcesionarioContext context)
        {
            this.context = context;
        }

        public int Insertar(Pokemon pokemon)
        {
            MySqlConnection conn = null;
            try {
                conn = context.GetConnection();
            }
            catch (MySqlException e) {
                Debug.WriteLine(e);
            }

            string query = "INSERT INTO pokemones (NumeroP,Nombre,Descripcion,Altura,Peso,Categoria,Habilidad,Tipo,Imagen) VALUES (@NumeroP,@Nombre,@Descripcion,@Altura,@Peso,@Categoria,@Habilidad,@Tipo,@Imagen)";

            MySqlCommand command = new MySqlCommand(query, conn);


            command.Parameters.AddWithValue("@NumeroP", pokemon.NumeroP);
            command.Parameters.AddWithValue("@Nombre", pokemon.Nombre);
            command.Parameters.AddWithValue("@Descripcion", pokemon.Descripcion);
            command.Parameters.AddWithValue("@Altura", pokemon.Altura);
            command.Parameters.AddWithValue("@Peso", pokemon.Peso);
            command.Parameters.AddWithValue("@Categoria", pokemon.Categoria);
            command.Parameters.AddWithValue("@Habilidad", pokemon.Habilidad);
            command.Parameters.AddWithValue("@Tipo", pokemon.Tipo);
            command.Parameters.AddWithValue("@Imagen", pokemon.Imagen);



            conn.Open();
            try {
                command.ExecuteNonQuery();

                /* if (result < 0) {
                     Console.WriteLine("Error inserting data into DataBase");
                 }*/
                Debug.WriteLine(200);
                return 200;



            }
            catch (MySqlException ex) {

                if (ex.Number == 1062) {
                    Debug.WriteLine(ex);
                    return 409;
                }
                else {
                    Debug.WriteLine(ex);
                    return 500;
                }




            }




        }

        public int Actualizar(Pokemon pokemon)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "UPDATE pokemones SET Nombre=@Nombre,Descripcion =@Descripcion," +
                " Altura = @Altura, Peso =@Peso, Categoria = @Categoria,Habilidad=@Habilidad,Tipo =@Tipo, Imagen =@Imagen " +
                "WHERE NumeroP = @NumeroP;";
            /* string query2 = "UPDATE pokemones` SET `NumeroP` = <{NumeroP: }>, `Nombre` = <{Nombre: }>, `Descripcion` = <{Descripcion: }>," +
                 " `Altura` = <{Altura: }>, `Peso` = <{Peso: }>, `Categoria` = <{Categoria: }>,`Habilidad` = <{Habilidad: }>, `Tipo` = <{Tipo: }>, `Imagen` = <{Imagen: }> " +
                 "WHERE `NumeroP` = <{expr}>;"*/

            MySqlCommand command = new MySqlCommand(query, conn);


            command.Parameters.AddWithValue("@Nombre", pokemon.Nombre);
            command.Parameters.AddWithValue("@Descripcion", pokemon.Descripcion);
            command.Parameters.AddWithValue("@Altura", pokemon.Altura);
            command.Parameters.AddWithValue("@Peso", pokemon.Peso);
            command.Parameters.AddWithValue("@Categoria", pokemon.Categoria);
            command.Parameters.AddWithValue("@Habilidad", pokemon.Habilidad);
            command.Parameters.AddWithValue("@Tipo", pokemon.Tipo);
            command.Parameters.AddWithValue("@Imagen", pokemon.Imagen);
            command.Parameters.AddWithValue("@NumeroP", pokemon.NumeroP);

            conn.Open();
            try {
                command.ExecuteNonQuery();

                /* if (result < 0) {
                     Console.WriteLine("Error inserting data into DataBase");
                 }*/
                Debug.WriteLine(200);
                return 200;



            }
            catch (MySqlException ex) {
                Console.WriteLine(ex.Number);
                if (ex.Number == 1042) {
                    Debug.WriteLine(ex);
                    return 404;
                }
                else {
                    Debug.WriteLine(ex);
                    return 500;
                }
            }
        }

        public int Delete(string Nombre)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "DELETE FROM pokemones WHERE Nombre= @Nombre";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@Nombre", Nombre);

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
                Console.WriteLine(ex.Number);
                if (ex.Number == 1042) {
                    Console.WriteLine(404);
                    return 404;
                }
                else {
                    Console.WriteLine(500);
                    return 500;
                }
            }
        }

        public List<Pokemon> getAll()
        {
            List<Pokemon> poke = new List<Pokemon>();
            MySqlConnection conn = context.GetConnection();

            string query = "Select * FROM pokemones ORDER BY NUMEROP;";

            MySqlCommand command = new MySqlCommand(query, conn);
            JsonSerializer json = new();
            conn.Open();

            var reader = command.ExecuteReader();
            while (reader.Read()) {
                /*List<PokeTipo> tipos = JsonConvert.DeserializeObject<List<PokeTipo>>(reader["Tipo"].ToString());
                Debug.WriteLine("=================");
                foreach (var item in tipos) {
                    Debug.WriteLine(item);
                }*/
                Pokemon po = new() {
                    NumeroP = (int)reader["NumeroP"],
                    Nombre = reader["Nombre"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    Altura = (double)reader["Altura"],
                    Peso = (double)reader["Peso"],
                    Categoria = reader["Categoria"].ToString(),
                    Habilidad = reader["Habilidad"].ToString(),
                    /*Tipo = reader["Tipo"].ToString(),*/
                    Tipo = reader["Tipo"].ToString(),
                    Imagen = reader["Imagen"].ToString(),
                };
                poke.Add(po);
            }

            foreach (var item in poke) {
                Debug.WriteLine(item.Tipo);
            }

            return poke;
        }


        public Pokemon getId(int numeroP)
        {
            Debug.WriteLine(numeroP);
            MySqlConnection conn = context.GetConnection();
            conn.Open();
            string query = "Select * FROM pokedexapi.pokemones where NUMEROP = {0}; ";
            Pokemon pok = new Pokemon();
            MySqlCommand command = new MySqlCommand(string.Format(query,numeroP), conn);
            JsonSerializer json = new();
            
            var reader = command.ExecuteReader();
           
            Debug.WriteLine(numeroP);
            while (reader.Read()) {
               
                /*List<PokeTipo> tipos = JsonConvert.DeserializeObject<List<PokeTipo>>(reader["Tipo"].ToString());
                Debug.WriteLine("=================");
                foreach (var item in tipos) {
                    Debug.WriteLine(item);
                }*/
                Pokemon po = new() {
                    
                NumeroP = (int)reader["NumeroP"],
                    Nombre = reader["Nombre"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    Altura = (double)reader["Altura"],
                    Peso = (double)reader["Peso"],
                    Categoria = reader["Categoria"].ToString(),
                    Habilidad = reader["Habilidad"].ToString(),
                    /*Tipo = reader["Tipo"].ToString(),*/
                    Tipo = reader["Tipo"].ToString(),
                    Imagen = reader["Imagen"].ToString(),

                    
            };
                Debug.WriteLine(po.NumeroP);
                pok = po;
                
            }
            conn.Close();
            return pok;




        }
    }
}

