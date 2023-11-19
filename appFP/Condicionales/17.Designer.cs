namespace appFP.Condicionales
{
    partial class _17
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
            lblDocenas = new Label();
            lblPrecio = new Label();
            lblMonto = new Label();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblLapicero = new Label();
            txtDocenas = new TextBox();
            txtPrecio = new TextBox();
            txtMonto = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            txtLapicero = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDocenas
            // 
            lblDocenas.AutoSize = true;
            lblDocenas.Location = new Point(33, 31);
            lblDocenas.Name = "lblDocenas";
            lblDocenas.Size = new Size(58, 15);
            lblDocenas.TabIndex = 0;
            lblDocenas.Text = "Docenas :";

            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(33, 74);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 15);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio :";

            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(33, 123);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto :";

            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(33, 225);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total :";

            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(33, 173);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
        
            // 
            // lblLapicero
            // 
            lblLapicero.AutoSize = true;
            lblLapicero.Location = new Point(33, 271);
            lblLapicero.Name = "lblLapicero";
            lblLapicero.Size = new Size(58, 15);
            lblLapicero.TabIndex = 0;
            lblLapicero.Text = "Lapicero :";
        
            // 
            // txtDocenas
            // 
            txtDocenas.Location = new Point(109, 28);
            txtDocenas.Name = "txtDocenas";
            txtDocenas.Size = new Size(100, 23);
            txtDocenas.TabIndex = 1;
            txtDocenas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(109, 71);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(109, 120);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 3;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(109, 170);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(109, 222);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLapicero
            // 
            txtLapicero.Location = new Point(109, 268);
            txtLapicero.Name = "txtLapicero";
            txtLapicero.ReadOnly = true;
            txtLapicero.Size = new Size(100, 23);
            txtLapicero.TabIndex = 6;
            txtLapicero.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(65, 323);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 30);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 380);
            Controls.Add(btnCalcular);
            Controls.Add(txtLapicero);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtMonto);
            Controls.Add(txtPrecio);
            Controls.Add(txtDocenas);
            Controls.Add(lblDescuento);
            Controls.Add(lblLapicero);
            Controls.Add(lblTotal);
            Controls.Add(lblMonto);
            Controls.Add(lblPrecio);
            Controls.Add(lblDocenas);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDocenas;
        private Label lblPrecio;
        private Label lblMonto;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblLapicero;
        private TextBox txtDocenas;
        private TextBox txtPrecio;
        private TextBox txtMonto;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private TextBox txtLapicero;
        private Button btnCalcular;
    }
}