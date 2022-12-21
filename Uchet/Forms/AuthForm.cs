using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void c_password_CheckedChanged(object sender, EventArgs e)
        {
            if (c_password.Checked == true)
            {
                t_password.UseSystemPasswordChar = false;
            }
            else if (c_password.Checked == false)
            {
                t_password.UseSystemPasswordChar = true;
            }
        }

        private void b_register_MouseClick(object sender, MouseEventArgs e)
        {
            Forms.RegForm reg = new Forms.RegForm();
            reg.Show(); this.Hide();
        }
        private void b_open_MouseClick(object sender, MouseEventArgs e)
        {
            var loginUser = t_login.Text;
            var passwordUser = t_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string select = $"select id_staff,Login,Password from staff_tb where Login = '{loginUser}' and Password = '{passwordUser}'";
            using (SqlConnection connect = new SqlConnection(Class.DataBase.connStr))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(select, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!","Вход выполнен",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Forms.MainForm open = new Forms.MainForm();
                    open.Show();this.Hide();
                }
                else
                {
                    MessageBox.Show("Вы неправильно ввели логин или пароль!", "Вход не выполнен", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
  

        private void AuthForm_Load(object sender, EventArgs e)
        {
            t_login.MaxLength = 40;
            t_password.MaxLength = 40;
        }
    }
}
