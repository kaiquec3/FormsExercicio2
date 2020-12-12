namespace FormsExercício2
{
    partial class frmCalculadoraDeAreaDeQuadrado
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAresta = new System.Windows.Forms.Label();
            this.txtAresta = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaValor = new System.Windows.Forms.Label();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(249, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de área de quadrado";
            // 
            // lblAresta
            // 
            this.lblAresta.AutoSize = true;
            this.lblAresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAresta.Location = new System.Drawing.Point(196, 123);
            this.lblAresta.Name = "lblAresta";
            this.lblAresta.Size = new System.Drawing.Size(56, 20);
            this.lblAresta.TabIndex = 1;
            this.lblAresta.Text = "Aresta";
            // 
            // txtAresta
            // 
            this.txtAresta.Location = new System.Drawing.Point(286, 125);
            this.txtAresta.Name = "txtAresta";
            this.txtAresta.Size = new System.Drawing.Size(266, 20);
            this.txtAresta.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(196, 156);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Área:";
            // 
            // lblAreaValor
            // 
            this.lblAreaValor.AutoSize = true;
            this.lblAreaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaValor.Location = new System.Drawing.Point(282, 156);
            this.lblAreaValor.Name = "lblAreaValor";
            this.lblAreaValor.Size = new System.Drawing.Size(0, 20);
            this.lblAreaValor.TabIndex = 4;
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularArea.Location = new System.Drawing.Point(362, 208);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(99, 34);
            this.btnCalcularArea.TabIndex = 5;
            this.btnCalcularArea.Text = "Calcular";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.clickou_calcular);
            // 
            // frmCalculadoraDeAreaDeQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.lblAreaValor);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtAresta);
            this.Controls.Add(this.lblAresta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCalculadoraDeAreaDeQuadrado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAresta;
        private System.Windows.Forms.TextBox txtAresta;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreaValor;
        private System.Windows.Forms.Button btnCalcularArea;
    }
}

