namespace appFP.Condicionales
{
    partial class _27
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
            lblBruto = new Label();
            lblDescuento = new Label();
            lblNeto = new Label();
            lblPolos = new Label();
            txtMonto = new TextBox();
            txtBruto = new TextBox();
            txtDescuento = new TextBox();
            txtNeto = new TextBox();
            txtPolos = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(25, 38);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(95, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto Vendido :";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(25, 87);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(81, 15);
            lblBruto.TabIndex = 0;
            lblBruto.Text = "Sueldo bruto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(25, 135);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(25, 189);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(76, 15);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "Sueldo neto :";
            // 
            // lblPolos
            // 
            lblPolos.AutoSize = true;
            lblPolos.Location = new Point(25, 240);
            lblPolos.Name = "lblPolos";
            lblPolos.Size = new Size(42, 15);
            lblPolos.TabIndex = 0;
            lblPolos.Text = "Polos :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(126, 35);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(126, 84);
            txtBruto.Name = "txtBruto";
            txtBruto.ReadOnly = true;
            txtBruto.Size = new Size(100, 23);
            txtBruto.TabIndex = 2;
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(126, 132);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            txtNeto.Location = new Point(126, 186);
            txtNeto.Name = "txtNeto";
            txtNeto.ReadOnly = true;
            txtNeto.Size = new Size(100, 23);
            txtNeto.TabIndex = 4;
            txtNeto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPolos
            // 
            txtPolos.Location = new Point(126, 237);
            txtPolos.Name = "txtPolos";
            txtPolos.ReadOnly = true;
            txtPolos.Size = new Size(100, 23);
            txtPolos.TabIndex = 5;
            txtPolos.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(68, 300);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 30);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _27
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 371);
            Controls.Add(btnCalcular);
            Controls.Add(txtPolos);
            Controls.Add(txtNeto);
            Controls.Add(txtDescuento);
            Controls.Add(txtBruto);
            Controls.Add(txtMonto);
            Controls.Add(lblPolos);
            Controls.Add(lblNeto);
            Controls.Add(lblDescuento);
            Controls.Add(lblBruto);
            Controls.Add(lblMonto);
            Name = "_27";
            Text = "_27";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblBruto;
        private Label lblDescuento;
        private Label lblNeto;
        private Label lblPolos;
        private TextBox txtMonto;
        private TextBox txtBruto;
        private TextBox txtDescuento;
        private TextBox txtNeto;
        private TextBox txtPolos;
        private Button btnCalcular;
    }
}