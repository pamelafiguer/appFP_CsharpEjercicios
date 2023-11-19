namespace appFP.Condicionales
{
    partial class _16
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
            lblCosto = new Label();
            lblIngreso = new Label();
            lblInicial = new Label();
            lblMensual = new Label();
            btnCalcular = new Button();
            txtCosto = new TextBox();
            txtIngreso = new TextBox();
            txtInicial = new TextBox();
            txtMensual = new TextBox();
            SuspendLayout();
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(34, 33);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(88, 15);
            lblCosto.TabIndex = 0;
            lblCosto.Text = "Costo de Casa :";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(34, 80);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(52, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Ingreso :";
            // 
            // lblInicial
            // 
            lblInicial.AutoSize = true;
            lblInicial.Location = new Point(34, 133);
            lblInicial.Name = "lblInicial";
            lblInicial.Size = new Size(79, 15);
            lblInicial.TabIndex = 0;
            lblInicial.Text = "Cuota Inicial :";
          
            // 
            // lblMensual
            // 
            lblMensual.AutoSize = true;
            lblMensual.Location = new Point(34, 175);
            lblMensual.Name = "lblMensual";
            lblMensual.Size = new Size(93, 15);
            lblMensual.TabIndex = 0;
            lblMensual.Text = "Cuota mensual :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(89, 239);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 32);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(128, 30);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 1;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(128, 77);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(100, 23);
            txtIngreso.TabIndex = 2;
            txtIngreso.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInicial
            // 
            txtInicial.Location = new Point(128, 125);
            txtInicial.Name = "txtInicial";
            txtInicial.ReadOnly = true;
            txtInicial.Size = new Size(100, 23);
            txtInicial.TabIndex = 3;
            txtInicial.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMensual
            // 
            txtMensual.Location = new Point(128, 172);
            txtMensual.Name = "txtMensual";
            txtMensual.ReadOnly = true;
            txtMensual.Size = new Size(100, 23);
            txtMensual.TabIndex = 4;
            txtMensual.TextAlign = HorizontalAlignment.Right;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 315);
            Controls.Add(txtMensual);
            Controls.Add(txtInicial);
            Controls.Add(txtIngreso);
            Controls.Add(txtCosto);
            Controls.Add(btnCalcular);
            Controls.Add(lblMensual);
            Controls.Add(lblInicial);
            Controls.Add(lblIngreso);
            Controls.Add(lblCosto);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCosto;
        private Label lblIngreso;
        private Label lblInicial;
        private Label lblMensual;
        private Button btnCalcular;
        private TextBox txtCosto;
        private TextBox txtIngreso;
        private TextBox txtInicial;
        private TextBox txtMensual;
    }
}