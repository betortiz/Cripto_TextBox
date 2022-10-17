namespace Cripto_TextBox
{
    internal class Mensagem
    {
        internal void Alerta()
        {
            DialogResult r5 = MessageBox.Show("Sua menssagem foi criptografada e copiada para a area de transferencia!!!",
                "Mensagem de aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
        }

        internal void mensagem_validador()
        {
            DialogResult r5 = MessageBox.Show("Digite apenas números de 1 a 9!",
                "Mensagem de aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
        }
        internal void Limpar()
        {
            TextBox textChave = new TextBox();         
            textChave.Text = String.Empty;
            textChave.Focus();

            TextBox textCripto = new TextBox();
            textCripto.Text = String.Empty;

            TextBox textDecripto = new TextBox();
            textDecripto.Text = String.Empty;
        }
    }
}