using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CoffeShopNusantara.Models;
using MySqlConnector;

namespace CoffeShopNusantara.Repos
{
    public class TransactionRepo
    {
        public async Task<int> CreateAsync(Transaction transaction)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `transaction` (id_transaction, id_member, code, n_menu, transaction,subtotal" +
                "id_discount, tax_rate,tax, total,paid,change) " +
                "VALUES (@id_transaction, @id_member, @code, @n_menu, @transaction,@subtotal,@id_discount" +
                "@tax_rate,@tax,@total,@paid,@change); " +
                "SELECT LAST_INSERT_ID();";
            cmd.Parameters.AddWithValue("@id_transaction", transaction.IdTransaction);
            cmd.Parameters.AddWithValue("@id_member", transaction.IdMember);
            cmd.Parameters.AddWithValue("@code", transaction.Code);
            cmd.Parameters.AddWithValue("@n_menu", transaction.NMenu);
            cmd.Parameters.AddWithValue("@transaction", transaction.TransactionDate);
            cmd.Parameters.AddWithValue("@subtotal", transaction.Subtotal);
            cmd.Parameters.AddWithValue("@id_discount", transaction.IdDiscount);
            cmd.Parameters.AddWithValue("@tax_rate", transaction.TaxRate);
            cmd.Parameters.AddWithValue("@tax", transaction.Tax);
            cmd.Parameters.AddWithValue("@total", transaction.Total);
            cmd.Parameters.AddWithValue("@paid", transaction.Paid);
            cmd.Parameters.AddWithValue("@change", transaction.Change);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }
        public static async Task<Transaction?> GetByIdAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_transaction, id_member, code, n_menu, transaction,subtotal" +
                "id_discount, tax_rate,tax, total,paid,change " +
                "FROM `transaction` WHERE id_transaction = @id_transaction;";
            cmd.Parameters.AddWithValue("@id_transaction", id);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return MapReaderToTransaction(reader);
            }

            return null;
        }


        public async Task<List<Transaction>> GetAllAsync()
        {
            var list = new List<Transaction>();
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_transaction, id_member, code, n_menu, transaction,subtotal" +
                "id_discount, tax_rate,tax, total,paid,change " +
                "FROM `transaction`;";
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(MapReaderToTransaction(reader));
            }
            return list;
        }

        public async Task UpdateAsync(Transaction transaction)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `transaction` SET id_member = @id_member, code = @code, n_menu = @n_menu, " +
                "transaction = @transaction, subtotal = @subtotal, id_discount = @id_discount, tax_rate = @tax_rate, " +
                "tax = @tax, total = @total, paid = @paid, change = @change WHERE id_transaction = @id_transaction;";
            cmd.Parameters.AddWithValue("@id_transaction", transaction.IdTransaction);
            cmd.Parameters.AddWithValue("@id_member", transaction.IdMember);
            cmd.Parameters.AddWithValue("@code", transaction.Code);
            cmd.Parameters.AddWithValue("@n_menu", transaction.NMenu);
            cmd.Parameters.AddWithValue("@transaction", transaction.TransactionDate);
            cmd.Parameters.AddWithValue("@subtotal", transaction.Subtotal);
            cmd.Parameters.AddWithValue("@id_discount", transaction.IdDiscount);
            cmd.Parameters.AddWithValue("@tax_rate", transaction.TaxRate);
            cmd.Parameters.AddWithValue("@tax", transaction.Tax);
            cmd.Parameters.AddWithValue("@total", transaction.Total);
            cmd.Parameters.AddWithValue("@paid", transaction.Paid);
            cmd.Parameters.AddWithValue("@change", transaction.Change);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int id)
        {
            using var conn = Database.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM `transaction` WHERE id_transaction = @id_transaction;";
            cmd.Parameters.AddWithValue("@id_transaction", id);
            await cmd.ExecuteNonQueryAsync();
        }

        private static Transaction MapReaderToTransaction(MySqlDataReader reader)
        {
            return new Transaction
            {
                IdTransaction = reader.GetInt32("id_transaction"),
                IdMember = reader.GetInt32("id_member"),
                Code = reader.GetString("code"),
                NMenu = reader.GetInt32("n_menu"),
                TransactionDate = reader.GetDateTime("transaction"),
                Subtotal = reader.GetDouble("subtotal"),
                IdDiscount = reader.IsDBNull("id_discount") ? null : reader.GetInt32("id_discount"),
                TaxRate = reader.IsDBNull("tax_rate") ? null : reader.GetDouble("tax_rate"),
                Tax = reader.IsDBNull("tax") ? null : reader.GetDouble("tax"),
                Total = reader.IsDBNull("total") ? null : reader.GetDouble("total"),
                Paid = reader.IsDBNull("paid") ? null : reader.GetDouble("paid"),
                Change = reader.IsDBNull("change") ? null : reader.GetDouble("change")

            };
        }
    }
}
