using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam
{
    internal class Database
    {
        string prod, problem, status;
        int idCl, idProd;

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5433; User name=postgres; Password=1111; Database=Exam1");
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        public List<ProdCard> GetProdQuery(string query, string roleUs)
        {

            List<ProdCard> proCards = new List<ProdCard>();

            openConnection();

            NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT id, number_series, " +
                $"product, problem, dop_inf, status, " +
                $"start_date, employes_id, price, finish_date, comment, clients_id" +
                $" FROM products WHERE product LIKE '{query}%'", connection);

            NpgsqlDataReader reader = getProducts.ExecuteReader();

            while (reader.Read())
            {
                ProdCard productCard = new ProdCard(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6).ToString("dd.MM.yyyy"), roleUs, 
                    reader.GetInt32(7), reader.GetInt32(8),
                    reader.GetDateTime(9).ToString("dd.MM.yyyy"), reader.GetString(10),
                    reader.GetInt32(11));
                proCards.Add(productCard);
            }

            closeConnection();

            return proCards;

        }
    }
}
