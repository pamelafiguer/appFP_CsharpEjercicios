namespace appFP.Secuenciales
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
            lblPies = new Label();
            lblPulgadas = new Label();
            lblEstatura = new Label();
            txtPies = new TextBox();
            txtPulgadas = new TextBox();
            txtEstatura = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(29, 38);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(34, 15);
            lblPies.TabIndex = 0;
            lblPies.Text = "Pies :";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(29, 85);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(61, 15);
            lblPulgadas.TabIndex = 0;
            lblPulgadas.Text = "Pulgadas :";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(29, 130);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(55, 15);
            lblEstatura.TabIndex = 0;
            lblEstatura.Text = "Estatura :";
            // 
            // txtPies
            // 
            txtPies.Location = new Point(97, 35);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(82, 23);
            txtPies.TabIndex = 1;
            txtPies.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(97, 82);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(82, 23);
            txtPulgadas.TabIndex = 2;
            txtPulgadas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(97, 127);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(82, 23);
            txtEstatura.TabIndex = 3;
            txtEstatura.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(56, 177);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 28);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 235);
            Controls.Add(btnCalcular);
            Controls.Add(txtEstatura);
            Controls.Add(txtPulgadas);
            Controls.Add(txtPies);
            Controls.Add(lblEstatura);
            Controls.Add(lblPulgadas);
            Controls.Add(lblPies);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPies;
        private Label lblPulgadas;
        private Label lblEstatura;
        private TextBox txtPies;
        private TextBox txtPulgadas;
        private TextBox txtEstatura;
        private Button btnCalcular;
    }
}