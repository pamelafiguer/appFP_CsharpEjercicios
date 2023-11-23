namespace appFP.Secuenciales
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
            lblBase = new Label();
            lblAltura = new Label();
            lblArea = new Label();
            lblPerimetro = new Label();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            txtArea = new TextBox();
            txtPerimetro = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(35, 44);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(37, 15);
            lblBase.TabIndex = 0;
            lblBase.Text = "Base :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(35, 94);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(45, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(35, 142);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(37, 15);
            lblArea.TabIndex = 0;
            lblArea.Text = "Área :";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(35, 189);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(65, 15);
            lblPerimetro.TabIndex = 0;
            lblPerimetro.Text = "Perímetro :";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(108, 41);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(79, 23);
            txtBase.TabIndex = 1;
            txtBase.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(108, 91);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(79, 23);
            txtAltura.TabIndex = 2;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(108, 139);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(79, 23);
            txtArea.TabIndex = 3;
            txtArea.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Location = new Point(108, 186);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.ReadOnly = true;
            txtPerimetro.Size = new Size(79, 23);
            txtPerimetro.TabIndex = 4;
            txtPerimetro.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(57, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 28);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 309);
            Controls.Add(btnCalcular);
            Controls.Add(txtPerimetro);
            Controls.Add(txtArea);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(lblAltura);
            Controls.Add(lblBase);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBase;
        private Label lblAltura;
        private Label lblArea;
        private Label lblPerimetro;
        private TextBox txtBase;
        private TextBox txtAltura;
        private TextBox txtArea;
        private TextBox txtPerimetro;
        private Button btnCalcular;
    }
}