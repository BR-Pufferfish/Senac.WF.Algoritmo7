namespace WF.Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Usu�rio")
                txt_username.Text = string.Empty;
        }
        // string.Empty � o mesmo que " "
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == string.Empty)
                txt_username.Text = "Usu�rio";
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
            var sair = MessageBox.Show("Quer realmente sair? Dados n�o salvos ser�o perdidos.",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
