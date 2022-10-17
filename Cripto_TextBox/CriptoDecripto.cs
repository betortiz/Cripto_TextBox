using System;

namespace Cripto_TextBox
{
    internal class CriptoDecripto
    {      
        internal void Cripto(TextBox textDecripto)
        {
            TextBox textCripto = new TextBox();
            textCripto.Text = "";
            textCripto.Visible = true;

            TextBox textChave = new TextBox();
            textChave.Text = "";

            TextBox texDecripto = new TextBox();
            textDecripto.Text = "";

            //string textCripto = "";
            //string textDecripto = "";
            //string textChave = "";
            int chave = Convert.ToInt32(textChave.Text);

            for (int i = 0; i < textCripto.Text.Length; i++)
            {
                int txtUsuario = (int)textCripto.Text[i];
                int txtCifrado = txtUsuario + chave;
                textDecripto.Text += char.ConvertFromUtf32(txtCifrado);
                Clipboard.SetText(textDecripto.Text);
            }
        }

        internal void Decripto()
        {
            string textCripto = "";
            string textDecripto = "";
            int chave = 0;

            for (int i = 0; i < textCripto.Length; i++)
            {
                int txtUsuario = (int)textCripto[i];
                int txtCifrado = txtUsuario - chave;
                textDecripto += char.ConvertFromUtf32(txtCifrado);
            }
        }
    }
}