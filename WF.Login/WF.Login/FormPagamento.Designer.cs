namespace WF.Login
{
    partial class form_Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Pagamento));
            panel1 = new Panel();
            gpb_Info = new GroupBox();
            lbl_Version = new Label();
            lbl_developed = new Label();
            gpb_Buttons = new GroupBox();
            button6 = new Button();
            btn_Produtos = new Button();
            btn_Pagamentos = new Button();
            btn_Clientes = new Button();
            btn_Pedidos = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lbl_AppTitle = new Label();
            panel1.SuspendLayout();
            gpb_Info.SuspendLayout();
            gpb_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(gpb_Info);
            panel1.Controls.Add(gpb_Buttons);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 450);
            panel1.TabIndex = 0;
            // 
            // gpb_Info
            // 
            gpb_Info.Controls.Add(lbl_Version);
            gpb_Info.Controls.Add(lbl_developed);
            gpb_Info.Location = new Point(35, 367);
            gpb_Info.Name = "gpb_Info";
            gpb_Info.Size = new Size(140, 71);
            gpb_Info.TabIndex = 2;
            gpb_Info.TabStop = false;
            gpb_Info.Text = "Dev. Info";
            // 
            // lbl_Version
            // 
            lbl_Version.AutoSize = true;
            lbl_Version.Location = new Point(6, 43);
            lbl_Version.Name = "lbl_Version";
            lbl_Version.Size = new Size(99, 20);
            lbl_Version.TabIndex = 3;
            lbl_Version.Text = "Ver. Alpha 1.0";
            // 
            // lbl_developed
            // 
            lbl_developed.AutoSize = true;
            lbl_developed.Location = new Point(6, 23);
            lbl_developed.Name = "lbl_developed";
            lbl_developed.Size = new Size(101, 20);
            lbl_developed.TabIndex = 2;
            lbl_developed.Text = "Dev. by Puffer";
            // 
            // gpb_Buttons
            // 
            gpb_Buttons.Controls.Add(button6);
            gpb_Buttons.Controls.Add(btn_Produtos);
            gpb_Buttons.Controls.Add(btn_Pagamentos);
            gpb_Buttons.Controls.Add(btn_Clientes);
            gpb_Buttons.Controls.Add(btn_Pedidos);
            gpb_Buttons.Location = new Point(3, 103);
            gpb_Buttons.Name = "gpb_Buttons";
            gpb_Buttons.Size = new Size(211, 261);
            gpb_Buttons.TabIndex = 2;
            gpb_Buttons.TabStop = false;
            gpb_Buttons.Text = "Interactive Buttons";
            // 
            // button6
            // 
            button6.BackColor = Color.DodgerBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Malgun Gothic", 12F);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(6, 210);
            button6.Name = "button6";
            button6.Size = new Size(199, 40);
            button6.TabIndex = 5;
            button6.Text = "Relatório";
            button6.UseVisualStyleBackColor = false;
            // 
            // btn_Produtos
            // 
            btn_Produtos.BackColor = Color.DodgerBlue;
            btn_Produtos.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btn_Produtos.FlatStyle = FlatStyle.Flat;
            btn_Produtos.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Produtos.Image = (Image)resources.GetObject("btn_Produtos.Image");
            btn_Produtos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Produtos.Location = new Point(6, 26);
            btn_Produtos.Name = "btn_Produtos";
            btn_Produtos.Size = new Size(199, 40);
            btn_Produtos.TabIndex = 1;
            btn_Produtos.Text = "Produtos";
            btn_Produtos.UseVisualStyleBackColor = false;
            // 
            // btn_Pagamentos
            // 
            btn_Pagamentos.BackColor = Color.Cyan;
            btn_Pagamentos.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_Pagamentos.FlatStyle = FlatStyle.Flat;
            btn_Pagamentos.Font = new Font("Malgun Gothic", 12F);
            btn_Pagamentos.Image = (Image)resources.GetObject("btn_Pagamentos.Image");
            btn_Pagamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Pagamentos.Location = new Point(6, 164);
            btn_Pagamentos.Name = "btn_Pagamentos";
            btn_Pagamentos.Size = new Size(199, 40);
            btn_Pagamentos.TabIndex = 4;
            btn_Pagamentos.Text = "Pagamentos";
            btn_Pagamentos.UseVisualStyleBackColor = false;
            // 
            // btn_Clientes
            // 
            btn_Clientes.BackColor = Color.DodgerBlue;
            btn_Clientes.FlatStyle = FlatStyle.Flat;
            btn_Clientes.Font = new Font("Malgun Gothic", 12F);
            btn_Clientes.Image = (Image)resources.GetObject("btn_Clientes.Image");
            btn_Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.Location = new Point(6, 72);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Size = new Size(199, 40);
            btn_Clientes.TabIndex = 2;
            btn_Clientes.Text = "Clientes";
            btn_Clientes.UseVisualStyleBackColor = false;
            // 
            // btn_Pedidos
            // 
            btn_Pedidos.BackColor = Color.DodgerBlue;
            btn_Pedidos.FlatStyle = FlatStyle.Flat;
            btn_Pedidos.Font = new Font("Malgun Gothic", 12F);
            btn_Pedidos.Image = (Image)resources.GetObject("btn_Pedidos.Image");
            btn_Pedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Pedidos.Location = new Point(6, 118);
            btn_Pedidos.Name = "btn_Pedidos";
            btn_Pedidos.Size = new Size(199, 40);
            btn_Pedidos.TabIndex = 3;
            btn_Pedidos.Text = "Pedidos";
            btn_Pedidos.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(lbl_AppTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 74);
            panel2.TabIndex = 1;
            // 
            // lbl_AppTitle
            // 
            lbl_AppTitle.AutoSize = true;
            lbl_AppTitle.Font = new Font("Malgun Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AppTitle.Location = new Point(190, 15);
            lbl_AppTitle.Name = "lbl_AppTitle";
            lbl_AppTitle.Size = new Size(210, 46);
            lbl_AppTitle.TabIndex = 0;
            lbl_AppTitle.Text = "Pagamentos";
            // 
            // form_Pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Pagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            gpb_Info.ResumeLayout(false);
            gpb_Info.PerformLayout();
            gpb_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private GroupBox gpb_Buttons;
        private Button button6;
        private Button btn_Produtos;
        private Button btn_Pagamentos;
        private Button btn_Clientes;
        private Button btn_Pedidos;
        private Label lbl_AppTitle;
        private GroupBox gpb_Info;
        private Label lbl_Version;
        private Label lbl_developed;
    }
}