namespace appFP.repetitivos
{
    partial class _14
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
            lblprimo = new Label();
            txtNumero = new TextBox();
            txtPrimo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(30, 45);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblprimo
            // 
            lblprimo.AutoSize = true;
            lblprimo.Location = new Point(30, 96);
            lblprimo.Name = "lblprimo";
            lblprimo.Size = new Size(100, 15);
            lblprimo.TabIndex = 0;
            lblprimo.Text = "Calificado como :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(93, 42);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtPrimo
            // 
            txtPrimo.Location = new Point(136, 93);
            txtPrimo.Name = "txtPrimo";
            txtPrimo.Size = new Size(100, 23);
            txtPrimo.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(82, 146);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(91, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 201);
            Controls.Add(btnCalcular);
            Controls.Add(txtPrimo);
            Controls.Add(txtNumero);
            Controls.Add(lblprimo);
            Controls.Add(lblNumero);
            Name = "_14";
            Text = "_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblprimo;
        private TextBox txtNumero;
        private TextBox txtPrimo;
        private Button btnCalcular;
    }
}