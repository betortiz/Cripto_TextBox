namespace Cripto_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cripto_Click(object sender, EventArgs e)
        {
            int chave;
            chave = Convert.ToInt32(textChave.Text);

            textDecripto.Text = String.Empty;
            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario + chave;
                textDecripto.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void bt_decripto_Click(object sender, EventArgs e)
        {
            int chave;
            chave = Convert.ToInt32(textChave.Text);

            textDecripto.Text = String.Empty;
            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario - chave;
                textDecripto.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void textChave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dn = MessageBox.Show("Somente n�meros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            textCripto.Text = String.Empty;
            textDecripto.Text = String.Empty;
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplica��o?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }
    }
}