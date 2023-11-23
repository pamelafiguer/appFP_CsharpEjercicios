namespace appFP.Secuenciales
{
    partial class _05
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
            lblGigabytes = new Label();
            lblMegabytes = new Label();
            lblKilobytes = new Label();
            lblBytes = new Label();
            txtGB = new TextBox();
            txtMB = new TextBox();
            txtKB = new TextBox();
            txtBytes = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblGigabytes
            // 
            lblGigabytes.AutoSize = true;
            lblGigabytes.Location = new Point(40, 43);
            lblGigabytes.Name = "lblGigabytes";
            lblGigabytes.Size = new Size(65, 15);
            lblGigabytes.TabIndex = 0;
            lblGigabytes.Text = "Gigabytes :";
            // 
            // lblMegabytes
            // 
            lblMegabytes.AutoSize = true;
            lblMegabytes.Location = new Point(40, 92);
            lblMegabytes.Name = "lblMegabytes";
            lblMegabytes.Size = new Size(71, 15);
            lblMegabytes.TabIndex = 0;
            lblMegabytes.Text = "Megabytes :";
            // 
            // lblKilobytes
            // 
            lblKilobytes.AutoSize = true;
            lblKilobytes.Location = new Point(40, 145);
            lblKilobytes.Name = "lblKilobytes";
            lblKilobytes.Size = new Size(61, 15);
            lblKilobytes.TabIndex = 0;
            lblKilobytes.Text = "Kilobytes :";
            // 
            // lblBytes
            // 
            lblBytes.AutoSize = true;
            lblBytes.Location = new Point(40, 189);
            lblBytes.Name = "lblBytes";
            lblBytes.Size = new Size(41, 15);
            lblBytes.TabIndex = 0;
            lblBytes.Text = "Bytes :";
            // 
            // txtGB
            // 
            txtGB.Location = new Point(120, 40);
            txtGB.Name = "txtGB";
            txtGB.Size = new Size(100, 23);
            txtGB.TabIndex = 1;
            txtGB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMB
            // 
            txtMB.Location = new Point(120, 89);
            txtMB.Name = "txtMB";
            txtMB.ReadOnly = true;
            txtMB.Size = new Size(123, 23);
            txtMB.TabIndex = 2;
            txtMB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKB
            // 
            txtKB.Location = new Point(120, 142);
            txtKB.Name = "txtKB";
            txtKB.ReadOnly = true;
            txtKB.Size = new Size(123, 23);
            txtKB.TabIndex = 3;
            txtKB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBytes
            // 
            txtBytes.Location = new Point(120, 186);
            txtBytes.Name = "txtBytes";
            txtBytes.ReadOnly = true;
            txtBytes.Size = new Size(123, 23);
            txtBytes.TabIndex = 4;
            txtBytes.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(59, 243);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 28);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 308);
            Controls.Add(btnCalcular);
            Controls.Add(txtBytes);
            Controls.Add(txtKB);
            Controls.Add(txtMB);
            Controls.Add(txtGB);
            Controls.Add(lblBytes);
            Controls.Add(lblKilobytes);
            Controls.Add(lblMegabytes);
            Controls.Add(lblGigabytes);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGigabytes;
        private Label lblMegabytes;
        private Label lblKilobytes;
        private Label lblBytes;
        private TextBox txtGB;
        private TextBox txtMB;
        private TextBox txtKB;
        private TextBox txtBytes;
        private Button btnCalcular;
    }
}