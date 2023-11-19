namespace appFP.Condicionales
{
    partial class _12
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
            lblDia = new Label();
            btnCalcular = new Button();
            txtNumero = new TextBox();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(36, 35);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(36, 78);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(30, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(57, 141);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 31);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(99, 32);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(70, 23);
            txtNumero.TabIndex = 2;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(99, 75);
            txtDia.Name = "txtDia";
            txtDia.ReadOnly = true;
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 2;
            txtDia.TextAlign = HorizontalAlignment.Right;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 201);
            Controls.Add(txtDia);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            Controls.Add(lblDia);
            Controls.Add(lblNumero);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblDia;
     
        private TextBox txtNumero;
        private TextBox txtDia;
        public Button btnCalcular;
    }
}