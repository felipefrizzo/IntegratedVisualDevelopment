namespace ExampleForm01
{
    partial class FormCalc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValor01 = new System.Windows.Forms.TextBox();
            this.tbValor02 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 01";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 02";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operação";
            // 
            // tbValor01
            // 
            this.tbValor01.Location = new System.Drawing.Point(12, 29);
            this.tbValor01.Name = "tbValor01";
            this.tbValor01.Size = new System.Drawing.Size(121, 20);
            this.tbValor01.TabIndex = 3;
            this.tbValor01.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbValor01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor01_KeyPress);
            // 
            // tbValor02
            // 
            this.tbValor02.Location = new System.Drawing.Point(12, 80);
            this.tbValor02.Name = "tbValor02";
            this.tbValor02.Size = new System.Drawing.Size(121, 20);
            this.tbValor02.TabIndex = 4;
            this.tbValor02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor02_KeyPress);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(206, 126);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 5;
            this.labelResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbOperacao
            // 
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            "Selecione uma operação",
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.cbOperacao.Location = new System.Drawing.Point(12, 131);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(121, 21);
            this.cbOperacao.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(197, 29);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(197, 77);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 175);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbOperacao);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.tbValor02);
            this.Controls.Add(this.tbValor01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCalc";
            this.RightToLeftLayout = true;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValor01;
        private System.Windows.Forms.TextBox tbValor02;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox cbOperacao;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClean;
    }
}

