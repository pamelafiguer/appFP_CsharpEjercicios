namespace appFP.repetitivos
{
    partial class _18
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
            lblM1 = new Label();
            lblM2 = new Label();
            lblM3 = new Label();
            txtTexto = new TextBox();
            txtM1 = new TextBox();
            txtM3 = new TextBox();
            txtM2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(43, 38);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(41, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto :";
            // 
            // lblM1
            // 
            lblM1.AutoSize = true;
            lblM1.Location = new Point(43, 81);
            lblM1.Name = "lblM1";
            lblM1.Size = new Size(32, 15);
            lblM1.TabIndex = 0;
            lblM1.Text = "ltrim";
            // 
            // lblM2
            // 
            lblM2.AutoSize = true;
            lblM2.Location = new Point(43, 129);
            lblM2.Name = "lblM2";
            lblM2.Size = new Size(39, 15);
            lblM2.TabIndex = 0;
            lblM2.Text = "rtrim :";
            // 
            // lblM3
            // 
            lblM3.AutoSize = true;
            lblM3.Location = new Point(43, 176);
            lblM3.Name = "lblM3";
            lblM3.Size = new Size(37, 15);
            lblM3.TabIndex = 0;
            lblM3.Text = "Trim :";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(101, 35);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(127, 23);
            txtTexto.TabIndex = 1;
            // 
            // txtM1
            // 
            txtM1.Location = new Point(101, 78);
            txtM1.Name = "txtM1";
            txtM1.ReadOnly = true;
            txtM1.Size = new Size(127, 23);
            txtM1.TabIndex = 2;
            txtM1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtM3
            // 
            txtM3.Location = new Point(101, 173);
            txtM3.Name = "txtM3";
            txtM3.ReadOnly = true;
            txtM3.Size = new Size(127, 23);
            txtM3.TabIndex = 4;
            txtM3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtM2
            // 
            txtM2.Location = new Point(101, 126);
            txtM2.Name = "txtM2";
            txtM2.ReadOnly = true;
            txtM2.Size = new Size(127, 23);
            txtM2.TabIndex = 3;
            txtM2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(65, 221);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 315);
            Controls.Add(btnCalcular);
            Controls.Add(txtM2);
            Controls.Add(txtM3);
            Controls.Add(txtM1);
            Controls.Add(txtTexto);
            Controls.Add(lblM3);
            Controls.Add(lblM2);
            Controls.Add(lblM1);
            Controls.Add(lblTexto);
            Name = "_18";
            Text = "_18";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Label lblM1;
        private Label lblM2;
        private Label lblM3;
        private TextBox txtTexto;
        private TextBox txtM1;
        private TextBox txtM3;
        private TextBox txtM2;
        private Button btnCalcular;
    }
}