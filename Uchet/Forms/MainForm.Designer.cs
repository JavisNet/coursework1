namespace Uchet.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_logo = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.DGVhouse = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.searchSklad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.DGVOrder = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.searchOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.nameofproduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.valueofproduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.countofproduct = new System.Windows.Forms.TextBox();
            this.orderReport = new System.Windows.Forms.PictureBox();
            this.orderDel = new System.Windows.Forms.PictureBox();
            this.orderEdit = new System.Windows.Forms.PictureBox();
            this.orderAdd = new System.Windows.Forms.PictureBox();
            this.ProductDel = new System.Windows.Forms.PictureBox();
            this.ProductEdit = new System.Windows.Forms.PictureBox();
            this.ProductAdd = new System.Windows.Forms.PictureBox();
            this.warehouse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.l_logo);
            this.panel1.Location = new System.Drawing.Point(-1, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 63);
            this.panel1.TabIndex = 7;
            // 
            // l_logo
            // 
            this.l_logo.AutoSize = true;
            this.l_logo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_logo.ForeColor = System.Drawing.Color.Black;
            this.l_logo.Location = new System.Drawing.Point(447, 21);
            this.l_logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_logo.Name = "l_logo";
            this.l_logo.Size = new System.Drawing.Size(497, 27);
            this.l_logo.TabIndex = 5;
            this.l_logo.Text = "ООО \"Алтайская продовольственная компания\"";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(1216, 793);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(103, 36);
            this.exit.TabIndex = 8;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // DGVhouse
            // 
            this.DGVhouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhouse.Location = new System.Drawing.Point(16, 95);
            this.DGVhouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVhouse.Name = "DGVhouse";
            this.DGVhouse.RowHeadersWidth = 51;
            this.DGVhouse.Size = new System.Drawing.Size(359, 178);
            this.DGVhouse.TabIndex = 9;
            this.DGVhouse.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVhouse_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Хранилища";
            // 
            // searchSklad
            // 
            this.searchSklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSklad.Location = new System.Drawing.Point(221, 279);
            this.searchSklad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchSklad.Name = "searchSklad";
            this.searchSklad.Size = new System.Drawing.Size(152, 30);
            this.searchSklad.TabIndex = 13;
            this.searchSklad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск хранилища";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(381, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Поиск заказчика";
            // 
            // searchCustomer
            // 
            this.searchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCustomer.Location = new System.Drawing.Point(571, 278);
            this.searchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Size = new System.Drawing.Size(176, 30);
            this.searchCustomer.TabIndex = 18;
            this.searchCustomer.TextChanged += new System.EventHandler(this.searchCustomer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(381, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "Заказчик";
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Location = new System.Drawing.Point(383, 95);
            this.DGVCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.Size = new System.Drawing.Size(365, 178);
            this.DGVCustomer.TabIndex = 16;
            this.DGVCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVCustomer_CellMouseClick);
            // 
            // DGVOrder
            // 
            this.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrder.Location = new System.Drawing.Point(21, 400);
            this.DGVOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.RowHeadersWidth = 51;
            this.DGVOrder.Size = new System.Drawing.Size(800, 428);
            this.DGVOrder.TabIndex = 20;
            this.DGVOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrder_CellDoubleClick);
            this.DGVOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVOrder_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Поиск заказа";
            // 
            // searchOrder
            // 
            this.searchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchOrder.Location = new System.Drawing.Point(553, 361);
            this.searchOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.Size = new System.Drawing.Size(268, 30);
            this.searchOrder.TabIndex = 21;
            this.searchOrder.TextChanged += new System.EventHandler(this.searchOrder_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 38);
            this.label6.TabIndex = 23;
            this.label6.Text = "Заказ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(768, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Поиск продукции";
            // 
            // searchProduct
            // 
            this.searchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchProduct.Location = new System.Drawing.Point(972, 278);
            this.searchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(161, 30);
            this.searchProduct.TabIndex = 26;
            this.searchProduct.TextChanged += new System.EventHandler(this.searchProduct_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(768, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 38);
            this.label8.TabIndex = 25;
            this.label8.Text = "Продукция";
            // 
            // DGVProduct
            // 
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Location = new System.Drawing.Point(769, 95);
            this.DGVProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.RowHeadersWidth = 51;
            this.DGVProduct.Size = new System.Drawing.Size(365, 178);
            this.DGVProduct.TabIndex = 24;
            this.DGVProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduct_CellDoubleClick);
            this.DGVProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVProduct_CellMouseClick);
            // 
            // nameofproduct
            // 
            this.nameofproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameofproduct.Location = new System.Drawing.Point(1147, 126);
            this.nameofproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameofproduct.Name = "nameofproduct";
            this.nameofproduct.Size = new System.Drawing.Size(161, 30);
            this.nameofproduct.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1141, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "Название";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1141, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 28);
            this.label10.TabIndex = 31;
            this.label10.Text = "Количество";
            // 
            // valueofproduct
            // 
            this.valueofproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueofproduct.Location = new System.Drawing.Point(1147, 194);
            this.valueofproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueofproduct.Name = "valueofproduct";
            this.valueofproduct.Size = new System.Drawing.Size(161, 30);
            this.valueofproduct.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1141, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 28);
            this.label11.TabIndex = 33;
            this.label11.Text = "Стоимость";
            // 
            // countofproduct
            // 
            this.countofproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countofproduct.Location = new System.Drawing.Point(1147, 276);
            this.countofproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countofproduct.Name = "countofproduct";
            this.countofproduct.Size = new System.Drawing.Size(161, 30);
            this.countofproduct.TabIndex = 32;
            // 
            // orderReport
            // 
            this.orderReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderReport.Image = global::Uchet.Properties.Resources.report;
            this.orderReport.Location = new System.Drawing.Point(1094, 653);
            this.orderReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderReport.Name = "orderReport";
            this.orderReport.Size = new System.Drawing.Size(40, 37);
            this.orderReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderReport.TabIndex = 40;
            this.orderReport.TabStop = false;
            this.orderReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderReport_MouseClick);
            // 
            // orderDel
            // 
            this.orderDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderDel.Image = global::Uchet.Properties.Resources.del;
            this.orderDel.Location = new System.Drawing.Point(1093, 557);
            this.orderDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderDel.Name = "orderDel";
            this.orderDel.Size = new System.Drawing.Size(40, 37);
            this.orderDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderDel.TabIndex = 39;
            this.orderDel.TabStop = false;
            this.orderDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderDel_MouseClick);
            // 
            // orderEdit
            // 
            this.orderEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderEdit.Image = global::Uchet.Properties.Resources.edit;
            this.orderEdit.Location = new System.Drawing.Point(1094, 477);
            this.orderEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderEdit.Name = "orderEdit";
            this.orderEdit.Size = new System.Drawing.Size(40, 37);
            this.orderEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderEdit.TabIndex = 38;
            this.orderEdit.TabStop = false;
            this.orderEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderEdit_MouseClick);
            // 
            // orderAdd
            // 
            this.orderAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderAdd.Image = global::Uchet.Properties.Resources.add;
            this.orderAdd.Location = new System.Drawing.Point(1093, 411);
            this.orderAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderAdd.Name = "orderAdd";
            this.orderAdd.Size = new System.Drawing.Size(40, 37);
            this.orderAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderAdd.TabIndex = 37;
            this.orderAdd.TabStop = false;
            this.orderAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderAdd_MouseClick);
            // 
            // ProductDel
            // 
            this.ProductDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductDel.Image = global::Uchet.Properties.Resources.del;
            this.ProductDel.Location = new System.Drawing.Point(1253, 314);
            this.ProductDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductDel.Name = "ProductDel";
            this.ProductDel.Size = new System.Drawing.Size(40, 37);
            this.ProductDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductDel.TabIndex = 36;
            this.ProductDel.TabStop = false;
            this.ProductDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductDel_MouseClick);
            // 
            // ProductEdit
            // 
            this.ProductEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductEdit.Image = global::Uchet.Properties.Resources.edit;
            this.ProductEdit.Location = new System.Drawing.Point(1205, 314);
            this.ProductEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductEdit.Name = "ProductEdit";
            this.ProductEdit.Size = new System.Drawing.Size(40, 37);
            this.ProductEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductEdit.TabIndex = 35;
            this.ProductEdit.TabStop = false;
            this.ProductEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductEdit_MouseClick);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductAdd.Image = global::Uchet.Properties.Resources.add;
            this.ProductAdd.Location = new System.Drawing.Point(1157, 314);
            this.ProductAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(40, 37);
            this.ProductAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductAdd.TabIndex = 34;
            this.ProductAdd.TabStop = false;
            this.ProductAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductAdd_MouseClick);
            // 
            // warehouse
            // 
            this.warehouse.Enabled = false;
            this.warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warehouse.Location = new System.Drawing.Point(832, 411);
            this.warehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.warehouse.Name = "warehouse";
            this.warehouse.Size = new System.Drawing.Size(176, 30);
            this.warehouse.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(832, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 28);
            this.label12.TabIndex = 42;
            this.label12.Text = "Хранилище";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(832, 590);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 28);
            this.label13.TabIndex = 44;
            this.label13.Text = "Заказчик";
            // 
            // customer
            // 
            this.customer.Enabled = false;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customer.Location = new System.Drawing.Point(832, 621);
            this.customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(176, 30);
            this.customer.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(832, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 28);
            this.label14.TabIndex = 46;
            this.label14.Text = "Заказ";
            // 
            // delivery
            // 
            this.delivery.Enabled = false;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delivery.Location = new System.Drawing.Point(832, 477);
            this.delivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(176, 30);
            this.delivery.TabIndex = 45;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(834, 557);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(175, 28);
            this.date.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(828, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 28);
            this.label15.TabIndex = 48;
            this.label15.Text = "Дата отправления";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(832, 743);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 28);
            this.label16.TabIndex = 52;
            this.label16.Text = "Стоимость";
            // 
            // count
            // 
            this.count.Enabled = false;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(838, 774);
            this.count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(161, 30);
            this.count.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(832, 662);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 28);
            this.label17.TabIndex = 50;
            this.label17.Text = "Количество";
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.value.Location = new System.Drawing.Point(838, 694);
            this.value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(169, 35);
            this.value.TabIndex = 53;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1333, 842);
            this.ControlBox = false;
            this.Controls.Add(this.value);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.warehouse);
            this.Controls.Add(this.orderReport);
            this.Controls.Add(this.orderDel);
            this.Controls.Add(this.orderEdit);
            this.Controls.Add(this.orderAdd);
            this.Controls.Add(this.ProductDel);
            this.Controls.Add(this.ProductEdit);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.countofproduct);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.valueofproduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nameofproduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGVProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchOrder);
            this.Controls.Add(this.DGVOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchSklad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVhouse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_logo;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView DGVhouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchSklad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.DataGridView DGVOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGVProduct;
        private System.Windows.Forms.TextBox nameofproduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox valueofproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox countofproduct;
        private System.Windows.Forms.PictureBox ProductAdd;
        private System.Windows.Forms.PictureBox ProductEdit;
        private System.Windows.Forms.PictureBox ProductDel;
        private System.Windows.Forms.PictureBox orderDel;
        private System.Windows.Forms.PictureBox orderEdit;
        private System.Windows.Forms.PictureBox orderAdd;
        private System.Windows.Forms.PictureBox orderReport;
        private System.Windows.Forms.TextBox warehouse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox delivery;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown value;
    }
}