namespace appFP.Condicionales
{
    partial class _26
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
            lblMonto = new Label();
            lblEmpresa = new Label();
            lblBanco = new Label();
            txtMonto = new TextBox();
            txtEmpresa = new TextBox();
            txtBanco = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(33, 35);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(78, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto Total :";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(33, 89);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(88, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Pago Empresa :";
            // 
            // lblBanco
            // 
            lblBanco.AutoSize = true;
            lblBanco.Location = new Point(33, 147);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new Size(88, 15);
            lblBanco.TabIndex = 0;
            lblBanco.Text = "Pago al Banco :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(124, 35);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(88, 23);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(124, 89);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ReadOnly = true;
            txtEmpresa.Size = new Size(88, 23);
            txtEmpresa.TabIndex = 2;
            txtEmpresa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBanco
            // 
            txtBanco.Location = new Point(124, 147);
            txtBanco.Name = "txtBanco";
            txtBanco.ReadOnly = true;
            txtBanco.Size = new Size(88, 23);
            txtBanco.TabIndex = 3;
            txtBanco.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(62, 213);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _26
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 278);
            Controls.Add(btnCalcular);
            Controls.Add(txtBanco);
            Controls.Add(txtEmpresa);
            Controls.Add(txtMonto);
            Controls.Add(lblBanco);
            Controls.Add(lblEmpresa);
            Controls.Add(lblMonto);
            Name = "_26";
            Text = "_26";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblEmpresa;
        private Label lblBanco;
        private TextBox txtMonto;
        private TextBox txtEmpresa;
        private TextBox txtBanco;
        private Button btnCalcular;
    }
}