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
    public partial class EmpEnter : Form
    {
        string nameUs;
        string phone, pass, role;
        int idUs, idPrd;       

        Database db = new Database();       

        public EmpEnter()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            phone = tbPhEmp.Text;
            pass = tbPasEmp.Text;
            role = "Исполнитель";

            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkUs = new NpgsqlCommand($"SELECT name_surname, id FROM employes WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkUs.ExecuteReader();

                    if (reader.Read())
                    {
                        nameUs = reader.GetString(0);
                        idUs = reader.GetInt32(1);

                        this.Hide();
                        Menu formMenu = new Menu(nameUs, idUs, role, phone);
                        formMenu.Show();
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }
        }

        private void btnMg_Click(object sender, EventArgs e)
        {
            phone = tbPhMg.Text;
            pass = tbPasMg.Text;
            role = "Менеджер";

            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkUs = new NpgsqlCommand($"SELECT name_surname, id FROM manager WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkUs.ExecuteReader();

                    if (reader.Read())
                    {
                        nameUs = reader.GetString(0);
                        idUs = reader.GetInt32(1);

                        this.Hide();
                        Menu formMenu = new Menu(nameUs, idUs, role, phone);
                        formMenu.Show();
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            phone = tbPhAd.Text;
            pass = tbPasAd.Text;
            role = "Админ";

            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkUs = new NpgsqlCommand($"SELECT name_surname, id FROM admin WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkUs.ExecuteReader();

                    if (reader.Read())
                    {
                        nameUs = reader.GetString(0);
                        idUs = reader.GetInt32(1);

                        this.Hide();
                        Menu formMenu = new Menu(nameUs, idUs, role, phone);
                        formMenu.Show();
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }
        }
    }
}
