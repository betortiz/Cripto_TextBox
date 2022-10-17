using System;

namespace Cripto_TextBox
{
    internal class CriptoDecripto
    {      
        internal void Cripto(object sender, EventArgs e)
        {
            TextBox textCripto = new TextBox();
            textCripto.Text = "";

            TextBox textChave = new TextBox();
            textChave.Text = "";

            TextBox texDecripto = new TextBox();
            texDecripto.Text = "";

            int chave = Convert.ToInt32(textChave.Text);

            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario + chave;
                texDecripto.Text += char.ConvertFromUtf32(txtCifrado);
                Clipboard.SetText(texDecripto.Text);
            }
        }

        internal void Decripto(object sender, EventArgs e)
        {
            TextBox textCripto = new TextBox();
            textCripto.Text = "";
            textCripto.Visible = true;

            TextBox textChave = new TextBox();
            textChave.Text = "";

            TextBox texDecripto = new TextBox();
            texDecripto.Text = "";
            int chave = Convert.ToInt32(textChave.Text);

            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario - chave;
                texDecripto.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }
    }
}