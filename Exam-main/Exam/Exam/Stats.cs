using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Exam
{
    public partial class Stats : Form
    {
        Database db = new Database();
        string roleUs, oftProb;
        string nameCl, phoneCl;
        int doneReqs, idCl;
        public Stats(string nameCl, int idCl, string roleUs, string phoneCl)
        {
            this.nameCl = nameCl;
            this.idCl = idCl;
            this.roleUs = roleUs;
            this.phoneCl = phoneCl;

            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(getPrReq().ToArray());

            lbDoneReq.Text = "Кол-во выполненых заказов: " + countReqs();
            lbMedTime.Text = "Среднее время выполнения: " + countTime() + " дней";
            lbOftProb.Text = "Частая неисправность: " + countProb();
        }

        private string countProb()
        {
            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT problem, COUNT(*) AS frequency FROM products GROUP BY problem ORDER BY frequency DESC LIMIT 1", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();
            while (reader.Read()) 
            {
                oftProb = reader.GetString(0);
            }

            db.closeConnection();

            return oftProb;
        }

        private int countTime()
        {
            List<int> times = new List<int>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT start_date, finish_date FROM products", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                DateTime dateSt = reader.GetDateTime(0);
                DateOnly dateStOnly = DateOnly.FromDateTime(dateSt);
                DateTime dateFn = reader.GetDateTime(1);
                DateOnly dateFnOnly = DateOnly.FromDateTime(dateFn);
                var findat = dateFnOnly.DayNumber - dateStOnly.DayNumber;
                times.Add(Convert.ToInt32(findat));
            }

            db.closeConnection();
            int countTm = times.Count();
            int sumTm = times.Sum();
            int medTm = (sumTm / countTm);
            return medTm;
        }

        private int countReqs()
        {
            List<int> reqs = new List<int>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT id FROM products WHERE status = 'выполнено'", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read()) 
            {
                reqs.Add(reader.GetInt32(0));
            }

            db.closeConnection();

            return reqs.Count();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formMenu = new Menu(nameCl, idCl, roleUs, phoneCl);
            formMenu.Show();
        }

        private List<ProdCard> getPrReq()
        {
            List<ProdCard> prods = new List<ProdCard>();

            db.openConnection();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT id, number_series, product, problem, " +
                "dop_inf, status, start_date, employes_id, price, " +
                "finish_date, comment, clients_id FROM products ORDER BY status ASC", db.getConnection());
            NpgsqlDataReader reader = comm.ExecuteReader();
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
    }
}
