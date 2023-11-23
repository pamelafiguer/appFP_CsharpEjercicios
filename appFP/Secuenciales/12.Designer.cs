namespace appFP.Secuenciales
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
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblX2 = new Label();
            lblX1 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtX1 = new TextBox();
            txtX2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 37);
            lblA.Name = "lblA";
            lblA.Size = new Size(71, 15);
            lblA.TabIndex = 0;
            lblA.Text = "Valor de A =";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(12, 85);
            lblB.Name = "lblB";
            lblB.Size = new Size(70, 15);
            lblB.TabIndex = 0;
            lblB.Text = "Valor de B =";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(12, 134);
            lblC.Name = "lblC";
            lblC.Size = new Size(71, 15);
            lblC.TabIndex = 0;
            lblC.Text = "Valor de C =";
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Location = new Point(12, 223);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(76, 15);
            lblX2.TabIndex = 0;
            lblX2.Text = "Valor de x - =";
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Location = new Point(12, 179);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(79, 15);
            lblX1.TabIndex = 0;
            lblX1.Text = "Valor de x + =";
            // 
            // txtA
            // 
            txtA.Location = new Point(100, 34);
            txtA.Name = "txtA";
            txtA.Size = new Size(59, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(100, 82);
            txtB.Name = "txtB";
            txtB.Size = new Size(59, 23);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(100, 131);
            txtC.Name = "txtC";
            txtC.Size = new Size(59, 23);
            txtC.TabIndex = 3;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(100, 176);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(59, 23);
            txtX1.TabIndex = 4;
            // 
            // txtX2
            // 
            txtX2.Location = new Point(100, 220);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(59, 23);
            txtX2.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(44, 267);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 321);
            Controls.Add(btnCalcular);
            Controls.Add(txtX2);
            Controls.Add(txtX1);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblX1);
            Controls.Add(lblX2);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lblX2;
        private Label lblX1;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtX1;
        private TextBox txtX2;
        private Button btnCalcular;
    }
}