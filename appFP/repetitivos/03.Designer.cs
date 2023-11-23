namespace appFP.repetitivos
{
    partial class _03
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
            lblDivisores = new Label();
            txtNumero = new TextBox();
            txtDivisores = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(29, 46);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblDivisores
            // 
            lblDivisores.AutoSize = true;
            lblDivisores.Location = new Point(29, 104);
            lblDivisores.Name = "lblDivisores";
            lblDivisores.Size = new Size(60, 15);
            lblDivisores.TabIndex = 0;
            lblDivisores.Text = "Divisores :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(79, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDivisores
            // 
            txtDivisores.Location = new Point(96, 101);
            txtDivisores.Name = "txtDivisores";
            txtDivisores.ReadOnly = true;
            txtDivisores.Size = new Size(112, 23);
            txtDivisores.TabIndex = 2;
            txtDivisores.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(65, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 27);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 200);
            Controls.Add(btnCalcular);
            Controls.Add(txtDivisores);
            Controls.Add(txtNumero);
            Controls.Add(lblDivisores);
            Controls.Add(lblNumero);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblDivisores;
        private TextBox txtNumero;
        private TextBox txtDivisores;
        private Button btnCalcular;
    }
}