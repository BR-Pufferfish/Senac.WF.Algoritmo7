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
    public partial class form_Pedidos : Form
    {
        public form_Pedidos()
        {
            InitializeComponent();
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_Produtos().Show();
        }
    }
}
