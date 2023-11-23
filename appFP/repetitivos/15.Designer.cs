namespace appFP.repetitivos
{
    partial class _15
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
            lblTexto = new Label();
            lblMayuscula = new Label();
            lblMinuscula = new Label();
            txtTexto = new TextBox();
            txtMayuscula = new TextBox();
            txtMinuscula = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(38, 35);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(41, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto :";
            // 
            // lblMayuscula
            // 
            lblMayuscula.AutoSize = true;
            lblMayuscula.Location = new Point(38, 73);
            lblMayuscula.Name = "lblMayuscula";
            lblMayuscula.Size = new Size(70, 15);
            lblMayuscula.TabIndex = 0;
            lblMayuscula.Text = "Mayúscula :";
            // 
            // lblMinuscula
            // 
            lblMinuscula.AutoSize = true;
            lblMinuscula.Location = new Point(38, 113);
            lblMinuscula.Name = "lblMinuscula";
            lblMinuscula.Size = new Size(68, 15);
            lblMinuscula.TabIndex = 0;
            lblMinuscula.Text = "Minúscula :";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(112, 32);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(134, 23);
            txtTexto.TabIndex = 1;
            txtTexto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMayuscula
            // 
            txtMayuscula.Location = new Point(112, 70);
            txtMayuscula.Name = "txtMayuscula";
            txtMayuscula.Size = new Size(134, 23);
            txtMayuscula.TabIndex = 2;
            txtMayuscula.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMinuscula
            // 
            txtMinuscula.Location = new Point(112, 110);
            txtMinuscula.Name = "txtMinuscula";
            txtMinuscula.Size = new Size(134, 23);
            txtMinuscula.TabIndex = 3;
            txtMinuscula.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(84, 161);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(83, 26);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 221);
            Controls.Add(btnCalcular);
            Controls.Add(txtMinuscula);
            Controls.Add(txtMayuscula);
            Controls.Add(txtTexto);
            Controls.Add(lblMinuscula);
            Controls.Add(lblMayuscula);
            Controls.Add(lblTexto);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Label lblMayuscula;
        private Label lblMinuscula;
        private TextBox txtTexto;
        private TextBox txtMayuscula;
        private TextBox txtMinuscula;
        private Button btnCalcular;
    }
}