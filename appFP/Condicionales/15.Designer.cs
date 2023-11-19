namespace appFP.Condicionales
{
    partial class _15
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
            lblCategoria = new Label();
            lblSueldoB = new Label();
            lblDescuento = new Label();
            lblSueldoN = new Label();
            txtMonto = new TextBox();
            txtCategoria = new TextBox();
            txtComision = new TextBox();
            txtNeto = new TextBox();
            txtDescuento = new TextBox();
            btnCalcular = new Button();
            lblComision = new Label();
            txtBruto = new TextBox();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(50, 40);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto :";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(35, 88);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria :";
            // 
            // lblSueldoB
            // 
            lblSueldoB.AutoSize = true;
            lblSueldoB.Location = new Point(32, 174);
            lblSueldoB.Name = "lblSueldoB";
            lblSueldoB.Size = new Size(81, 15);
            lblSueldoB.TabIndex = 0;
            lblSueldoB.Text = "Sueldo Bruto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(35, 218);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblSueldoN
            // 
            lblSueldoN.AutoSize = true;
            lblSueldoN.Location = new Point(35, 261);
            lblSueldoN.Name = "lblSueldoN";
            lblSueldoN.Size = new Size(78, 15);
            lblSueldoN.TabIndex = 0;
            lblSueldoN.Text = "Sueldo Neto :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(128, 37);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(128, 85);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 2;
            txtCategoria.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(128, 129);
            txtComision.Name = "txtComision";
            txtComision.ReadOnly = true;
            txtComision.Size = new Size(100, 23);
            txtComision.TabIndex = 3;
            txtComision.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            txtNeto.Location = new Point(128, 258);
            txtNeto.Name = "txtNeto";
            txtNeto.ReadOnly = true;
            txtNeto.Size = new Size(100, 23);
            txtNeto.TabIndex = 6;
            txtNeto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(128, 215);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 5;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(59, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 31);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(35, 132);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(64, 15);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comisión :";
            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(128, 171);
            txtBruto.Name = "txtBruto";
            txtBruto.ReadOnly = true;
            txtBruto.Size = new Size(100, 23);
            txtBruto.TabIndex = 4;
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 388);
            Controls.Add(btnCalcular);
            Controls.Add(txtDescuento);
            Controls.Add(txtNeto);
            Controls.Add(txtBruto);
            Controls.Add(txtComision);
            Controls.Add(txtCategoria);
            Controls.Add(txtMonto);
            Controls.Add(lblSueldoN);
            Controls.Add(lblDescuento);
            Controls.Add(lblSueldoB);
            Controls.Add(lblComision);
            Controls.Add(lblCategoria);
            Controls.Add(lblMonto);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblCategoria;
        private Label lblSueldoB;
        private Label lblDescuento;
        private Label lblSueldoN;
        private TextBox txtMonto;
        private TextBox txtCategoria;
        private TextBox txtComision;
        private TextBox txtNeto;
        private TextBox txtDescuento;
        private Button btnCalcular;
        private Label lblComision;
     
        private TextBox txtBruto;
    }
}