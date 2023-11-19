namespace appFP.Condicionales
{
    partial class _18
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
            lblSalud = new Label();
            lblComedor = new Label();
            lblBolsa = new Label();
            txtSalud = new TextBox();
            txtMonto = new TextBox();
            txtComedor = new TextBox();
            txtBolsa = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(49, 45);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(67, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Donación  :";
            // 
            // lblSalud
            // 
            lblSalud.AutoSize = true;
            lblSalud.Location = new Point(49, 92);
            lblSalud.Name = "lblSalud";
            lblSalud.Size = new Size(81, 15);
            lblSalud.TabIndex = 0;
            lblSalud.Text = "Centro Salud :";
            // 
            // lblComedor
            // 
            lblComedor.AutoSize = true;
            lblComedor.Location = new Point(49, 138);
            lblComedor.Name = "lblComedor";
            lblComedor.Size = new Size(111, 15);
            lblComedor.TabIndex = 0;
            lblComedor.Text = "Comedor de niños :";
            // 
            // lblBolsa
            // 
            lblBolsa.AutoSize = true;
            lblBolsa.Location = new Point(49, 183);
            lblBolsa.Name = "lblBolsa";
            lblBolsa.Size = new Size(41, 15);
            lblBolsa.TabIndex = 0;
            lblBolsa.Text = "Bolsa :";
            // 
            // txtSalud
            // 
            txtSalud.Location = new Point(164, 89);
            txtSalud.Name = "txtSalud";
            txtSalud.ReadOnly = true;
            txtSalud.Size = new Size(88, 23);
            txtSalud.TabIndex = 2;
            txtSalud.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(164, 37);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(88, 23);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComedor
            // 
            txtComedor.Location = new Point(164, 135);
            txtComedor.Name = "txtComedor";
            txtComedor.ReadOnly = true;
            txtComedor.Size = new Size(88, 23);
            txtComedor.TabIndex = 3;
            txtComedor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBolsa
            // 
            txtBolsa.Location = new Point(164, 180);
            txtBolsa.Name = "txtBolsa";
            txtBolsa.ReadOnly = true;
            txtBolsa.Size = new Size(88, 23);
            txtBolsa.TabIndex = 4;
            txtBolsa.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 253);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 32);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 313);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(txtBolsa);
            Controls.Add(txtComedor);
            Controls.Add(txtSalud);
            Controls.Add(lblBolsa);
            Controls.Add(lblComedor);
            Controls.Add(lblSalud);
            Controls.Add(lblMonto);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblSalud;
        private Label lblComedor;
        private Label lblBolsa;
        private TextBox txtSalud;
        private TextBox txtMonto;
        private TextBox txtComedor;
        private TextBox txtBolsa;
        private Button btnCalcular;
    }
}