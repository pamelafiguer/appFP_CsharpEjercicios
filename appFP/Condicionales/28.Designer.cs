namespace appFP.Condicionales
{
    partial class _28
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
            lblH24 = new Label();
            lblH12 = new Label();
            txtF24 = new TextBox();
            txtF12 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblH24
            // 
            lblH24.AutoSize = true;
            lblH24.Location = new Point(29, 38);
            lblH24.Name = "lblH24";
            lblH24.Size = new Size(105, 15);
            lblH24.TabIndex = 0;
            lblH24.Text = "Formato 24 horas :";
            // 
            // lblH12
            // 
            lblH12.AutoSize = true;
            lblH12.Location = new Point(29, 83);
            lblH12.Name = "lblH12";
            lblH12.Size = new Size(105, 15);
            lblH12.TabIndex = 0;
            lblH12.Text = "Formato 12 horas :";
            // 
            // txtF24
            // 
            txtF24.Location = new Point(140, 35);
            txtF24.Name = "txtF24";
            txtF24.Size = new Size(68, 23);
            txtF24.TabIndex = 1;
            txtF24.TextAlign = HorizontalAlignment.Right;
            // 
            // txtF12
            // 
            txtF12.Location = new Point(140, 80);
            txtF12.Name = "txtF12";
            txtF12.ReadOnly = true;
            txtF12.Size = new Size(68, 23);
            txtF12.TabIndex = 2;
            txtF12.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(71, 133);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(106, 30);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _28
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 197);
            Controls.Add(btnCalcular);
            Controls.Add(txtF12);
            Controls.Add(txtF24);
            Controls.Add(lblH12);
            Controls.Add(lblH24);
            Name = "_28";
            Text = "_28";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblH24;
        private Label lblH12;
        private TextBox txtF24;
        private TextBox txtF12;
        private Button btnCalcular;
    }
}