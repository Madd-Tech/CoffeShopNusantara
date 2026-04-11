using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeShopNusantara.Models;
using MySqlConnector;
using System.Data;

namespace CoffeShopNusantara.Repos
{
    public class MemberRepo
    {
        public async Task<int> CreateAsync (Member member)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO member " +
                "(code,fullname,phone,email,username,password,last_update,is_deleted) " +
                "VALUES " +
                "(@code,@fullname,@phone,@email,@username,@password,@last_update,@is_deleted); " +
                "SELECT LAST_INSERT_ID();";
               /*"(" +
                    member.Code + "," +
                    (object?)member.FullName ?? System.DBNull.Value  +"," +
                    (object?)member.Phone ?? System.DBNull.Value + "," +
               ");";*/
            cmd.Parameters.AddWithValue("@code", member.Code);
            cmd.Parameters.AddWithValue("@fullname", (object?)member.FullName ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object?)member.Phone ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)member.Email ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@username", member.Username);
            cmd.Parameters.AddWithValue("@password", (object?)member.Password ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)member.LastUpdate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)member.IsDeleted ?? System.DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }

        // prepared statement dengan parameter untuk mencegah SQL injection
        // statement biasa langung menyisipkan nilai ke dalam query string, raw SQL, rentan terhadap SQL injection

        public async Task<Member?> GetByIdAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_member, code, fullname, phone, email, username, password, last_update, is_deleted FROM member WHERE id_member=@id AND (is_deleted IS NULL OR is_deleted != '1') LIMIT 1";
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Member
                {
                    IdMember = reader.GetInt32("id_member"),
                    Code = reader.GetString("code"),
                    FullName = reader.IsDBNull("fullname") ? null : reader.GetString("fullname"),
                    Phone = reader.IsDBNull("phone") ? null : reader.GetString("phone"),
                    Email = reader.IsDBNull("email") ? null : reader.GetString("email"),
                    Username = reader.GetString("username"),
                    Password = reader.IsDBNull("password") ? null : reader.GetString("password"),
                    LastUpdate = reader.IsDBNull("last_update") ? null : reader.GetDateTime("last_update"),
                    IsDeleted = reader.IsDBNull("is_deleted") ? null : reader.GetString("is_deleted"),
                };
            }
            return null;
        }

        public async Task<List<Member>> GetAllAsync()
        {
            var list = new List<Member>();
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_member, code, fullname, phone, email, username, password, last_update, is_deleted FROM member WHERE (is_deleted IS NULL OR is_deleted != '1')";
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(new Member
                {
                    IdMember = reader.GetInt32("id_member"),
                    Code = reader.GetString("code"),
                    FullName = reader.IsDBNull("fullname") ? null : reader.GetString("fullname"),
                    Phone = reader.IsDBNull("phone") ? null : reader.GetString("phone"),
                    Email = reader.IsDBNull("email") ? null : reader.GetString("email"),
                    Username = reader.GetString("username"),
                    Password = reader.IsDBNull("password") ? null : reader.GetString("password"),
                    LastUpdate = reader.IsDBNull("last_update") ? null : reader.GetDateTime("last_update"),
                    IsDeleted = reader.IsDBNull("is_deleted") ? null : reader.GetString("is_deleted"),
                });
            }
            return list;
        }


        
        public async Task<bool> UpdateAsync(Member member)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE member SET code=@code, fullname=@fullname, " +
                "phone=@phone, email=@email, username=@username, password=@password, " +
                "last_update=@last_update, is_deleted=@is_deleted WHERE id_member=@id";
            cmd.Parameters.AddWithValue("@code", member.Code);
            cmd.Parameters.AddWithValue("@fullname", (object?)member.FullName ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object?)member.Phone ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)member.Email ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@username", member.Username);
            cmd.Parameters.AddWithValue("@password", (object?)member.Password ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)member.LastUpdate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)member.IsDeleted ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id", member.IdMember);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE member SET is_deleted='1' WHERE id_member=@id";
            cmd.Parameters.AddWithValue("@id", id);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }
    }
}
