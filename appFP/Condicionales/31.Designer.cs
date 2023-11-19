namespace appFP.Condicionales
{
    partial class _31
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
            lblCategoria = new Label();
            lblBruto = new Label();
            lblDescuento = new Label();
            lblNeto = new Label();
            txtCategoria = new TextBox();
            txtBruto = new TextBox();
            txtDescuento = new TextBox();
            txtNeto = new TextBox();
            btnCalcular = new Button();
            lblHoras = new Label();
            txtHoras = new TextBox();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(28, 89);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria :";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(23, 138);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(81, 15);
            lblBruto.TabIndex = 0;
            lblBruto.Text = "Sueldo bruto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(28, 191);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(28, 239);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(76, 15);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "Sueldo neto :";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(121, 86);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 2;
            txtCategoria.TextAlign = HorizontalAlignment.Right;

            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(121, 135);
            txtBruto.Name = "txtBruto";
            txtBruto.ReadOnly = true;
            txtBruto.Size = new Size(100, 23);
            txtBruto.TabIndex = 3;
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(121, 188);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
      ;
            // 
            // txtNeto
            // 
            txtNeto.Location = new Point(121, 236);
            txtNeto.Name = "txtNeto";
            txtNeto.ReadOnly = true;
            txtNeto.Size = new Size(100, 23);
            txtNeto.TabIndex = 5;
            txtNeto.TextAlign = HorizontalAlignment.Right;
 
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 292);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 33);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(14, 35);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(101, 15);
            lblHoras.TabIndex = 6;
            lblHoras.Text = "Horas trabajadas :";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(121, 32);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 1;
            txtHoras.TextAlign = HorizontalAlignment.Right;
    
            // 
            // _31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 351);
            Controls.Add(lblHoras);
            Controls.Add(btnCalcular);
            Controls.Add(txtHoras);
            Controls.Add(txtNeto);
            Controls.Add(txtDescuento);
            Controls.Add(txtBruto);
            Controls.Add(txtCategoria);
            Controls.Add(lblNeto);
            Controls.Add(lblDescuento);
            Controls.Add(lblBruto);
            Controls.Add(lblCategoria);
            Name = "_31";
            Text = "_31";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private Label lblBruto;
        private Label lblDescuento;
        private Label lblNeto;
        private TextBox txtCategoria;
        private TextBox txtBruto;
        private TextBox txtDescuento;
        private TextBox txtNeto;
        private Button btnCalcular;
        private Label lblHoras;
        private TextBox txtHoras;
    }
}