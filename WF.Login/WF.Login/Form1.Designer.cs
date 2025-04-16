﻿namespace WF.Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Exit = new PictureBox();
            Minimize = new PictureBox();
            LoginGroup = new GroupBox();
            lnk_recovery = new LinkLabel();
            btn_login = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            LoginGroup.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-110, -73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Firebrick;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(770, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(30, 30);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 2;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.Teal;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(739, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(30, 30);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 3;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // LoginGroup
            // 
            LoginGroup.BackColor = Color.Black;
            LoginGroup.CausesValidation = false;
            LoginGroup.Controls.Add(lnk_recovery);
            LoginGroup.Controls.Add(btn_login);
            LoginGroup.Controls.Add(txt_password);
            LoginGroup.Controls.Add(txt_username);
            LoginGroup.FlatStyle = FlatStyle.Flat;
            LoginGroup.Font = new Font("Segoe UI", 16F);
            LoginGroup.ForeColor = SystemColors.ButtonFace;
            LoginGroup.Location = new Point(338, 40);
            LoginGroup.Name = "LoginGroup";
            LoginGroup.Size = new Size(450, 340);
            LoginGroup.TabIndex = 4;
            LoginGroup.TabStop = false;
            LoginGroup.Text = "Login";
            // 
            // lnk_recovery
            // 
            lnk_recovery.AutoSize = true;
            lnk_recovery.Font = new Font("Segoe UI", 10F);
            lnk_recovery.Location = new Point(293, 185);
            lnk_recovery.Name = "lnk_recovery";
            lnk_recovery.Size = new Size(139, 23);
            lnk_recovery.TabIndex = 0;
            lnk_recovery.TabStop = true;
            lnk_recovery.Text = "Recuperar Senha";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSeaGreen;
            btn_login.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ActiveCaptionText;
            btn_login.Location = new Point(142, 238);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(177, 61);
            btn_login.TabIndex = 3;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Black;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = SystemColors.Info;
            txt_password.Location = new Point(42, 148);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(390, 34);
            txt_password.TabIndex = 2;
            txt_password.Text = "Senha";
            txt_password.Enter += txt_password_Enter;
            txt_password.Leave += txt_password_Leave;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.Black;
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.ForeColor = SystemColors.Info;
            txt_username.Location = new Point(42, 96);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(390, 34);
            txt_username.TabIndex = 1;
            txt_username.Text = "Usuário";
            txt_username.Enter += txt_username_Enter;
            txt_username.Leave += txt_username_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginGroup);
            Controls.Add(Minimize);
            Controls.Add(Exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            LoginGroup.ResumeLayout(false);
            LoginGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Exit;
        private PictureBox Minimize;
        private GroupBox LoginGroup;
        private TextBox txt_username;
        private PictureBox pictureBox1;
        private Button btn_login;
        private TextBox txt_password;
        private LinkLabel lnk_recovery;
    }
}
