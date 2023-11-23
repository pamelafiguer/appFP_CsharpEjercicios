namespace appFP.Secuenciales
{
    partial class _10
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
            lblInvertido = new Label();
            txtNumero = new TextBox();
            txtInvertido = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(37, 36);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblInvertido
            // 
            lblInvertido.AutoSize = true;
            lblInvertido.Location = new Point(37, 80);
            lblInvertido.Name = "lblInvertido";
            lblInvertido.Size = new Size(60, 15);
            lblInvertido.TabIndex = 0;
            lblInvertido.Text = "Invertido :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(102, 33);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtInvertido
            // 
            txtInvertido.Location = new Point(102, 77);
            txtInvertido.Name = "txtInvertido";
            txtInvertido.Size = new Size(100, 23);
            txtInvertido.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(58, 131);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 25);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 179);
            Controls.Add(btnCalcular);
            Controls.Add(txtInvertido);
            Controls.Add(txtNumero);
            Controls.Add(lblInvertido);
            Controls.Add(lblNumero);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblInvertido;
        private TextBox txtNumero;
        private TextBox txtInvertido;
        private Button btnCalcular;
    }
}