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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (DGVhouse.DataSource as DataTable).DefaultView.RowFilter = $"NameWarehouse like '%{searchSklad.Text}%'";
        }
        private void ShowTablehouse(string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Class.DataBase.connStr);
                conn.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, conn);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                DGVhouse.DataSource = table;
            }
            catch { MessageBox.Show("Ошибка в заказах", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void DGVhouseL()
        {
            string sqlText3 = "select * from delivery_tb";
            ShowTablehouse(sqlText3);
            DGVhouse.Columns[0].HeaderText = "ID";
            DGVhouse.Columns[1].HeaderText = "Номер";
            DGVhouse.Columns[2].HeaderText = "Название";
            DGVhouse.Columns[3].HeaderText = "Пометка на удаление";
            DGVhouse.Columns[0].Visible = false; DGVhouse.Columns[1].Visible = false;
            DGVhouse.Columns[3].Visible = false;
            DGVhouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVhouse.AllowUserToAddRows = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DGVhouseL();
        }
    }
}
