namespace Cripto_TextBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textCripto = new System.Windows.Forms.TextBox();
            this.textDecripto = new System.Windows.Forms.TextBox();
            this.bt_cripto = new System.Windows.Forms.Button();
            this.bt_decripto = new System.Windows.Forms.Button();
            this.textChave = new System.Windows.Forms.TextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCripto
            // 
            resources.ApplyResources(this.textCripto, "textCripto");
            this.textCripto.Name = "textCripto";
            this.textCripto.TextChanged += new System.EventHandler(this.textCripto_TextChanged);
            this.textCripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCripto_KeyPress);
            // 
            // textDecripto
            // 
            resources.ApplyResources(this.textDecripto, "textDecripto");
            this.textDecripto.Name = "textDecripto";
            this.textDecripto.ReadOnly = true;
            // 
            // bt_cripto
            // 
            resources.ApplyResources(this.bt_cripto, "bt_cripto");
            this.bt_cripto.Name = "bt_cripto";
            this.bt_cripto.UseVisualStyleBackColor = true;
            this.bt_cripto.Click += new System.EventHandler(this.bt_cripto_Click);
            // 
            // bt_decripto
            // 
            resources.ApplyResources(this.bt_decripto, "bt_decripto");
            this.bt_decripto.Name = "bt_decripto";
            this.bt_decripto.UseVisualStyleBackColor = true;
            this.bt_decripto.Click += new System.EventHandler(this.bt_decripto_Click);
            // 
            // textChave
            // 
            resources.ApplyResources(this.textChave, "textChave");
            this.textChave.Name = "textChave";
            this.textChave.Tag = "vagal";
            this.textChave.TextChanged += new System.EventHandler(this.textChave_TextChanged_1);
            this.textChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textChave_KeyPress);
            // 
            // bt_limpar
            // 
            resources.ApplyResources(this.bt_limpar, "bt_limpar");
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bt_sair
            // 
            resources.ApplyResources(this.bt_sair, "bt_sair");
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.textChave);
            this.Controls.Add(this.bt_decripto);
            this.Controls.Add(this.bt_cripto);
            this.Controls.Add(this.textDecripto);
            this.Controls.Add(this.textCripto);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textCripto;
        private TextBox textDecripto;
        private Button bt_cripto;
        private Button bt_decripto;
        private TextBox textChave;
        private Button bt_limpar;
        private Label label1;
        private Button bt_sair;
    }
}