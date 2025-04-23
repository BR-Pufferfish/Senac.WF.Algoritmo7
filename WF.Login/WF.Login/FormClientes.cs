using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Login
{
    public partial class form_Cliente : Form
    {
        public form_Cliente()
        {
            InitializeComponent();
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_Produtos().Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_Cliente().Show();
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_Pedidos().Show();
        }

        private void btn_Pagamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_Pagamento().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_Home().Show();
        }
    }
}
