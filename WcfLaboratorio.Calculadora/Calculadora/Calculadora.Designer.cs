namespace Calculadora
{
    partial class Calculadora
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
            this.lblRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBase1 = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblPrimerNumero = new System.Windows.Forms.Label();
            this.cbBase2 = new System.Windows.Forms.ComboBox();
            this.cbBase1 = new System.Windows.Forms.ComboBox();
            this.cbOperador = new System.Windows.Forms.ComboBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 189);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(58, 13);
            this.lblRes.TabIndex = 27;
            this.lblRes.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Base:";
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(248, 24);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(34, 13);
            this.lblBase1.TabIndex = 25;
            this.lblBase1.Text = "Base:";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(12, 137);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(93, 13);
            this.lblSegundoNumero.TabIndex = 24;
            this.lblSegundoNumero.Text = "Segundo Numero:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(12, 79);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(54, 13);
            this.lblOperador.TabIndex = 23;
            this.lblOperador.Text = "Operador:";
            // 
            // lblPrimerNumero
            // 
            this.lblPrimerNumero.AutoSize = true;
            this.lblPrimerNumero.Location = new System.Drawing.Point(12, 24);
            this.lblPrimerNumero.Name = "lblPrimerNumero";
            this.lblPrimerNumero.Size = new System.Drawing.Size(79, 13);
            this.lblPrimerNumero.TabIndex = 22;
            this.lblPrimerNumero.Text = "Primer Numero:";
            // 
            // cbBase2
            // 
            this.cbBase2.FormattingEnabled = true;
            this.cbBase2.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "10",
            "16",
            "32"});
            this.cbBase2.Location = new System.Drawing.Point(288, 133);
            this.cbBase2.Name = "cbBase2";
            this.cbBase2.Size = new System.Drawing.Size(52, 21);
            this.cbBase2.TabIndex = 21;
            // 
            // cbBase1
            // 
            this.cbBase1.FormattingEnabled = true;
            this.cbBase1.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "10",
            "16",
            "32"});
            this.cbBase1.Location = new System.Drawing.Point(288, 21);
            this.cbBase1.Name = "cbBase1";
            this.cbBase1.Size = new System.Drawing.Size(52, 21);
            this.cbBase1.TabIndex = 20;
            // 
            // cbOperador
            // 
            this.cbOperador.FormattingEnabled = true;
            this.cbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperador.Location = new System.Drawing.Point(111, 76);
            this.cbOperador.Name = "cbOperador";
            this.cbOperador.Size = new System.Drawing.Size(100, 21);
            this.cbOperador.TabIndex = 19;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(111, 134);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 18;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(111, 21);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 17;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(108, 189);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "label1";
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(265, 214);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 15;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 249);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblPrimerNumero);
            this.Controls.Add(this.cbBase2);
            this.Controls.Add(this.cbBase1);
            this.Controls.Add(this.cbOperador);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOperar);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBase1;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblPrimerNumero;
        private System.Windows.Forms.ComboBox cbBase2;
        private System.Windows.Forms.ComboBox cbBase1;
        private System.Windows.Forms.ComboBox cbOperador;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnOperar;
    }
}

