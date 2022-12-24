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
        int Product_Id;string Product_Name;string Product_Value;string Product_Count;
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
        private void ShowTableproduct(string sql)
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
                DGVProduct.DataSource = table;
            }
            catch { MessageBox.Show("Ошибка в продукции", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            catch { MessageBox.Show("Ошибка в хранилищах", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ShowTablecustom(string sql)
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
                DGVCustomer.DataSource = table;
            }
            catch { MessageBox.Show("Ошибка в заказчиках", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ShowTableorder(string sql)
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
                DGVOrder.DataSource = table;
            }
            catch { MessageBox.Show("Ошибка в заказах", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void DGVproductL()
        {
            string sqlText4 = "select * from product_tb where del_product like 1";
            ShowTableproduct(sqlText4);
            DGVProduct.Columns[0].HeaderText = "ID";
            DGVProduct.Columns[1].HeaderText = "Название";
            DGVProduct.Columns[2].HeaderText = "Количество";
            DGVProduct.Columns[3].HeaderText = "Стоимость";
            DGVProduct.Columns[4].HeaderText = "Пометка на удаление";
            DGVProduct.Columns[0].Visible = false; DGVProduct.Columns[4].Visible = false;
            DGVProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVProduct.AllowUserToAddRows = false;

        }
        private void DGVhouseL()
        {
            string sqlText3 = "select * from warehouse_tb";
            ShowTablehouse(sqlText3);
            DGVhouse.Columns[0].HeaderText = "ID";
            DGVhouse.Columns[1].HeaderText = "Номер";
            DGVhouse.Columns[2].HeaderText = "Название";
            DGVhouse.Columns[3].HeaderText = "Пометка на удаление";
            DGVhouse.Columns[0].Visible = false; DGVhouse.Columns[1].Visible = false;
            DGVhouse.Columns[3].Visible = false; DGVhouse.Columns[2].Width = 300;
            DGVhouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVhouse.AllowUserToAddRows = false;

        }
        private void DGVcustomL()
        {
            string sqlText2 = "select * from customer_tb";
            ShowTablecustom(sqlText2);
            DGVCustomer.Columns[0].HeaderText = "ID";
            DGVCustomer.Columns[1].HeaderText = "Номер";
            DGVCustomer.Columns[2].HeaderText = "Название заказчика";
            DGVCustomer.Columns[3].HeaderText = "Пометка на удаление";
            DGVCustomer.Columns[0].Visible = false; DGVCustomer.Columns[1].Visible = false;
            DGVCustomer.Columns[3].Visible = false; DGVCustomer.Columns[2].Width = 300;
            DGVCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCustomer.AllowUserToAddRows = false;

        }
        private void DGVorderL()
        {
            string sqlText1 = "select * from order_tb where del_order like 1";
            ShowTableorder(sqlText1);
            DGVOrder.Columns[0].HeaderText = "ID";
            DGVOrder.Columns[1].HeaderText = "Номер склада";
            DGVOrder.Columns[2].HeaderText = "Название заказа";
            DGVOrder.Columns[3].HeaderText = "Дата отправления";
            DGVOrder.Columns[4].HeaderText = "Количество";
            DGVOrder.Columns[5].HeaderText = "Стоимость";
            DGVOrder.Columns[6].HeaderText = "Пометка на удаление";
            DGVOrder.Columns[0].Visible = false; DGVOrder.Columns[6].Visible = false;
            DGVOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVOrder.AllowUserToAddRows = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DGVhouseL(); DGVcustomL(); DGVorderL(); DGVproductL();
        }

        private void searchCustomer_TextChanged(object sender, EventArgs e)
        {
            (DGVCustomer.DataSource as DataTable).DefaultView.RowFilter = $"customer_name like '%{searchCustomer.Text}%'";
        }

        private void searchOrder_TextChanged(object sender, EventArgs e)
        {
            (DGVOrder.DataSource as DataTable).DefaultView.RowFilter = $"productname like '%{searchOrder.Text}%'";
        }

        private void ProductAdd_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Добавить запись?", "Добавление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlText = "insert into product_tb(productname,Value,Cost) values('" + nameofproduct.Text + "','" + valueofproduct.Text + "','" + countofproduct.Text + "')";
                using (SqlConnection con = new SqlConnection(Class.DataBase.connStr))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(sqlText, con);
                    int kol = cmd1.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DGVproductL();
                } }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Запись не была добавлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Producfind()
        {
            try
            {
                Product_Id = (int)DGVProduct.CurrentRow.Cells[0].Value;
                Product_Name = DGVProduct.CurrentRow.Cells[1].Value.ToString();
                Product_Value = DGVProduct.CurrentRow.Cells[2].Value.ToString();
                Product_Count = DGVProduct.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProductEdit_MouseClick(object sender, MouseEventArgs e)
        {
            if (Product_Id != 0)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Изменить запись?", "Изменение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string sqlText = $"update product_tb set productname = '{nameofproduct.Text.ToString()}', Value ={int.Parse(valueofproduct.Text.ToString())}, Cost ={int.Parse(countofproduct.Text.ToString())} where id_product like {Product_Id} and del_product like '1'";
                        using (SqlConnection con = new SqlConnection(Class.DataBase.connStr))
                        {
                            con.Open();
                            SqlCommand cmd1 = new SqlCommand(sqlText, con);
                            int kol = cmd1.ExecuteNonQuery();
                            MessageBox.Show("Запись изменена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            DGVproductL();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                     MessageBox.Show("Запись не была изменена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } }
            else
            {
                MessageBox.Show("Выберите запись!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void DGVProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Producfind();
        }

        private void DGVProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producfind();
            nameofproduct.Text = Product_Name.ToString();
            valueofproduct.Text = Product_Value.ToString();
            countofproduct.Text = Product_Count.ToString();
        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {
            (DGVProduct.DataSource as DataTable).DefaultView.RowFilter = $"productname like '%{searchProduct.Text}%'";
        }

        private void ProductDel_MouseClick(object sender, MouseEventArgs e)
        {
            if (Product_Id != 0)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string sqlText = $"update product_tb set del_product = 0 where id_product like {Product_Id}";
                        using (SqlConnection con = new SqlConnection(Class.DataBase.connStr))
                        {
                            con.Open();
                            SqlCommand cmd1 = new SqlCommand(sqlText, con);
                            int kol = cmd1.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            DGVproductL();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Запись не была удалена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    } 
