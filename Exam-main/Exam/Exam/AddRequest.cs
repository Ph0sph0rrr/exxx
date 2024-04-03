using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class AddRequest : Form
    {
        string prod, problem, dopInf, phone;
        int idUs, idEmp, price;
        int idProd;
        string nameUs, role;
        Database db = new Database();

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddRequest_Load(object sender, EventArgs e)
        {

        }

        DateOnly dateStart = DateOnly.FromDateTime(DateTime.Now);
        DateOnly dateFinish;

        public AddRequest(string nameUs, int idUs, string role, string phone)
        {
            InitializeComponent();

            this.nameUs = nameUs;
            this.role = role;
            this.idUs = idUs;
            this.phone = phone;
        }
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            prod = tbMyProd.Text;
            problem = cbProblem.Text;

            if (tbDopInf.Text == null)
            {
                dopInf = " "; 
            }
            else
            {
                dopInf = tbDopInf.Text;
            }
            

            //Высчет цены
            if (problem == "Дисплей" || problem == "Батарея")
            {
                price = 800;
                dateFinish = dateStart.AddDays(2);
            } 
            else if (problem == "Камера")
            {
                price = 1000;
                dateFinish = dateStart.AddDays(4);
            }
            else if (problem == "Динамик")
            {
                price = 600;
                dateFinish = dateStart.AddDays(2);
            }
            else if (problem == "Материнская плата")
            {
                price = 1500;
                dateFinish = dateStart.AddDays(7);
            }
            else if (problem == "Капитальный ремонт")
            {
                price = 3000;
                dateFinish = dateStart.AddDays(21);
            }
            //

            Random random = new Random();

            int series = random.Next(1000, 9999);

            idEmp = getClient();

            if ((prod != "") && (problem != ""))
            {
                if (dateStart != null)
                {
                    ////добавляем заявку
                    db.openConnection();
                    NpgsqlCommand addProd = new NpgsqlCommand($"INSERT INTO products(number_series, product, start_date, " +
                        $"problem, dop_inf, status, clients_id, employes_id, price, finish_date, comment) " +
                        $"VALUES('{series}', '{prod}', '{dateStart}', '{problem}', '{dopInf}', " +
                        $"'в ожидании', {idUs}, {idEmp}, {price}, '{dateFinish}', '')", db.getConnection());
                    addProd.ExecuteNonQuery();
                    db.closeConnection();
                    /////получаем id заявки
                    db.openConnection();
                    NpgsqlCommand getId = new NpgsqlCommand($"SELECT id FROM products WHERE number_series = '{series}'", db.getConnection());
                    NpgsqlDataReader reader = getId.ExecuteReader();
                    if (reader.Read())
                    {
                        idProd = reader.GetInt32(0);
                        db.closeConnection();
                    }

                    MessageBox.Show("Заявка отправлена!");
                    this.Hide();
                    Menu formMenu = new Menu(nameUs, idUs, role, phone);
                    formMenu.Show();
                }
                else { MessageBox.Show("Ошибка в дате"); }
            }
            else { MessageBox.Show("Заполните все поля"); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formMenu = new Menu(nameUs, idUs, role, phone);
            formMenu.Show();
        }

        private int getClient()
        {
            db.openConnection();
            NpgsqlCommand getId = new NpgsqlCommand("SELECT id FROM employes", db.getConnection());
            NpgsqlDataReader reader = getId.ExecuteReader();
            List<int> idList = new List<int>();
            while (reader.Read())
            {
                int idEmps = reader.GetInt32(0);
                idList.Add(idEmps);
            }

            db.closeConnection();

            Random rand = new Random();
            int randomIndex = rand.Next(0, idList.Count);
            int randomId = idList[randomIndex];

            return randomId;
        }
    }
}
