namespace appFP.Condicionales
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
            lblNumero = new Label();
            lblSigno = new Label();
            txtNumero = new TextBox();
            txtSigno = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(38, 33);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblSigno
            // 
            lblSigno.AutoSize = true;
            lblSigno.Location = new Point(38, 84);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(46, 15);
            lblSigno.TabIndex = 0;
            lblSigno.Text = "Signo : ";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(106, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(71, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSigno
            // 
            txtSigno.Location = new Point(90, 81);
            txtSigno.Name = "txtSigno";
            txtSigno.ReadOnly = true;
            txtSigno.Size = new Size(74, 23);
            txtSigno.TabIndex = 2;
            txtSigno.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(70, 135);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 31);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 196);
            Controls.Add(btnCalcular);
            Controls.Add(txtSigno);
            Controls.Add(txtNumero);
            Controls.Add(lblSigno);
            Controls.Add(lblNumero);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblSigno;
        private TextBox txtNumero;
        private TextBox txtSigno;
        private Button btnCalcular;
    }
}