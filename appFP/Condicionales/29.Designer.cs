namespace appFP.Condicionales
{
    partial class _29
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
            lblHoras = new Label();
            lblPago = new Label();
            lblSbruto = new Label();
            lblDescuento = new Label();
            txtHoras = new TextBox();
            txtPago = new TextBox();
            txtBruto = new TextBox();
            txtDescuento = new TextBox();
            btnCalcular = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(12, 31);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(101, 15);
            lblHoras.TabIndex = 0;
            lblHoras.Text = "Horas trabajadas :";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(12, 81);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(88, 15);
            lblPago.TabIndex = 0;
            lblPago.Text = "Pago por hora :";
            // 
            // lblSbruto
            // 
            lblSbruto.AutoSize = true;
            lblSbruto.Location = new Point(12, 131);
            lblSbruto.Name = "lblSbruto";
            lblSbruto.Size = new Size(81, 15);
            lblSbruto.TabIndex = 0;
            lblSbruto.Text = "Sueldo Bruto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(12, 177);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(119, 28);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 1;
            txtHoras.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(119, 78);
            txtPago.Name = "txtPago";
            txtPago.ReadOnly = true;
            txtPago.Size = new Size(100, 23);
            txtPago.TabIndex = 2;
            txtPago.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(119, 128);
            txtBruto.Name = "txtBruto";
            txtBruto.ReadOnly = true;
            txtBruto.Size = new Size(100, 23);
            txtBruto.TabIndex = 3;
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(119, 174);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(62, 296);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 30);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 229);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total a pagar :";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(119, 226);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // _29
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 354);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtBruto);
            Controls.Add(txtPago);
            Controls.Add(txtHoras);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblSbruto);
            Controls.Add(lblPago);
            Controls.Add(lblHoras);
            Name = "_29";
            Text = "_29";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoras;
        private Label lblPago;
        private Label lblSbruto;
        private Label lblDescuento;
        private TextBox txtHoras;
        private TextBox txtPago;
        private TextBox txtBruto;
        private TextBox txtDescuento;
        private Button btnCalcular;
        private Label lblTotal;
        private TextBox txtTotal;
    }
}