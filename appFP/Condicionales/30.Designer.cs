namespace appFP.Condicionales
{
    partial class _30
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
            lblDia = new Label();
            lblCuota = new Label();
            lblDescuento = new Label();
            lblRecargo = new Label();
            lblImporte = new Label();
            txtDia = new TextBox();
            txtCuota = new TextBox();
            txtDescuento = new TextBox();
            txtRecargo = new TextBox();
            txtImporte = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(38, 41);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(79, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día del pago :";
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new Point(38, 92);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(93, 15);
            lblCuota.TabIndex = 0;
            lblCuota.Text = "Cuota Mensual :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(38, 142);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(38, 191);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(117, 15);
            lblRecargo.TabIndex = 0;
            lblRecargo.Text = "Recargo de la cuota :";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(38, 243);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(84, 15);
            lblImporte.TabIndex = 0;
            lblImporte.Text = "Importe Total :";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(158, 38);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 1;
            txtDia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(158, 89);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(100, 23);
            txtCuota.TabIndex = 2;
            txtCuota.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(158, 139);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRecargo
            // 
            txtRecargo.Location = new Point(158, 188);
            txtRecargo.Name = "txtRecargo";
            txtRecargo.ReadOnly = true;
            txtRecargo.Size = new Size(100, 23);
            txtRecargo.TabIndex = 4;
            txtRecargo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(158, 240);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 5;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(100, 300);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 30);
            btnCalcular.TabIndex = 5;
            btnCalcular.TabStop = false;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _30
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 360);
            Controls.Add(btnCalcular);
            Controls.Add(txtImporte);
            Controls.Add(txtRecargo);
            Controls.Add(txtDescuento);
            Controls.Add(txtCuota);
            Controls.Add(txtDia);
            Controls.Add(lblImporte);
            Controls.Add(lblRecargo);
            Controls.Add(lblDescuento);
            Controls.Add(lblCuota);
            Controls.Add(lblDia);
            Name = "_30";
            Text = "_30";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblCuota;
        private Label lblDescuento;
        private Label lblRecargo;
        private Label lblImporte;
        private TextBox txtDia;
        private TextBox txtCuota;
        private TextBox txtDescuento;
        private TextBox txtRecargo;
        private TextBox txtImporte;
        private Button btnCalcular;
    }
}