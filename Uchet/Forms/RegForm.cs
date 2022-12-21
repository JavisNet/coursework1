using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Uchet.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void b_exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void b_back_MouseClick(object sender, MouseEventArgs e)
        {
            Forms.AuthForm back = new Forms.AuthForm();
            back.Show(); this.Hide();
        }

        private void b_reg_MouseClick(object sender, MouseEventArgs e)
        {
            var loginUser = t_login.Text;
            var passwordUser = t_password.Text;
            var nameUser = t_name.Text;
            var surnameUser = t_surname.Text;
            var patronymicUser = t_patronymic.Text;

            string query = $"insert into staff_tb(name,surname,patronymic,Login,Password) values ('{nameUser}','{surnameUser}','{patronymicUser}','{loginUser}','{passwordUser}')";

            using (SqlConnection connect = new SqlConnection(Class.DataBase.connStr))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация успешна!", "Регистрация выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forms.AuthForm auth = new Forms.AuthForm();
                    auth.Show();this.Hide();
                }
                else
                {
                    MessageBox.Show("Вы неправильно ввели значения при регистрации!", "Регистрация не выполнена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
