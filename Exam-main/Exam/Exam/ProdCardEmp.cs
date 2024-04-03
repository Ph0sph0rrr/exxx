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

namespace Exam
{
    public partial class ProdCardEmp : UserControl
    {
        Database db = new Database();
        string roleUs { get; set; }
        string serie { get; set; }
        string phoneCl { get; set; }
        string phoneEmp { get; set; }
        string ioCl { get; set; }
        string ioEmp { get; set; }
        string dateStart { get; set; }
        string dateFinish { get; set; }
        string prod { get; set; }
        string problem { get; set; }
        string dop_inf { get; set; }
        string status { get; set; }
        int price { get; set; }
        string comment { get; set; }
        int idEmp { get; set; }
        int idCl { get; set; }
        int i = 0;
        public ProdCardEmp(int idPrd, string serie, string prod, string problem,
                string dop_inf, string status,
                string dateStart, string roleUs, int idCl, int price,
                string dateFinish, string comment, int idEmp)
        {

            InitializeComponent();

            this.idEmp = idEmp;
            getEmpInf(idEmp);
            this.idCl = idCl;
            getClInf(idCl);

            this.roleUs = roleUs;
            this.serie = serie;
            this.prod = prod;
            this.problem = problem;
            this.dop_inf = dop_inf;

            this.dateStart = dateStart;
            this.ioCl = ioCl;
            this.phoneCl = phoneCl;
            this.status = status;

            this.dateFinish = dateFinish;
            this.ioEmp = ioEmp;
            this.phoneEmp = phoneEmp;
            this.price = price;
            this.comment = comment;

            Serie.Text = "Серия: " + serie;
            Product.Text = "Оборудование: " + prod;
            Probl.Text = "Проблема: " + problem;
            tbxPdInf.Text = dop_inf;

            DateStart.Text = "Дата создания: " + dateStart;
            IoCl.Text = "Имя клиента: " + "\n" + ioCl;
            PhCl.Text = "Номер клиента: " + "\n" + phoneCl;
            cmbxSta.Text = status;

            tbDateFinish.Text = dateFinish;
            IoEmp.Text = "Имя исполнителя: " + "\n" + ioEmp;
            PhEmp.Text = "Номер исполнителя: " + "\n" + phoneEmp;
            tbPrice.Text = Convert.ToString(price);
            tbComment.Text = comment;

            switch (roleUs)
            {
                case "Клиент":
                    cmbxSta.Enabled = false;
                    tbPrice.Enabled = false;
                    tbComment.Enabled = false;
                    tbDateFinish.Enabled = false;
                    label1.Hide();
                    textBox1.Hide();
                    button1.Hide();
                    chgDate.Hide();

                    if ((roleUs == "Клиент") && (cmbxSta.Text == "выполнено"))
                    {
                        MessageBox.Show("Ваше оборудование починилось!" + "\n" +
                               "Оцените нас перейдя по этому QR коду.");
                    }

                    break;
                case "Исполнитель":
                    tbDateFinish.Enabled = false;
                    tbxPdInf.Enabled = false;
                    label1.Hide();
                    textBox1.Hide();
                    button1.Hide();
                    chgDate.Hide();
                    break;
                case "Менеджер":
                    cmbxSta.Enabled = false;
                    tbxPdInf.Enabled = false;
                    tbPrice.Enabled = false;
                    tbComment.Enabled = false;
                    break;
            }


        }    

        private void getEmpInf(int idEmp)
        {
            string getIoEmp = null;
            string getPhEmp = null;
            db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT name_surname, phone FROM employes WHERE id = {idEmp}", db.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                getIoEmp = reader.GetString(0);
                getPhEmp = reader.GetString(1);
            }

            db.closeConnection();
            this.ioEmp = getIoEmp;
            this.phoneEmp = getPhEmp;
        }

        private void getClInf(int idCl)
        {
            string getIoCl = null;
            string getPhCl = null;
            db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT name_surname, phone FROM clients WHERE id = {idCl}", db.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                getIoCl = reader.GetString(0);
                getPhCl = reader.GetString(1);
            }

            db.closeConnection();
            this.ioCl = getIoCl;
            this.phoneCl = getPhCl;
        }

        private void chgDate_Click_1(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateDatFin = new NpgsqlCommand($"UPDATE products SET finish_date = '{tbDateFinish.Text}' WHERE number_series = '{serie}'", db.getConnection());
            updateDatFin.ExecuteNonQuery();

            db.closeConnection();

            MessageBox.Show("Дата окончания изменена");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<int> idsEmps = new List<int>();
            db.openConnection();
            NpgsqlCommand getIds = new NpgsqlCommand("SELECT id FROM employes", db.getConnection());
            NpgsqlDataReader reader = getIds.ExecuteReader();
            while (reader.Read())
            {
                int idEmp = reader.GetInt32(0);
                idsEmps.Add(idEmp);
            }
            db.closeConnection();

            int idChg = 0;
            if ((textBox1.Text != "") && (textBox1.Text != "0"))
            {
                idChg = Convert.ToInt32(textBox1.Text);
            }

            if ((idChg != 0) && (idChg != idEmp) && (idsEmps.Contains(idChg)))
            {
                db.openConnection();

                NpgsqlCommand updateSt = new NpgsqlCommand($"UPDATE products SET employes_id = {idChg} WHERE number_series = '{serie}'", db.getConnection());
                updateSt.ExecuteNonQuery();

                db.closeConnection();

                MessageBox.Show("Исполнитель изменен");
            }
            else
            {
                MessageBox.Show("Введите id другого исполнителя");
            }
        }

        private void textBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void tbComment_TextChanged_1(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateSt = new NpgsqlCommand($"UPDATE products SET comment = '{tbComment.Text}' WHERE number_series = '{serie}'", db.getConnection());
            updateSt.ExecuteNonQuery();

            db.closeConnection();
        }

        private void tbPrice_TextChanged_1(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateSt = new NpgsqlCommand($"UPDATE products SET price = '{tbPrice.Text}' WHERE number_series = '{serie}'", db.getConnection());
            updateSt.ExecuteNonQuery();

            db.closeConnection();
        }

        private void cmbxSta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateSt = new NpgsqlCommand($"UPDATE products SET status = '{cmbxSta.SelectedItem}' WHERE number_series = '{serie}'", db.getConnection());
            updateSt.ExecuteNonQuery();

            db.closeConnection();
        }

        private void tbxPdInf_TextChanged_1(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateDopInf = new NpgsqlCommand($"UPDATE products SET dop_inf = '{tbxPdInf.Text}' WHERE number_series = '{serie}'", db.getConnection());
            updateDopInf.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
