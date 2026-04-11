using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace CoffeShopNusantara.Repos
{
    public static class Database
    {
        public static string ConnectionStringOldStyle { get; set; }
        = "Server=localhost;Port=3306;Database=db_coffenusantara;Uid=root;Pwd=;";
        public static MySqlConnection GetConnectionOldStyle()
        {
            return new MySqlConnection(ConnectionStringOldStyle);
        }
        private static MySqlConnectionStringBuilder DefaultBuilder => new()
        {
            Server = "localhost",
            Port = 3306,
            Database = "db_coffenusantara",
            UserID = "root",
            Password = "",
            Pooling = true,
            MinimumPoolSize = 0,
            MaximumPoolSize = 100,
            ConnectionLifeTime = 0,
            ConnectionTimeout = 15,
        };
        public static string? ConnectionString { get; set; }
        public static MySqlConnection GetConnection()
        {
            var cs = ConnectionString ?? DefaultBuilder.ConnectionString;
            return new MySqlConnection(cs);
        }
        public static async Task<MySqlConnection> GetOpenConnectionAsync()
        {
            var connection = GetConnection();
            await connection.OpenAsync();
            return connection;
        }
    }
}
