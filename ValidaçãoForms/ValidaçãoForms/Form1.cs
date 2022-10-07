namespace ValidaçãoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                ErrorProvider.SetError(textBox1, "Seu nome é requerido");
                return;
            } else
            {
                ErrorProvider.SetError(textBox1, string.Empty);
            }
        }
    }
}