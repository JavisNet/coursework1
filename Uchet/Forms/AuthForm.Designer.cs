namespace Uchet.Forms
{
    partial class AuthForm
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
            this.l_login = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.t_login = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.l_logo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_auth = new System.Windows.Forms.Label();
            this.b_log = new System.Windows.Forms.Button();
            this.c_password = new System.Windows.Forms.CheckBox();
            this.b_register = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_login.Location = new System.Drawing.Point(300, 108);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(76, 29);
            this.l_login.TabIndex = 0;
            this.l_login.Text = "Логин";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(447, 351);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(103, 36);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_password.Location = new System.Drawing.Point(301, 203);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(69, 23);
            this.l_password.TabIndex = 2;
            this.l_password.Text = "Пароль";
            // 
            // t_login
            // 
            this.t_login.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_login.Location = new System.Drawing.Point(161, 148);
            this.t_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(239, 34);
            this.t_login.TabIndex = 3;
            // 
            // t_password
            // 
            this.t_password.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_password.Location = new System.Drawing.Point(161, 235);
            this.t_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(239, 34);
            this.t_password.TabIndex = 4;
            this.t_password.UseSystemPasswordChar = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.l_logo);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 53);
            this.panel1.TabIndex = 6;
            // 
            // l_auth
            // 
            this.l_auth.AutoSize = true;
            this.l_auth.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_auth.Location = new System.Drawing.Point(188, 55);
            this.l_auth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_auth.Name = "l_auth";
            this.l_auth.Size = new System.Drawing.Size(143, 29);
            this.l_auth.TabIndex = 7;
            this.l_auth.Text = "Авторизация";
            // 
            // b_log
            // 
            this.b_log.BackColor = System.Drawing.Color.White;
            this.b_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_log.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_log.Location = new System.Drawing.Point(233, 284);
            this.b_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_log.Name = "b_log";
            this.b_log.Size = new System.Drawing.Size(100, 36);
            this.b_log.TabIndex = 8;
            this.b_log.Text = "Войти";
            this.b_log.UseVisualStyleBackColor = false;
            this.b_log.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_open_MouseClick);
            // 
            // c_password
            // 
            this.c_password.AutoSize = true;
            this.c_password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_password.Location = new System.Drawing.Point(161, 202);
            this.c_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(105, 27);
            this.c_password.TabIndex = 9;
            this.c_password.Text = "Показать ";
            this.c_password.UseVisualStyleBackColor = true;
            this.c_password.CheckedChanged += new System.EventHandler(this.c_password_CheckedChanged);
            // 
            // b_register
            // 
            this.b_register.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.b_register.AutoSize = true;
            this.b_register.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.b_register.Location = new System.Drawing.Point(212, 361);
            this.b_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b_register.Name = "b_register";
            this.b_register.Size = new System.Drawing.Size(108, 23);
            this.b_register.TabIndex = 10;
            this.b_register.TabStop = true;
            this.b_register.Text = "Регистрация";
            this.b_register.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_register_MouseClick);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(564, 400);
            this.ControlBox = false;
            this.Controls.Add(this.b_register);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.c_password);
            this.Controls.Add(this.b_log);
            this.Controls.Add(this.l_auth);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_login);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_login;
        private System.Windows.Forms.Label l_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_auth;
        private System.Windows.Forms.Button b_log;
        private System.Windows.Forms.CheckBox c_password;
        private System.Windows.Forms.LinkLabel b_register;
    }
}