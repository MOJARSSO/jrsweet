using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JRsweet.DL
{
    public static class DataLayer
    {
        static MySqlConnection connection = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "jr_sweetshirt",
                UserID = "root",
                Password = "1234",
            }.ConnectionString
            );
        public static int AddCustomer(Customer n)
        {

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_AddCoustomer", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", n.ID);
                komut.Parameters.AddWithValue("@nam", n.Name);
                komut.Parameters.AddWithValue("@sur", n.Surname);
                komut.Parameters.AddWithValue("@tel", n.Telefon);
                komut.Parameters.AddWithValue("@email", n.Email);
                komut.Parameters.AddWithValue("@addr", n.Addres);

                int res = komut.ExecuteNonQuery();
                return res; 

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }

        }

        internal static int AddProduct(Product u)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_AddProduct", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@nam", u.Name);
                komut.Parameters.AddWithValue("@categore", u.Categore);
                komut.Parameters.AddWithValue("@price", u.Price);
                komut.Parameters.AddWithValue("@stock", u.Stock);
                komut.Parameters.AddWithValue("@unit", u.Unit);
                komut.Parameters.AddWithValue("@detail", u.Detail);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int AddSales(Sales s)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_AddSales", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.CustomerID);
                komut.Parameters.AddWithValue("@uid", s.ProductID);
                komut.Parameters.AddWithValue("@date", s.Date);
                komut.Parameters.AddWithValue("@price", s.Price);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static DataSet BringCustomer(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("jrsweet_AllCustomer", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("jrsweet_BringCustomer", connection);
                    komut = new MySqlCommand("jrsweet_AllCustomer", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }

                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static DataSet BringProduct(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("jrsweet_AllProduct", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("jrsweet_BringProduct", connection);
                    komut = new MySqlCommand("jrsweet_AllProduct", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }

                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
         }

        internal static int DeleteCustomer(string id)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_DeleteCustomer", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
                

                int res = komut.ExecuteNonQuery();
                return res;  

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int DeleteProduct(string id)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_DeleteProduct", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

       

        internal static int UpdateCustomer(Customer n)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_UpdateCoustomer", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", n.ID);
                komut.Parameters.AddWithValue("@nam", n.Name);
                komut.Parameters.AddWithValue("@sur", n.Surname);
                komut.Parameters.AddWithValue("@tel", n.Telefon);
                komut.Parameters.AddWithValue("@email", n.Email);
                komut.Parameters.AddWithValue("@addr", n.Addres);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int UpdateProduct(Product u)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("jrsweet_UpdateProduct", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@pnam", u.Name);
                komut.Parameters.AddWithValue("@categore", u.Categore);
                komut.Parameters.AddWithValue("@price", u.Price);
                komut.Parameters.AddWithValue("@stock", u.Stock);
                komut.Parameters.AddWithValue("@unit", u.Unit);
                komut.Parameters.AddWithValue("@detail", u.Detail);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
    }
}
