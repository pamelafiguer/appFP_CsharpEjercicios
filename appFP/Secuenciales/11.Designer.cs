namespace appFP.Secuenciales
{
    partial class _11
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
            lblNumero1 = new Label();
            Numero2 = new Label();
            lblIntercambio1 = new Label();
            lblIntercambio2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtInter1 = new TextBox();
            txtInter2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(32, 33);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(66, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Número 1 :";
            // 
            // Numero2
            // 
            Numero2.AutoSize = true;
            Numero2.Location = new Point(32, 80);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(66, 15);
            Numero2.TabIndex = 0;
            Numero2.Text = "Número 2 :";
            // 
            // lblIntercambio1
            // 
            lblIntercambio1.AutoSize = true;
            lblIntercambio1.Location = new Point(32, 125);
            lblIntercambio1.Name = "lblIntercambio1";
            lblIntercambio1.Size = new Size(86, 15);
            lblIntercambio1.TabIndex = 0;
            lblIntercambio1.Text = "Intercambio 1 :";
            // 
            // lblIntercambio2
            // 
            lblIntercambio2.AutoSize = true;
            lblIntercambio2.Location = new Point(32, 171);
            lblIntercambio2.Name = "lblIntercambio2";
            lblIntercambio2.Size = new Size(86, 15);
            lblIntercambio2.TabIndex = 0;
            lblIntercambio2.Text = "Intrecambio 2 :";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(120, 30);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(69, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(120, 77);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(69, 23);
            txtNumero2.TabIndex = 2;
            txtNumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInter1
            // 
            txtInter1.Location = new Point(120, 122);
            txtInter1.Name = "txtInter1";
            txtInter1.Size = new Size(69, 23);
            txtInter1.TabIndex = 3;
            txtInter1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInter2
            // 
            txtInter2.Location = new Point(120, 168);
            txtInter2.Name = "txtInter2";
            txtInter2.Size = new Size(69, 23);
            txtInter2.TabIndex = 4;
            txtInter2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(61, 213);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 24);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 261);
            Controls.Add(btnCalcular);
            Controls.Add(txtInter2);
            Controls.Add(txtInter1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblIntercambio2);
            Controls.Add(lblIntercambio1);
            Controls.Add(Numero2);
            Controls.Add(lblNumero1);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private Label Numero2;
        private Label lblIntercambio1;
        private Label lblIntercambio2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtInter1;
        private TextBox txtInter2;
        private Button btnCalcular;
    }
}