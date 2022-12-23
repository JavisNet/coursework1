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
            this.l_login = new System.Windows.Forms.Label();
            this.searchSklad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.l_logo);
            this.panel1.Location = new System.Drawing.Point(-1, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 51);
            this.panel1.TabIndex = 7;
            // 
            // l_logo
            // 
            this.l_logo.AutoSize = true;
            this.l_logo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_logo.ForeColor = System.Drawing.Color.Black;
            this.l_logo.Location = new System.Drawing.Point(229, 17);
            this.l_logo.Name = "l_logo";
            this.l_logo.Size = new System.Drawing.Size(358, 21);
            this.l_logo.TabIndex = 5;
            this.l_logo.Text = "ООО \"Алтайская продовольственная компания\"";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(712, 410);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(77, 29);
            this.exit.TabIndex = 8;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // DGVhouse
            // 
            this.DGVhouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhouse.Location = new System.Drawing.Point(12, 77);
            this.DGVhouse.Name = "DGVhouse";
            this.DGVhouse.Size = new System.Drawing.Size(319, 145);
            this.DGVhouse.TabIndex = 9;
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_login.Location = new System.Drawing.Point(11, 45);
            this.l_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(130, 29);
            this.l_login.TabIndex = 11;
            this.l_login.Text = "Хранилища";
            // 
            // searchSklad
            // 
            this.searchSklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSklad.Location = new System.Drawing.Point(166, 227);
            this.searchSklad.Margin = new System.Windows.Forms.Padding(2);
            this.searchSklad.Name = "searchSklad";
            this.searchSklad.Size = new System.Drawing.Size(165, 26);
            this.searchSklad.TabIndex = 13;
            this.searchSklad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск хранилища";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchSklad);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.DGVhouse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_logo;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView DGVhouse;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.TextBox searchSklad;
        private System.Windows.Forms.Label label1;
    }
}