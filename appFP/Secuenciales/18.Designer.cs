namespace appFP.Secuenciales
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
            lblUnidades = new Label();
            lblPrecio = new Label();
            lblImporte = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            txtUnidades = new TextBox();
            txtPrecio = new TextBox();
            txtImporte = new TextBox();
            txtTotal = new TextBox();
            txtDescuento = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(27, 36);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 0;
            lblUnidades.Text = "Unidades :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(27, 79);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 15);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio :";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(27, 119);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(55, 15);
            lblImporte.TabIndex = 0;
            lblImporte.Text = "Importe :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(27, 160);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(27, 204);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Importe a pagar :";
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(111, 33);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(78, 23);
            txtUnidades.TabIndex = 1;
            txtUnidades.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 76);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(78, 23);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(111, 116);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(78, 23);
            txtImporte.TabIndex = 3;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(131, 201);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(78, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(111, 157);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(78, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(56, 255);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 24);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 316);
            Controls.Add(btnCalcular);
            Controls.Add(txtDescuento);
            Controls.Add(txtTotal);
            Controls.Add(txtImporte);
            Controls.Add(txtPrecio);
            Controls.Add(txtUnidades);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblImporte);
            Controls.Add(lblPrecio);
            Controls.Add(lblUnidades);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnidades;
        private Label lblPrecio;
        private Label lblImporte;
        private Label lblDescuento;
        private Label lblTotal;
        private TextBox txtUnidades;
        private TextBox txtPrecio;
        private TextBox txtImporte;
        private TextBox txtTotal;
        private TextBox txtDescuento;
        private Button btnCalcular;
    }
}