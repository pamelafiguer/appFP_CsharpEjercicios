namespace appFP.Secuenciales
{
    partial class _08
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
            lblAreaBase = new Label();
            lblAreaL = new Label();
            lblAreaTotal = new Label();
            txtAltura = new TextBox();
            txtRadio = new TextBox();
            txtABase = new TextBox();
            txtAreaL = new TextBox();
            txtAreaT = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(34, 47);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(43, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(34, 95);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(45, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura :";
            // 
            // lblAreaBase
            // 
            lblAreaBase.AutoSize = true;
            lblAreaBase.Location = new Point(34, 144);
            lblAreaBase.Name = "lblAreaBase";
            lblAreaBase.Size = new Size(64, 15);
            lblAreaBase.TabIndex = 0;
            lblAreaBase.Text = "Área Base :";
            // 
            // lblAreaL
            // 
            lblAreaL.AutoSize = true;
            lblAreaL.Location = new Point(34, 193);
            lblAreaL.Name = "lblAreaL";
            lblAreaL.Size = new Size(75, 15);
            lblAreaL.TabIndex = 0;
            lblAreaL.Text = "Área Lateral :";
            // 
            // lblAreaTotal
            // 
            lblAreaTotal.AutoSize = true;
            lblAreaTotal.Location = new Point(34, 239);
            lblAreaTotal.Name = "lblAreaTotal";
            lblAreaTotal.Size = new Size(66, 15);
            lblAreaTotal.TabIndex = 0;
            lblAreaTotal.Text = "Área Total :";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(112, 92);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(72, 23);
            txtAltura.TabIndex = 2;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(112, 39);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(72, 23);
            txtRadio.TabIndex = 1;
            txtRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtABase
            // 
            txtABase.Location = new Point(112, 141);
            txtABase.Name = "txtABase";
            txtABase.ReadOnly = true;
            txtABase.Size = new Size(72, 23);
            txtABase.TabIndex = 3;
            txtABase.TextAlign = HorizontalAlignment.Right;
   
            // 
            // txtAreaL
            // 
            txtAreaL.Location = new Point(112, 190);
            txtAreaL.Name = "txtAreaL";
            txtAreaL.ReadOnly = true;
            txtAreaL.Size = new Size(72, 23);
            txtAreaL.TabIndex = 4;
            txtAreaL.TextAlign = HorizontalAlignment.Right;
           
            // 
            // txtAreaT
            // 
            txtAreaT.Location = new Point(112, 236);
            txtAreaT.Name = "txtAreaT";
            txtAreaT.ReadOnly = true;
            txtAreaT.Size = new Size(72, 23);
            txtAreaT.TabIndex = 5;
            txtAreaT.TextAlign = HorizontalAlignment.Right;
           
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(55, 294);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 27);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 353);
            Controls.Add(btnCalcular);
            Controls.Add(txtRadio);
            Controls.Add(txtAreaT);
            Controls.Add(txtAreaL);
            Controls.Add(txtABase);
            Controls.Add(txtAltura);
            Controls.Add(lblAreaTotal);
            Controls.Add(lblAreaL);
            Controls.Add(lblAreaBase);
            Controls.Add(lblAltura);
            Controls.Add(lblRadio);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private Label lblAltura;
        private Label lblAreaBase;
        private Label lblAreaL;
        private Label lblAreaTotal;
        private TextBox txtAltura;
        private TextBox txtRadio;
        private TextBox txtABase;
        private TextBox txtAreaL;
        private TextBox txtAreaT;
        private Button btnCalcular;
    }
}