using Npgsql;
using System.Text.RegularExpressions;

namespace Exam
{
    public partial class Registration : Form
    {
        string phoneCl, passCl;
        string nameCl, checkRes;
        string role = "Клиент";
        int idCl, idPrd;
        Database db = new Database();

        public Registration()
        {
            InitializeComponent();
        }

        private void regCl_Click_1(object sender, EventArgs e)
        {
            nameCl = tBxIoRg.Text;
            phoneCl = tBxPhRg.Text;
            passCl = tBxPasRg.Text;

            string res = checkCl(phoneCl);
            if (nameCl != null)
            {

                if (!Regex.IsMatch(tBxPasRg.Text, @"^[a-zA-Z0-9._]+(@|#|%|<|>)$")) // проверка yf pyfrb
                {
                    MessageBox.Show("Введите дополнительные знаки");
                }



                if (phoneCl.Length == 11)
                {
                    if (passCl.Length >= 5)
                    {
                        if (res == "Нету")
                        {
                            db.openConnection();
                            NpgsqlCommand addCl = new NpgsqlCommand($"INSERT INTO clients (name_surname, phone, password) VALUES ('{nameCl}', '{phoneCl}', '{passCl}')", db.getConnection());
                            addCl.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы.");
                            db.closeConnection();                           

                            db.openConnection();
                            NpgsqlCommand getId = new NpgsqlCommand($"SELECT id FROM clients WHERE phone = '{phoneCl}'", db.getConnection());
                            NpgsqlDataReader reader = getId.ExecuteReader();
                            if (reader.Read())
                            {
                                idCl = reader.GetInt32(0);
                            }

                            db.closeConnection();

                            this.Hide();                           
                            Menu formMenu = new Menu(nameCl, idCl, role, phoneCl);
                            formMenu.Show();
                        }
                        else if (res == "Есть")
                        {
                            db.closeConnection();
                            MessageBox.Show("Такой пользователь уже зарегистрирован");
                        }
                    }
                  
                   
                    else { MessageBox.Show("Введите пароль больше 5 символов"); }




                }


                else { MessageBox.Show("Введите номер равный 11 символов"); }
            }
            else { MessageBox.Show("Введите ваше имя"); }
        }              

        public string checkCl(string phoneCl)
        {
            db.openConnection();

            NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname FROM clients WHERE phone = '{phoneCl}'", db.getConnection());

            NpgsqlDataReader reader = checkCl.ExecuteReader();

            if (reader.Read())
            {
                db.closeConnection();
                return checkRes = "Есть";
            }
            else
            {
                db.closeConnection();
                return checkRes = "Нету";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Enter ent = new Enter();
            this.Hide();
            ent.Show();
        }
    }
}