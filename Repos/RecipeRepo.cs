using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeShopNusantara.Models;
using MySqlConnector;

namespace CoffeShopNusantara.Repos
{
    public class RecipeRepo
    {
        public async Task<int> CreateAsync(Recipe recipe)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO recipe " +
                "(code, name, type, id_item_a, id_item_b, id_item_c, id_item_d, qty_item_a, qty_item_b, qty_item_c, qty_item_d, recipe_instruction, saving_instruction, last_update, is_deleted) " +
                "VALUES " +
                "(@code, @name, @type, @id_item_a, @id_item_b, @id_item_c, @id_item_d, @qty_item_a, @qty_item_b, @qty_item_c, @qty_item_d, @recipe_instruction, @saving_instruction, @last_update, @is_deleted); " +
                "SELECT LAST_INSERT_ID();";
            cmd.Parameters.AddWithValue("@code", recipe.Code);
            cmd.Parameters.AddWithValue("@name", (object?)recipe.Name ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@type", (object?)recipe.Type ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id_item_a", recipe.IdItemA);
            cmd.Parameters.AddWithValue("@id_item_b", recipe.IdItemB);
            cmd.Parameters.AddWithValue("@id_item_c", recipe.IdItemC);
            cmd.Parameters.AddWithValue("@id_item_d", recipe.IdItemD);
            cmd.Parameters.AddWithValue("@qty_item_a", recipe.QtyItemA);
            cmd.Parameters.AddWithValue("@qty_item_b", recipe.QtyItemB);
            cmd.Parameters.AddWithValue("@qty_item_c", recipe.QtyItemC);
            cmd.Parameters.AddWithValue("@qty_item_d", recipe.QtyItemD);
            cmd.Parameters.AddWithValue("@recipe_instruction", (object?)recipe.RecipeInstruction ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@saving_instruction", (object?)recipe.SavingInstruction ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", recipe.LastUpdate);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)recipe.IsDeleted ?? DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }

        public async Task<Recipe?> GetByIdAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_recipe, code, name, type, id_item_a, id_item_b, id_item_c, id_item_d, " +
                "qty_item_a, qty_item_b, qty_item_c, qty_item_d, recipe_instruction, saving_instruction, last_update, is_deleted " +
                "FROM recipe WHERE id_recipe=@id AND (is_deleted IS NULL OR is_deleted != '1') LIMIT 1";
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return MapReaderToRecipe(reader);
            }
            return null;
        }

        public async Task<List<Recipe>> GetAllAsync()
        {
            var list = new List<Recipe>();
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_recipe, code, name, type, id_item_a, id_item_b, id_item_c, id_item_d, " +
                "qty_item_a, qty_item_b, qty_item_c, qty_item_d, recipe_instruction, saving_instruction, last_update, is_deleted " +
                "FROM recipe WHERE (is_deleted IS NULL OR is_deleted != '1')";
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(MapReaderToRecipe(reader));
            }
            return list;
        }

        public async Task<bool> UpdateAsync(Recipe recipe)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE recipe SET code=@code, name=@name, type=@type, " +
                "id_item_a=@id_item_a, id_item_b=@id_item_b, id_item_c=@id_item_c, id_item_d=@id_item_d, " +
                "qty_item_a=@qty_item_a, qty_item_b=@qty_item_b, qty_item_c=@qty_item_c, qty_item_d=@qty_item_d, " +
                "recipe_instruction=@recipe_instruction, saving_instruction=@saving_instruction, " +
                "last_update=@last_update, is_deleted=@is_deleted WHERE id_recipe=@id";
            cmd.Parameters.AddWithValue("@code", recipe.Code);
            cmd.Parameters.AddWithValue("@name", (object?)recipe.Name ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@type", (object?)recipe.Type ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id_item_a", recipe.IdItemA);
            cmd.Parameters.AddWithValue("@id_item_b", recipe.IdItemB);
            cmd.Parameters.AddWithValue("@id_item_c", recipe.IdItemC);
            cmd.Parameters.AddWithValue("@id_item_d", recipe.IdItemD);
            cmd.Parameters.AddWithValue("@qty_item_a", recipe.QtyItemA);
            cmd.Parameters.AddWithValue("@qty_item_b", recipe.QtyItemB);
            cmd.Parameters.AddWithValue("@qty_item_c", recipe.QtyItemC);
            cmd.Parameters.AddWithValue("@qty_item_d", recipe.QtyItemD);
            cmd.Parameters.AddWithValue("@recipe_instruction", (object?)recipe.RecipeInstruction ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@saving_instruction", (object?)recipe.SavingInstruction ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", recipe.LastUpdate);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)recipe.IsDeleted ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", recipe.IdRecipe);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE recipe SET is_deleted='1' WHERE id_recipe=@id";
            cmd.Parameters.AddWithValue("@id", id);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }

        private static Recipe MapReaderToRecipe(MySqlDataReader reader)
        {
            return new Recipe
            {
                IdRecipe = reader.GetInt32("id_recipe"),
                Code = reader.GetString("code"),
                Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                Type = reader.IsDBNull(reader.GetOrdinal("type")) ? null : reader.GetString("type"),
                IdItemA = reader.IsDBNull(reader.GetOrdinal("id_item_a")) ? 0 : reader.GetInt32("id_item_a"),
                IdItemB = reader.IsDBNull(reader.GetOrdinal("id_item_b")) ? 0 : reader.GetInt32("id_item_b"),
                IdItemC = reader.IsDBNull(reader.GetOrdinal("id_item_c")) ? 0 : reader.GetInt32("id_item_c"),
                IdItemD = reader.IsDBNull(reader.GetOrdinal("id_item_d")) ? 0 : reader.GetInt32("id_item_d"),
                QtyItemA = reader.IsDBNull(reader.GetOrdinal("qty_item_a")) ? 0.0 : reader.GetDouble("qty_item_a"),
                QtyItemB = reader.IsDBNull(reader.GetOrdinal("qty_item_b")) ? 0.0 : reader.GetDouble("qty_item_b"),
                QtyItemC = reader.IsDBNull(reader.GetOrdinal("qty_item_c")) ? 0.0 : reader.GetDouble("qty_item_c"),
                QtyItemD = reader.IsDBNull(reader.GetOrdinal("qty_item_d")) ? 0.0 : reader.GetDouble("qty_item_d"),
                RecipeInstruction = reader.IsDBNull(reader.GetOrdinal("recipe_instruction")) ? string.Empty : reader.GetString("recipe_instruction"),
                SavingInstruction = reader.IsDBNull(reader.GetOrdinal("saving_instruction")) ? string.Empty : reader.GetString("saving_instruction"),
                LastUpdate = reader.IsDBNull(reader.GetOrdinal("last_update")) ? DateTime.MinValue : reader.GetDateTime("last_update"),
                IsDeleted = reader.IsDBNull(reader.GetOrdinal("is_deleted")) ? null : reader.GetString("is_deleted"),
            };
        }
    }
}
