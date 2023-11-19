namespace appFP.Condicionales
{
    partial class _14
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
            lblNumero = new Label();
            lblMonto = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            txtMonto = new TextBox();
            txtNumero = new TextBox();
            txtTotal = new TextBox();
            txtDescuento = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(28, 46);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(28, 98);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(28, 154);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(28, 205);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total : ";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(107, 90);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 2;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(107, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(107, 202);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(107, 151);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(64, 286);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 33);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 342);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(txtDescuento);
            Controls.Add(txtTotal);
            Controls.Add(txtMonto);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblMonto);
            Controls.Add(lblNumero);
            Name = "_14";
            Text = "_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblMonto;
        private Label lblDescuento;
        private Label lblTotal;
        private TextBox txtMonto;
        private TextBox txtNumero;
        private TextBox txtTotal;
        private TextBox txtDescuento;
        private Button btnCalcular;
    }
}