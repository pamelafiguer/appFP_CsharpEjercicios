namespace appFP.Condicionales
{
    partial class _32
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
            lblPromedio = new Label();
            lblPension = new Label();
            lblDescuento = new Label();
            lblNueva = new Label();
            label6 = new Label();
            txtCategoria = new TextBox();
            txtPromedio = new TextBox();
            txtActual = new TextBox();
            txtDescuento = new TextBox();
            txtNueva = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(27, 40);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoría :";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(27, 96);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(65, 15);
            lblPromedio.TabIndex = 0;
            lblPromedio.Text = "Promedio :";
            // 
            // lblPension
            // 
            lblPension.AutoSize = true;
            lblPension.Location = new Point(27, 150);
            lblPension.Name = "lblPension";
            lblPension.Size = new Size(92, 15);
            lblPension.TabIndex = 0;
            lblPension.Text = "Actual Pensión :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(27, 204);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblNueva
            // 
            lblNueva.AutoSize = true;
            lblNueva.Location = new Point(27, 259);
            lblNueva.Name = "lblNueva";
            lblNueva.Size = new Size(92, 15);
            lblNueva.TabIndex = 0;
            lblNueva.Text = "Nueva Pensión :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 99);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(124, 37);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(87, 23);
            txtCategoria.TabIndex = 1;
            txtCategoria.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(124, 93);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(87, 23);
            txtPromedio.TabIndex = 2;
            txtPromedio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtActual
            // 
            txtActual.Location = new Point(124, 147);
            txtActual.Name = "txtActual";
            txtActual.ReadOnly = true;
            txtActual.Size = new Size(87, 23);
            txtActual.TabIndex = 3;
            txtActual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(124, 201);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(87, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNueva
            // 
            txtNueva.Location = new Point(124, 256);
            txtNueva.Name = "txtNueva";
            txtNueva.ReadOnly = true;
            txtNueva.Size = new Size(87, 23);
            txtNueva.TabIndex = 5;
            txtNueva.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(71, 319);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 33);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _32
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 388);
            Controls.Add(btnCalcular);
            Controls.Add(txtNueva);
            Controls.Add(txtDescuento);
            Controls.Add(txtActual);
            Controls.Add(txtPromedio);
            Controls.Add(txtCategoria);
            Controls.Add(lblNueva);
            Controls.Add(lblDescuento);
            Controls.Add(label6);
            Controls.Add(lblPension);
            Controls.Add(lblPromedio);
            Controls.Add(lblCategoria);
            Name = "_32";
            Text = "_32";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private Label lblPromedio;
        private Label lblPension;
        private Label lblDescuento;
        private Label lblNueva;
        private Label label6;
        private TextBox txtCategoria;
        private TextBox txtPromedio;
        private TextBox txtActual;
        private TextBox txtDescuento;
        private TextBox txtNueva;
        private Button btnCalcular;
    }
}