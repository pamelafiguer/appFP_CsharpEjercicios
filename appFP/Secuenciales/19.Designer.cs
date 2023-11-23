namespace appFP.Secuenciales
{
    partial class _19
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
            lblComision = new Label();
            lblBruto = new Label();
            lblDescuento = new Label();
            lblNeto = new Label();
            txtMonto = new TextBox();
            txtComision = new TextBox();
            txtBruto = new TextBox();
            txtDescuento = new TextBox();
            txtNeto = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(29, 36);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(78, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto Total :";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(29, 82);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(64, 15);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comisión :";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(29, 129);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(81, 15);
            lblBruto.TabIndex = 0;
            lblBruto.Text = "Sueldo Bruto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(29, 179);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(29, 226);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(76, 15);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "Sueldo neto :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(113, 36);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(77, 23);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(113, 82);
            txtComision.Name = "txtComision";
            txtComision.Size = new Size(77, 23);
            txtComision.TabIndex = 2;
            txtComision.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(113, 129);
            txtBruto.Name = "txtBruto";
            txtBruto.Size = new Size(77, 23);
            txtBruto.TabIndex = 3;
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(113, 179);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(77, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            txtNeto.Location = new Point(113, 226);
            txtNeto.Name = "txtNeto";
            txtNeto.Size = new Size(77, 23);
            txtNeto.TabIndex = 5;
            txtNeto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(55, 275);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 30);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 335);
            Controls.Add(btnCalcular);
            Controls.Add(txtNeto);
            Controls.Add(txtDescuento);
            Controls.Add(txtBruto);
            Controls.Add(txtComision);
            Controls.Add(txtMonto);
            Controls.Add(lblNeto);
            Controls.Add(lblDescuento);
            Controls.Add(lblBruto);
            Controls.Add(lblComision);
            Controls.Add(lblMonto);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblComision;
        private Label lblBruto;
        private Label lblDescuento;
        private Label lblNeto;
        private TextBox txtMonto;
        private TextBox txtComision;
        private TextBox txtBruto;
        private TextBox txtDescuento;
        private TextBox txtNeto;
        private Button btnCalcular;
    }
}