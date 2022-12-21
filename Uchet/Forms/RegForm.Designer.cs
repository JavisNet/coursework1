namespace Uchet.Forms
{
    partial class RegForm
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
            this.b_back = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.l_reg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_logo = new System.Windows.Forms.Label();
            this.l_login = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.Label();
            this.t_login = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_surname = new System.Windows.Forms.TextBox();
            this.t_patronymic = new System.Windows.Forms.TextBox();
            this.b_reg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_back
            // 
            this.b_back.BackColor = System.Drawing.Color.White;
            this.b_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_back.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_back.Location = new System.Drawing.Point(-2, 384);
            this.b_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(100, 41);
            this.b_back.TabIndex = 0;
            this.b_back.Text = "Назад";
            this.b_back.UseVisualStyleBackColor = false;
            this.b_back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_back_MouseClick);
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.White;
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_exit.Location = new System.Drawing.Point(457, 384);
            this.b_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(100, 41);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "Выйти";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_exit_MouseClick);
            // 
            // l_reg
            // 
            this.l_reg.AutoSize = true;
            this.l_reg.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_reg.Location = new System.Drawing.Point(191, 52);
            this.l_reg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_reg.Name = "l_reg";
            this.l_reg.Size = new System.Drawing.Size(138, 29);
            this.l_reg.TabIndex = 9;
            this.l_reg.Text = "Регистрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.l_logo);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 53);
            this.panel1.TabIndex = 8;
            // 
            // l_logo
            // 
            this.l_logo.AutoSize = true;
            this.l_logo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_logo.ForeColor = System.Drawing.Color.Black;
            this.l_logo.Location = new System.Drawing.Point(64, 12);
            this.l_logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_logo.Name = "l_logo";
            this.l_logo.Size = new System.Drawing.Size(358, 21);
            this.l_logo.TabIndex = 5;
            this.l_logo.Text = "ООО \"Алтайская продовольственная компания\"";
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_login.Location = new System.Drawing.Point(261, 102);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(58, 23);
            this.l_login.TabIndex = 10;
            this.l_login.Text = "Логин";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_password.Location = new System.Drawing.Point(260, 159);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(69, 23);
            this.l_password.TabIndex = 11;
            this.l_password.Text = "Пароль";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(10, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 23);
            this.name.TabIndex = 12;
            this.name.Text = "Имя";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(9, 159);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(78, 23);
            this.surname.TabIndex = 13;
            this.surname.Text = "Фамилия";
            // 
            // patronymic
            // 
            this.patronymic.AutoSize = true;
            this.patronymic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic.Location = new System.Drawing.Point(10, 230);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(81, 23);
            this.patronymic.TabIndex = 14;
            this.patronymic.Text = "Отчество";
            // 
            // t_login
            // 
            this.t_login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_login.Location = new System.Drawing.Point(264, 129);
            this.t_login.Margin = new System.Windows.Forms.Padding(4);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(100, 26);
            this.t_login.TabIndex = 15;
            // 
            // t_password
            // 
            this.t_password.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_password.Location = new System.Drawing.Point(264, 186);
            this.t_password.Margin = new System.Windows.Forms.Padding(4);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(100, 26);
            this.t_password.TabIndex = 16;
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_name.Location = new System.Drawing.Point(14, 125);
            this.t_name.Margin = new System.Windows.Forms.Padding(4);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(100, 26);
            this.t_name.TabIndex = 17;
            // 
            // t_surname
            // 
            this.t_surname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_surname.Location = new System.Drawing.Point(13, 186);
            this.t_surname.Margin = new System.Windows.Forms.Padding(4);
            this.t_surname.Name = "t_surname";
            this.t_surname.Size = new System.Drawing.Size(100, 26);
            this.t_surname.TabIndex = 18;
            // 
            // t_patronymic
            // 
            this.t_patronymic.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_patronymic.Location = new System.Drawing.Point(14, 257);
            this.t_patronymic.Margin = new System.Windows.Forms.Padding(4);
            this.t_patronymic.Name = "t_patronymic";
            this.t_patronymic.Size = new System.Drawing.Size(100, 26);
            this.t_patronymic.TabIndex = 19;
            // 
            // b_reg
            // 
            this.b_reg.BackColor = System.Drawing.Color.White;
            this.b_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_reg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_reg.Location = new System.Drawing.Point(173, 323);
            this.b_reg.Margin = new System.Windows.Forms.Padding(4);
            this.b_reg.Name = "b_reg";
            this.b_reg.Size = new System.Drawing.Size(211, 36);
            this.b_reg.TabIndex = 21;
            this.b_reg.Text = "Зарегистрировать";
            this.b_reg.UseVisualStyleBackColor = false;
            this.b_reg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_reg_MouseClick);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(570, 427);
            this.ControlBox = false;
            this.Controls.Add(this.b_reg);
            this.Controls.Add(this.t_patronymic);
            this.Controls.Add(this.t_surname);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_login);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.l_reg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label l_reg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_logo;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label patronymic;
        private System.Windows.Forms.TextBox t_login;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_surname;
        private System.Windows.Forms.TextBox t_patronymic;
        private System.Windows.Forms.Button b_reg;
    }
}