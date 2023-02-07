
namespace AppComponetes
{
    partial class frnComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstListagem = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.cbbLista = new System.Windows.Forms.ComboBox();
            this.rbdMasculino = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(102, 138);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstListagem
            // 
            this.lstListagem.FormattingEnabled = true;
            this.lstListagem.Location = new System.Drawing.Point(102, 180);
            this.lstListagem.Name = "lstListagem";
            this.lstListagem.Size = new System.Drawing.Size(120, 95);
            this.lstListagem.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(102, 378);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(102, 298);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(49, 17);
            this.ckbLivro.TabIndex = 5;
            this.ckbLivro.Text = "Livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // pctImagem
            // 
            this.pctImagem.Location = new System.Drawing.Point(315, 180);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(100, 84);
            this.pctImagem.TabIndex = 6;
            this.pctImagem.TabStop = false;
            this.pctImagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbbLista
            // 
            this.cbbLista.FormattingEnabled = true;
            this.cbbLista.Location = new System.Drawing.Point(315, 122);
            this.cbbLista.Name = "cbbLista";
            this.cbbLista.Size = new System.Drawing.Size(121, 21);
            this.cbbLista.TabIndex = 7;
            // 
            // rbdMasculino
            // 
            this.rbdMasculino.AutoSize = true;
            this.rbdMasculino.Location = new System.Drawing.Point(102, 339);
            this.rbdMasculino.Name = "rbdMasculino";
            this.rbdMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbdMasculino.TabIndex = 8;
            this.rbdMasculino.TabStop = true;
            this.rbdMasculino.Text = "Masculino";
            this.rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(99, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Insira o seu nome";
            // 
            // frnComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 481);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.rbdMasculino);
            this.Controls.Add(this.cbbLista);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.ckbLivro);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstListagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label1);
            this.Name = "frnComponentes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstListagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.ComboBox cbbLista;
        private System.Windows.Forms.RadioButton rbdMasculino;
        private System.Windows.Forms.Label lblNome;
    }
}

