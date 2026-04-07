using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeShopNusantara.Models;
using MySqlConnector;

namespace CoffeShopNusantara.Repos
{
    public class UserRepo
    {
        public async Task<int> CreateAsync(User user)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO user " +
                "(code,name,phone,email,username,password) " +
                "VALUES " +
                "(@code,@name,@phone,@email,@username,@password); " +
                "SELECT LAST_INSERT_ID();";
            cmd.Parameters.AddWithValue("@code", user.Code);
            cmd.Parameters.AddWithValue("@name", (object?)user.Name ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object?)user.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)user.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", (object?)user.Password ?? DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_user, code, name, phone, email, username, password " +
                "FROM user WHERE id_user=@id LIMIT 1";
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new User
                {
                    IdUser = reader.GetInt32("id_user"),
                    Code = reader.GetString("code"),
                    Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                    Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? null : reader.GetString("phone"),
                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                    Username = reader.GetString("username"),
                    Password = reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                };
            }
            return null;
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_user, code, name, phone, email, username, password " +
                "FROM user WHERE username=@username LIMIT 1";
            cmd.Parameters.AddWithValue("@username", username);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new User
                {
                    IdUser = reader.GetInt32("id_user"),
                    Code = reader.GetString("code"),
                    Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                    Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? null : reader.GetString("phone"),
                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                    Username = reader.GetString("username"),
                    Password = reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                };
            }
            return null;
        }

        public async Task<List<User>> GetAllAsync()
        {
            var list = new List<User>();
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_user, code, name, phone, email, username, password FROM user";
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(new User
                {
                    IdUser = reader.GetInt32("id_user"),
                    Code = reader.GetString("code"),
                    Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                    Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? null : reader.GetString("phone"),
                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                    Username = reader.GetString("username"),
                    Password = reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                });
            }
            return list;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE user SET code=@code, name=@name, " +
                "phone=@phone, email=@email, username=@username, password=@password " +
                "WHERE id_user=@id";
            cmd.Parameters.AddWithValue("@code", user.Code);
            cmd.Parameters.AddWithValue("@name", (object?)user.Name ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object?)user.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)user.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", (object?)user.Password ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", user.IdUser);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM user WHERE id_user=@id";
            cmd.Parameters.AddWithValue("@id", id);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }
    }
}
