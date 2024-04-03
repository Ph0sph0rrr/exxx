using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Menu : Form
    {
        Database db = new Database();
        string phoneCl;
        string nameCl, roleUs;
        int idCl;
        public string query;
        

        private void btnaddReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRequest adRq = new AddRequest(nameCl, idCl, roleUs, phoneCl);
            adRq.Show();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            string txt = textBox1.Text;
            if (txt == "Введите для поиска")
            {
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = textBox1.Text;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(db.GetProdQuery(query, roleUs).ToArray());
        }

        public Menu(string nameCl, int idCl, string role, string phone)
        {
            InitializeComponent();

            lbHi.Text = "Здравствуйте, " + nameCl + ".";

            this.nameCl = nameCl;
            this.idCl = idCl;
            this.roleUs = role;
            this.phoneCl = phone;

            flowLayoutPanel1.Controls.Clear();


            switch (role)
            {
                case "Клиент":
                    btnUpdate.Hide();
                    btnStats.Hide();
                    flowLayoutPanel1.Controls.AddRange(shPrCard().ToArray());
                    break;
                case "Исполнитель":
                    btnaddReq.Hide();
                    btnStats.Hide();
                    btnGetCheq.Hide();
                    flowLayoutPanel1.Controls.AddRange(shPrCardEmp().ToArray());
                    break;
                case "Менеджер":
                    btnaddReq.Hide();
                    btnGetCheq.Hide();
                    flowLayoutPanel1.Controls.AddRange(shPrCardManeg().ToArray());
                    break;
            }
        }

        private List<ProdCard> shPrCard()
        {
            List<ProdCard> prods = new List<ProdCard>();

            db.openConnection();

            NpgsqlCommand getReq = new NpgsqlCommand($"SELECT id, number_series, " +
                $"product, problem, dop_inf, status, " +
                $"start_date, employes_id, price, finish_date, comment" +
                $" FROM products WHERE clients_id = '{idCl}'", db.getConnection());
            NpgsqlDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                ProdCard addReq = new ProdCard(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6).ToString("dd.MM.yyyy"), roleUs,
                    reader.GetInt32(7), reader.GetInt32(8),
                    reader.GetDateTime(9).ToString("dd.MM.yyyy"), reader.GetString(10), idCl);
                prods.Add(addReq);
            }

            db.closeConnection();

            return prods;
        }

        private List<ProdCardEmp> shPrCardEmp()
        {
            List<ProdCardEmp> prods = new List<ProdCardEmp>();

            db.openConnection();

            NpgsqlCommand getReq = new NpgsqlCommand($"SELECT id, number_series, " +
                $"product, problem, dop_inf, status, " +
                $"start_date, clients_id, price, finish_date, comment" +
                $" FROM products WHERE employes_id = '{idCl}'", db.getConnection());
            NpgsqlDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                ProdCardEmp addReq = new ProdCardEmp(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6).ToString("dd.MM.yyyy"), roleUs,
                    reader.GetInt32(7), reader.GetInt32(8),
                    reader.GetDateTime(9).ToString("dd.MM.yyyy"), reader.GetString(10), idCl);
                prods.Add(addReq);
            }

            db.closeConnection();

            return prods;
        }

        private List<ProdCard> shPrCardManeg()
        {
            List<ProdCard> prods = new List<ProdCard>();

            db.openConnection();

            NpgsqlCommand getReq = new NpgsqlCommand($"SELECT id, number_series, " +
                $"product, problem, dop_inf, status, " +
                $"start_date, employes_id, price, finish_date, comment, clients_id" +
                $" FROM products", db.getConnection());
            NpgsqlDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                ProdCard addReq = new ProdCard(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6).ToString("dd.MM.yyyy"), roleUs,
                    reader.GetInt32(7), reader.GetInt32(8),
                    reader.GetDateTime(9).ToString("dd.MM.yyyy"), reader.GetString(10), reader.GetInt32(11));
                prods.Add(addReq);
            }

            db.closeConnection();

            return prods;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats st = new Stats(nameCl, idCl, roleUs, phoneCl);
            st.Show();
        }

        private void btnGetCheq_Click(object sender, EventArgs e)
        {
            int i = 1;

            //Добавление чека
            db.openConnection();

            NpgsqlCommand getCheq = new NpgsqlCommand($"SELECT product, problem, comment, price" +
                $" FROM products WHERE clients_id = {idCl} AND status = 'выполнено'", db.getConnection());
            NpgsqlDataReader reader = getCheq.ExecuteReader();

            //if (!reader.Read())
            //{
            //    MessageBox.Show("Оборудование еще не готово.");
            //}

            while (reader.Read())
            {
                    string prod = reader.GetString(0);
                    string prob = reader.GetString(1);
                    string comm = reader.GetString(2);
                    int price = reader.GetInt32(3);

                    using (StreamWriter sw = new StreamWriter($@"C:\Users\user\Documents\Sharaga\Exam-main\\cheque({i}).txt", false, Encoding.Default))
                    {
                        sw.WriteLine("Чек по ремонту оборудования.");
                        sw.WriteLine("Имя клиента: " + nameCl);
                        sw.WriteLine("Номер клиента: " + phoneCl);
                        sw.WriteLine("Оборудование: " + prod);
                        sw.WriteLine("Проблема: " + prob);
                        sw.WriteLine("Информация о ремонте: " + comm);
                        sw.WriteLine("Цена: " + price);
                    }

                    i++;
            }                  

            db.closeConnection();

            //Удаление заявки
            if (i != 1)
            {
                db.openConnection();

                NpgsqlCommand delReq = new NpgsqlCommand($"DELETE FROM products WHERE clients_id = {idCl} " +
                    "AND status = 'выполнено'", db.getConnection());
                delReq.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Ваш чек отправлен на рабочий стол." + "\n" + "Оцените наш сервис.");
                Qr qrcode = new Qr();
                qrcode.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(shPrCardManeg().ToArray());
        }
       
    }
}
