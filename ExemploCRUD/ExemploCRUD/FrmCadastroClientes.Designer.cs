namespace ExemploCRUD
{
    partial class FrmCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroClientes));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbEndereco = new System.Windows.Forms.TextBox();
            this.TbCidade = new System.Windows.Forms.TextBox();
            this.TbBairro = new System.Windows.Forms.TextBox();
            this.TbUf = new System.Windows.Forms.TextBox();
            this.TbCep = new System.Windows.Forms.MaskedTextBox();
            this.TbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.Location = new System.Drawing.Point(9, 10);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(30, 32);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(44, 10);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(30, 32);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(78, 10);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(30, 32);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.Location = new System.Drawing.Point(112, 10);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(30, 32);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.Location = new System.Drawing.Point(285, 12);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(30, 32);
            this.BtnPesquisar.TabIndex = 4;
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TbId
            // 
            this.TbId.Enabled = false;
            this.TbId.Location = new System.Drawing.Point(10, 63);
            this.TbId.Margin = new System.Windows.Forms.Padding(2);
            this.TbId.Name = "TbId";
            this.TbId.ReadOnly = true;
            this.TbId.Size = new System.Drawing.Size(74, 20);
            this.TbId.TabIndex = 5;
            // 
            // TbNome
            // 
            this.TbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbNome.Location = new System.Drawing.Point(96, 63);
            this.TbNome.Margin = new System.Windows.Forms.Padding(2);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(219, 20);
            this.TbNome.TabIndex = 6;
            // 
            // TbEndereco
            // 
            this.TbEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbEndereco.Location = new System.Drawing.Point(8, 103);
            this.TbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.TbEndereco.Name = "TbEndereco";
            this.TbEndereco.Size = new System.Drawing.Size(308, 20);
            this.TbEndereco.TabIndex = 7;
            // 
            // TbCidade
            // 
            this.TbCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbCidade.Location = new System.Drawing.Point(8, 142);
            this.TbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.TbCidade.Name = "TbCidade";
            this.TbCidade.Size = new System.Drawing.Size(114, 20);
            this.TbCidade.TabIndex = 8;
            // 
            // TbBairro
            // 
            this.TbBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbBairro.Location = new System.Drawing.Point(124, 142);
            this.TbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.TbBairro.Name = "TbBairro";
            this.TbBairro.Size = new System.Drawing.Size(96, 20);
            this.TbBairro.TabIndex = 9;
            // 
            // TbUf
            // 
            this.TbUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbUf.Location = new System.Drawing.Point(224, 142);
            this.TbUf.Margin = new System.Windows.Forms.Padding(2);
            this.TbUf.Name = "TbUf";
            this.TbUf.Size = new System.Drawing.Size(92, 20);
            this.TbUf.TabIndex = 10;
            // 
            // TbCep
            // 
            this.TbCep.Location = new System.Drawing.Point(8, 185);
            this.TbCep.Margin = new System.Windows.Forms.Padding(2);
            this.TbCep.Mask = "00000-999";
            this.TbCep.Name = "TbCep";
            this.TbCep.Size = new System.Drawing.Size(95, 20);
            this.TbCep.TabIndex = 11;
            // 
            // TbTelefone
            // 
            this.TbTelefone.Location = new System.Drawing.Point(112, 185);
            this.TbTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.TbTelefone.Mask = "(99) 0000-0000";
            this.TbTelefone.Name = "TbTelefone";
            this.TbTelefone.Size = new System.Drawing.Size(108, 20);
            this.TbTelefone.TabIndex = 12;
            // 
            // TbNascimento
            // 
            this.TbNascimento.Location = new System.Drawing.Point(224, 185);
            this.TbNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.TbNascimento.Mask = "00/00/0000";
            this.TbNascimento.Name = "TbNascimento";
            this.TbNascimento.Size = new System.Drawing.Size(92, 20);
            this.TbNascimento.TabIndex = 13;
            this.TbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TbPesquisar
            // 
            this.TbPesquisar.Location = new System.Drawing.Point(205, 24);
            this.TbPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.TbPesquisar.Name = "TbPesquisar";
            this.TbPesquisar.Size = new System.Drawing.Size(76, 20);
            this.TbPesquisar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Endereço";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nascimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Busca por ID";
            // 
            // FrmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 213);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbPesquisar);
            this.Controls.Add(this.TbNascimento);
            this.Controls.Add(this.TbTelefone);
            this.Controls.Add(this.TbCep);
            this.Controls.Add(this.TbUf);
            this.Controls.Add(this.TbBairro);
            this.Controls.Add(this.TbCidade);
            this.Controls.Add(this.TbEndereco);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadastroClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbEndereco;
        private System.Windows.Forms.TextBox TbCidade;
        private System.Windows.Forms.TextBox TbBairro;
        private System.Windows.Forms.TextBox TbUf;
        private System.Windows.Forms.MaskedTextBox TbCep;
        private System.Windows.Forms.MaskedTextBox TbTelefone;
        private System.Windows.Forms.MaskedTextBox TbNascimento;
        private System.Windows.Forms.TextBox TbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

