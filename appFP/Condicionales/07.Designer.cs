namespace appFP.Condicionales
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
            lblN1 = new Label();
            lblN2 = new Label();
            lblIntermedio = new Label();
            lblN3 = new Label();
            txtN2 = new TextBox();
            txtN1 = new TextBox();
            txtIntermedio = new TextBox();
            txtN3 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(49, 48);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(66, 15);
            lblN1.TabIndex = 0;
            lblN1.Text = "Número 1 :";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(49, 96);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(66, 15);
            lblN2.TabIndex = 0;
            lblN2.Text = "Número 2 :";
            // 
            // lblIntermedio
            // 
            lblIntermedio.AutoSize = true;
            lblIntermedio.Location = new Point(49, 198);
            lblIntermedio.Name = "lblIntermedio";
            lblIntermedio.Size = new Size(71, 15);
            lblIntermedio.TabIndex = 0;
            lblIntermedio.Text = "Intermedio :";
            // 
            // lblN3
            // 
            lblN3.AutoSize = true;
            lblN3.Location = new Point(49, 150);
            lblN3.Name = "lblN3";
            lblN3.Size = new Size(66, 15);
            lblN3.TabIndex = 0;
            lblN3.Text = "Número 3 :";
            // 
            // txtN2
            // 
            txtN2.Location = new Point(133, 93);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 2;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(133, 45);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 1;
            // 
            // txtIntermedio
            // 
            txtIntermedio.Location = new Point(126, 195);
            txtIntermedio.Name = "txtIntermedio";
            txtIntermedio.ReadOnly = true;
            txtIntermedio.Size = new Size(100, 23);
            txtIntermedio.TabIndex = 4;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(133, 147);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(100, 23);
            txtN3.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(88, 280);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 328);
            Controls.Add(btnCalcular);
            Controls.Add(txtN1);
            Controls.Add(txtN3);
            Controls.Add(txtIntermedio);
            Controls.Add(txtN2);
            Controls.Add(lblN3);
            Controls.Add(lblIntermedio);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN1;
        private Label lblN2;
        private Label lblIntermedio;
        private Label lblN3;
        private TextBox txtN2;
        private TextBox txtN1;
        private TextBox txtIntermedio;
        private TextBox txtN3;
        private Button btnCalcular;
    }
}