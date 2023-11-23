namespace appFP.repetitivos
{
    partial class _07
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
            lblFactorial = new Label();
            txtNumero = new TextBox();
            txtFactorial = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(28, 44);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(28, 99);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(58, 15);
            lblFactorial.TabIndex = 0;
            lblFactorial.Text = "Factorial :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(86, 41);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(66, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(86, 96);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(81, 23);
            txtFactorial.TabIndex = 2;
            txtFactorial.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(63, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 27);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 211);
            Controls.Add(btnCalcular);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumero);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumero);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblFactorial;
        private TextBox txtNumero;
        private TextBox txtFactorial;
        private Button btnCalcular;
    }
}