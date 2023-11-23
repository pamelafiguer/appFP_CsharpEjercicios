namespace appFP.repetitivos
{
    partial class _04
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
            lblNumero = new Label();
            lblMultiplos = new Label();
            txtNumero = new TextBox();
            txtMultiplos = new TextBox();
            btnCalcular = new Button();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(27, 36);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblMultiplos
            // 
            lblMultiplos.AutoSize = true;
            lblMultiplos.Location = new Point(27, 127);
            lblMultiplos.Name = "lblMultiplos";
            lblMultiplos.Size = new Size(60, 15);
            lblMultiplos.TabIndex = 0;
            lblMultiplos.Text = "Múltiplos:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(100, 28);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(75, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMultiplos
            // 
            txtMultiplos.Location = new Point(105, 124);
            txtMultiplos.Name = "txtMultiplos";
            txtMultiplos.ReadOnly = true;
            txtMultiplos.Size = new Size(98, 23);
            txtMultiplos.TabIndex = 3;
            txtMultiplos.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 171);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 28);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(27, 83);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(130, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad de múltiplos :";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(168, 80);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 233);
            Controls.Add(btnCalcular);
            Controls.Add(txtCantidad);
            Controls.Add(txtMultiplos);
            Controls.Add(txtNumero);
            Controls.Add(lblCantidad);
            Controls.Add(lblMultiplos);
            Controls.Add(lblNumero);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblMultiplos;
        private TextBox txtNumero;
        private TextBox txtMultiplos;
        private Button btnCalcular;
        private Label lblCantidad;
        private TextBox txtCantidad;
    }
}