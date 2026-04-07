using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoffeShopNusantara.Models;
using MySqlConnector;

namespace CoffeShopNusantara.Repos
{
    public class ItemStockRepo
    {

        private static ItemStock MapReaderToItemStock(MySqlDataReader reader)
        {
            return new ItemStock
            {
                IdItem = reader.GetInt32("id_item"),
                Code = reader.GetString("code"),
                Title = reader.GetString("title"),
                Measurement = reader.GetString("measurement"),
                Quantity = reader.GetDouble("quantity"),
                LastUpdate = reader.GetDateTime("last_update"),
                IsDeleted = reader.GetString("is_deleted")
            };
        }

        public async Task<int> CreateAsync(ItemStock itemStock)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO item_stock (code, title, measurement, quantity, last_update, is_deleted) " +
                "VALUES (@code, @title, @measurement, @quantity, @last_update, @is_deleted);";
            cmd.Parameters.AddWithValue("@code", itemStock.Code);
            cmd.Parameters.AddWithValue("@title", itemStock.Title);
            cmd.Parameters.AddWithValue("@measurement", itemStock.Measurement);
            cmd.Parameters.AddWithValue("@quantity", itemStock.Quantity);
            cmd.Parameters.AddWithValue("@last_update", itemStock.LastUpdate);
            cmd.Parameters.AddWithValue("@is_deleted", itemStock.IsDeleted);
            await cmd.ExecuteNonQueryAsync();
            return (int)cmd.LastInsertedId;
        }

        public async Task<ItemStock?> GetByIdAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM item_stock WHERE id_item = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return MapReaderToItemStock(reader);
            }
            return null;
        }
        public async Task<List<ItemStock>> GetAllAsync()
        {
            var list = new List<ItemStock>();
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM item_stock;";
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(MapReaderToItemStock(reader));
            }
            return list;
        }
        public async Task<bool> UpdateAsync(ItemStock itemStock)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE item_stock SET code = @code, title = @title, measurement = @measurement, " +
                "quantity = @quantity, last_update = @last_update, is_deleted = @is_deleted WHERE id_item = @id;";
            cmd.Parameters.AddWithValue("@id", itemStock.IdItem);
            cmd.Parameters.AddWithValue("@code", itemStock.Code);
            cmd.Parameters.AddWithValue("@title", itemStock.Title);
            cmd.Parameters.AddWithValue("@measurement", itemStock.Measurement);
            cmd.Parameters.AddWithValue("@quantity", itemStock.Quantity);
            cmd.Parameters.AddWithValue("@last_update", itemStock.LastUpdate);
            cmd.Parameters.AddWithValue("@is_deleted", itemStock.IsDeleted);
            var rowsAffected = await cmd.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE item_stock SET is_deleted = '1' WHERE id_item = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }
    }
}
