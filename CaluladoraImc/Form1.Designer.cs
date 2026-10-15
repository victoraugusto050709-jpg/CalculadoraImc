namespace CaluladoraImc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculadora1 = new System.Windows.Forms.Label();
            this.txtPeso1 = new System.Windows.Forms.Label();
            this.txtaltura1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.lbtResultado = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculadora1
            // 
            this.Calculadora1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Calculadora1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora1.Location = new System.Drawing.Point(0, 0);
            this.Calculadora1.Name = "Calculadora1";
            this.Calculadora1.Size = new System.Drawing.Size(840, 48);
            this.Calculadora1.TabIndex = 5;
            this.Calculadora1.Text = "Calculadora IMC";
            this.Calculadora1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeso1
            // 
            this.txtPeso1.AutoSize = true;
            this.txtPeso1.Location = new System.Drawing.Point(56, 96);
            this.txtPeso1.Name = "txtPeso1";
            this.txtPeso1.Size = new System.Drawing.Size(70, 19);
            this.txtPeso1.TabIndex = 7;
            this.txtPeso1.Text = "Peso (Kg)";
            // 
            // txtaltura1
            // 
            this.txtaltura1.AutoSize = true;
            this.txtaltura1.Location = new System.Drawing.Point(56, 192);
            this.txtaltura1.Name = "txtaltura1";
            this.txtaltura1.Size = new System.Drawing.Size(75, 19);
            this.txtaltura1.TabIndex = 8;
            this.txtaltura1.Text = "Altura (M)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(560, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 40);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "CALCULAR IMC";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(472, 232);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(320, 27);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.TextChanged += new System.EventHandler(this.lblResultado_TextChanged);
            // 
            // lbtResultado
            // 
            this.lbtResultado.AutoSize = true;
            this.lbtResultado.Location = new System.Drawing.Point(480, 200);
            this.lbtResultado.Name = "lbtResultado";
            this.lbtResultado.Size = new System.Drawing.Size(74, 19);
            this.lbtResultado.TabIndex = 11;
            this.lbtResultado.Text = "Seu IMC é";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(56, 120);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(136, 27);
            this.txtPeso.TabIndex = 15;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(56, 224);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(136, 27);
            this.txtAltura.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 658);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtaltura1);
            this.Controls.Add(this.txtPeso1);
            this.Controls.Add(this.Calculadora1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Calculadora1;
        private System.Windows.Forms.Label txtPeso1;
        private System.Windows.Forms.Label txtaltura1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox lblResultado;
        private System.Windows.Forms.Label lbtResultado;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

