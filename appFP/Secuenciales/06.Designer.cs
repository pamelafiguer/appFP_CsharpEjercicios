namespace appFP.Secuenciales
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
            lblRadio = new Label();
            lblAltura = new Label();
            lblAreaT = new Label();
            lblVolumen = new Label();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            txtAreaTotal = new TextBox();
            txtVolumen = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(29, 39);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(43, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(29, 90);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(45, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura :";
            // 
            // lblAreaT
            // 
            lblAreaT.AutoSize = true;
            lblAreaT.Location = new Point(29, 142);
            lblAreaT.Name = "lblAreaT";
            lblAreaT.Size = new Size(64, 15);
            lblAreaT.TabIndex = 0;
            lblAreaT.Text = "Area total :";
            // 
            // lblVolumen
            // 
            lblVolumen.AutoSize = true;
            lblVolumen.Location = new Point(29, 198);
            lblVolumen.Name = "lblVolumen";
            lblVolumen.Size = new Size(60, 15);
            lblVolumen.TabIndex = 0;
            lblVolumen.Text = "Volumen :";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(96, 36);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(73, 23);
            txtRadio.TabIndex = 1;
            txtRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(96, 87);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(73, 23);
            txtAltura.TabIndex = 2;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAreaTotal
            // 
            txtAreaTotal.Location = new Point(96, 139);
            txtAreaTotal.Name = "txtAreaTotal";
            txtAreaTotal.ReadOnly = true;
            txtAreaTotal.Size = new Size(100, 23);
            txtAreaTotal.TabIndex = 3;
            txtAreaTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(96, 195);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.ReadOnly = true;
            txtVolumen.Size = new Size(100, 23);
            txtVolumen.TabIndex = 4;
            txtVolumen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(56, 246);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 26);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 296);
            Controls.Add(btnCalcular);
            Controls.Add(txtVolumen);
            Controls.Add(txtAreaTotal);
            Controls.Add(txtAltura);
            Controls.Add(txtRadio);
            Controls.Add(lblVolumen);
            Controls.Add(lblAreaT);
            Controls.Add(lblAltura);
            Controls.Add(lblRadio);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private Label lblAltura;
        private Label lblAreaT;
        private Label lblVolumen;
        private TextBox txtRadio;
        private TextBox txtAltura;
        private TextBox txtAreaTotal;
        private TextBox txtVolumen;
        private Button btnCalcular;
    }
}