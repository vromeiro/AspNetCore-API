using System.Collections.Generic;
using aspnet_api.Model;
using MySql.Data.MySqlClient;
using Dapper;
using System;

namespace aspnet_api.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly string _connectionString;
        
        public PersonRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Person> Get()
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT guid, name, address FROM person ORDER BY name ASC";
                return connection.Query<Person>(query);
            }
        }

        public Person Get(string guid)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT guid, name, address FROM person WHERE Guid = @Guid";
                return connection.QueryFirstOrDefault<Person>(query, new { Guid = guid });
            }
        }

        public void Post(Person person)
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                var guid =  Guid.NewGuid();
                var query = $"INSERT INTO person(guid, name, address) VALUES('{guid}', @name, @address)";
                connection.Execute(query, person);
            }
        }

        public void Put(Person person)
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                var query = "UPDATE person SET name = @name, address = @address WHERE Guid = @Guid";
                connection.Execute(query, person);
            }
        }

        public void Delete(string guid)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "DELETE FROM person WHERE Guid = @Guid";
                connection.QueryFirstOrDefault<Person>(query, new { Guid = guid });
            }
        }
    }
}