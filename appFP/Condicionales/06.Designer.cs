namespace appFP.Condicionales
{
    partial class _06
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

            lblE1 = new Label();
            lblE2 = new Label();
            lblE3 = new Label();
            lblMayor = new Label();
            lblMenor = new Label();
            txtE3 = new TextBox();
            txtE1 = new TextBox();
            txtE2 = new TextBox();
            txtMayor = new TextBox();
            txtMenor = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblE1
            // 
            lblE1.AutoSize = true;
            lblE1.Location = new Point(50, 39);
            lblE1.Name = "lblE1";
            lblE1.Size = new Size(48, 15);
            lblE1.TabIndex = 0;
            lblE1.Text = "Edad 1 :";
            // 
            // lblE2
            // 
            lblE2.AutoSize = true;
            lblE2.Location = new Point(50, 83);
            lblE2.Name = "lblE2";
            lblE2.Size = new Size(48, 15);
            lblE2.TabIndex = 0;
            lblE2.Text = "Edad 2 :";
            // 
            // lblE3
            // 
            lblE3.AutoSize = true;
            lblE3.Location = new Point(50, 123);
            lblE3.Name = "lblE3";
            lblE3.Size = new Size(48, 15);
            lblE3.TabIndex = 0;
            lblE3.Text = "Edad 3 :";
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(50, 166);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(47, 15);
            lblMayor.TabIndex = 0;
            lblMayor.Text = "Mayor :";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(50, 209);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(48, 15);
            lblMenor.TabIndex = 0;
            lblMenor.Text = "Menor :";
            // 
            // txtE3
            // 
            txtE3.Location = new Point(115, 123);
            txtE3.Name = "txtE3";
            txtE3.Size = new Size(100, 23);
            txtE3.TabIndex = 3;
            txtE3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtE1
            // 
            txtE1.Location = new Point(115, 36);
            txtE1.Name = "txtE1";
            txtE1.Size = new Size(100, 23);
            txtE1.TabIndex = 1;
            txtE1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtE2
            // 
            txtE2.Location = new Point(115, 80);
            txtE2.Name = "txtE2";
            txtE2.Size = new Size(100, 23);
            txtE2.TabIndex = 2;
            txtE2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMayor
            // 
            txtMayor.Location = new Point(115, 163);
            txtMayor.Name = "txtMayor";
            txtMayor.ReadOnly = true;
            txtMayor.Size = new Size(100, 23);
            txtMayor.TabIndex = 4;
            txtMayor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMenor
            // 
            txtMenor.Location = new Point(115, 206);
            txtMenor.Name = "txtMenor";
            txtMenor.ReadOnly = true;
            txtMenor.Size = new Size(100, 23);
            txtMenor.TabIndex = 5;
            txtMenor.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 276);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(106, 34);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 339);
            Controls.Add(btnCalcular);
            Controls.Add(txtE1);
            Controls.Add(txtE2);
            Controls.Add(txtMenor);
            Controls.Add(txtMayor);
            Controls.Add(txtE3);
            Controls.Add(lblMenor);
            Controls.Add(lblMayor);
            Controls.Add(lblE3);
            Controls.Add(lblE2);
            Controls.Add(lblE1);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblE1;
        private Label lblE2;
        private Label lblE3;
        private Label lblMayor;
        private Label lblMenor;
        private TextBox txtE3;
        private TextBox txtE1;
        private TextBox txtE2;
        private TextBox txtMayor;
        private TextBox txtMenor;
        private Button btnCalcular;


    }
}