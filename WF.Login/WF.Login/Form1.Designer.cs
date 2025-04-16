namespace WF.Login
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
            Exit = new PictureBox();
            Minimize = new PictureBox();
            LoginGroup = new GroupBox();
            lnk_recovery = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            LoginGroup.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 450);
            panel1.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.Location = new Point(766, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(30, 30);
            Exit.TabIndex = 2;
            Exit.TabStop = false;
            // 
            // Minimize
            // 
            Minimize.Location = new Point(730, 4);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(30, 30);
            Minimize.TabIndex = 3;
            Minimize.TabStop = false;
            // 
            // LoginGroup
            // 
            LoginGroup.BackColor = Color.Black;
            LoginGroup.Controls.Add(lnk_recovery);
            LoginGroup.Controls.Add(btn_login);
            LoginGroup.Controls.Add(txt_password);
            LoginGroup.Controls.Add(txt_username);
            LoginGroup.Location = new Point(335, 50);
            LoginGroup.Name = "LoginGroup";
            LoginGroup.Size = new Size(450, 340);
            LoginGroup.TabIndex = 4;
            LoginGroup.TabStop = false;
            LoginGroup.Text = "groupBox1";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.Black;
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.ForeColor = SystemColors.Info;
            txt_username.Location = new Point(42, 96);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(390, 30);
            txt_username.TabIndex = 2;
            txt_username.Text = "Usuário";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Black;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = SystemColors.Info;
            txt_password.Location = new Point(42, 148);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(390, 30);
            txt_password.TabIndex = 3;
            txt_password.Text = "Senha";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.HotTrack;
            btn_login.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(142, 238);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(177, 61);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lnk_recovery
            // 
            lnk_recovery.AutoSize = true;
            lnk_recovery.Location = new Point(356, 181);
            lnk_recovery.Name = "lnk_recovery";
            lnk_recovery.Size = new Size(76, 20);
            lnk_recovery.TabIndex = 5;
            lnk_recovery.TabStop = true;
            lnk_recovery.Text = "linkLabel1";
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
            panel1.ResumeLayout(false);
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
