using System.Diagnostics;

namespace WF.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Usuário")
                txt_username.Text = string.Empty;
        }
        // string.Empty é o mesmo que " "
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == string.Empty)
                txt_username.Text = "Usuário";
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Senha")
                txt_password.Text = string.Empty;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == string.Empty)
                txt_password.Text = "Senha";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Quer realmente sair? Dados não salvos serão perdidos.",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sair = MessageBox.Show("Quer realmente sair? Dados não salvos serão perdidos.",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lnk_fitgirl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://fitgirl-repacks.site/popular-repacks/");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPrincipal = new form_Home();
            formPrincipal.Show();
        }
    }
}
