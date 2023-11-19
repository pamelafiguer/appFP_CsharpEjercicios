namespace appFP.Condicionales
{
    partial class _09
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
            lblCodigo = new Label();
            lblImporte = new Label();
            lblCantidad = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            txtImporte = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(21, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código :";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(21, 126);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(55, 15);
            lblImporte.TabIndex = 0;
            lblImporte.Text = "Importe :";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(21, 79);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(61, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(21, 175);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(21, 225);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(95, 31);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(95, 76);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(95, 123);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 3;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(95, 172);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(95, 222);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(72, 269);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 38);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 331);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtImporte);
            Controls.Add(txtCantidad);
            Controls.Add(txtCodigo);
            Controls.Add(lblCantidad);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblImporte);
            Controls.Add(lblCodigo);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblImporte;
        private Label lblCantidad;
        private Label lblDescuento;
        private Label lblTotal;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private TextBox txtImporte;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private Button btnCalcular;
    }
}