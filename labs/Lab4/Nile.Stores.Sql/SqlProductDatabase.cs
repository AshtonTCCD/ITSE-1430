using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        private readonly SqlConnection _connection;

        public SqlProductDatabase ( string connectionString )
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        protected override Product GetCore ( int id )
        {
            var cmd = new SqlCommand("GetProduct", _connection) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return new Product() {
                    Id = reader.GetInt32("id"),
                    Description = reader.IsDBNull("description") ? String.Empty : reader.GetString("description"),
                    IsDiscontinued = reader.GetBoolean("isDiscontinued"),
                    Name = reader.GetString("name"),
                    Price = reader.GetDecimal("price")
                };
            }

            return null;
        }

        protected override IEnumerable<Product> GetAllCore ()
        {
            var ds = new DataSet();
            var da = new SqlDataAdapter() {
                SelectCommand = new SqlCommand("GetAllProducts", _connection)
                    { CommandType = CommandType.StoredProcedure }
            };
            da.Fill(ds);

            var products = new List<Product>();
            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();

            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    products.Add(new Product() {
                        Id = row.Field<int>("id"),
                        Description = row.IsNull("description") ? String.Empty : row.Field<string>("description"),
                        IsDiscontinued = row.Field<bool>("isDiscontinued"),
                        Name = row.Field<string>("name"),
                        Price = row.Field<decimal>("price")
                    });
                }
            }

            return products;
        }

        protected override void RemoveCore ( int id )
        {
            var cmd = new SqlCommand("RemoveProduct", _connection) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        protected override Product UpdateCore ( Product existing, Product newItem )
        {
            var cmd = new SqlCommand("UpdateProduct", _connection) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", existing.Id);
            cmd.Parameters.AddWithValue("@name", newItem.Name);
            cmd.Parameters.AddWithValue("@price", newItem.Price);
            cmd.Parameters.AddWithValue("@description", newItem.Description);
            cmd.Parameters.AddWithValue("@isDiscontinued", newItem.IsDiscontinued);

            cmd.ExecuteNonQuery();

            return newItem;
        }

        protected override Product AddCore ( Product product )
        {
            var cmd = new SqlCommand("AddProduct", _connection) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

            product.Id = Convert.ToInt32(cmd.ExecuteScalar());
            return product;
        }
    }
}
