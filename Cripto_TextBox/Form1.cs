namespace Cripto_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void message_validator()
        {
            DialogResult r5 = MessageBox.Show("Digite apenas números de 1 a 9!",
                 "Mensagem de aviso", MessageBoxButtons.OK,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);

        }

        //public void messageAlert()
        //{
        //    DialogResult r5 = MessageBox.Show("Sua menssagem foi criptografada e copiada para a area de transferencia!!!",
        //                "Mensagem de aviso", MessageBoxButtons.OK,
        //                MessageBoxIcon.Question,
        //                MessageBoxDefaultButton.Button1);
        //}

        private void bt_cripto_Click(object sender, EventArgs e)
        {
            if (textChave.Text == string.Empty)
            {
                textChave.Text = "1";
            }

            int chave = Convert.ToInt32(textChave.Text);

            textDecripto.Text = String.Empty;
            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario + chave;
                textDecripto.Text += char.ConvertFromUtf32(txtCifrado);
                Clipboard.SetText(textDecripto.Text);
            }
            //messageAlert();
        }

        private void bt_decripto_Click(object sender, EventArgs e)
        {
            // ultimo ajuste
            if (textChave.Text == string.Empty)
            {
                textChave.Text = "1";
            }

            int chave = Convert.ToInt32(textChave.Text);

            textDecripto.Text = String.Empty;
            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario - chave;
                textDecripto.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void textChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                DialogResult dn = MessageBox.Show("Digite apenas número de 1 a 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dn = MessageBox.Show("Somente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            textChave.Text = String.Empty;
            textCripto.Text = String.Empty;
            textDecripto.Text = String.Empty;
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void textCripto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bt_cripto_Click(sender, e);
            }
        }

        private void textChave_TextChanged_1(object sender, EventArgs e)
        {
            if (textChave.Text.Length > 1)
            {
                textChave.Text = String.Empty;
                message_validator();
            }
        }

        private void textCripto_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}