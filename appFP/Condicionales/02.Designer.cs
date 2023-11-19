namespace appFP.Condicionales
{
    partial class _02
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
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblCaramelos = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCaramelos = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(41, 33);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(65, 15);
            this.lblUnidades.TabIndex = 0;
            this.lblUnidades.Text = "Unidades : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(41, 214);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total : ";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(41, 80);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(58, 15);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Importe : ";
            // 
            // lblCaramelos
            // 
            this.lblCaramelos.AutoSize = true;
            this.lblCaramelos.Location = new System.Drawing.Point(41, 167);
            this.lblCaramelos.Name = "lblCaramelos";
            this.lblCaramelos.Size = new System.Drawing.Size(72, 15);
            this.lblCaramelos.TabIndex = 0;
            this.lblCaramelos.Text = "Caramelos : ";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(41, 127);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(72, 15);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.Text = "Descuento : ";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(121, 33);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 23);
            this.txtUnidades.TabIndex = 1;
            this.txtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(121, 211);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCaramelos
            // 
            this.txtCaramelos.Location = new System.Drawing.Point(121, 164);
            this.txtCaramelos.Name = "txtCaramelos";
            this.txtCaramelos.ReadOnly = true;
            this.txtCaramelos.Size = new System.Drawing.Size(100, 23);
            this.txtCaramelos.TabIndex = 4;
            this.txtCaramelos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(121, 122);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(121, 77);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 23);
            this.txtImporte.TabIndex = 2;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(72, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 24);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "C&alcular ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // _02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 348);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtCaramelos);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCaramelos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblUnidades);
            this.Name = "_02";
            this.Text = "_02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblUnidades;
        private Label lblTotal;
        private Label lblImporte;
        private Label lblCaramelos;
        private Label lblDescuento;
        private TextBox txtUnidades;
        private TextBox txtTotal;
        private TextBox txtCaramelos;
        private TextBox txtDescuento;
        private TextBox txtImporte;
        private Button btnCalcular;
    }
}