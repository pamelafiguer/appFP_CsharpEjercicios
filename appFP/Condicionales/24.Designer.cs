namespace appFP.Condicionales
{
    partial class _24
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
            lblMonto = new Label();
            lblSueldo = new Label();
            txtMonto = new TextBox();
            txtSueldo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(31, 44);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto :";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(31, 91);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(49, 15);
            lblSueldo.TabIndex = 0;
            lblSueldo.Text = "Sueldo :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(86, 41);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(81, 23);
            txtMonto.TabIndex = 1;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(86, 88);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(81, 23);
            txtSueldo.TabIndex = 2;
            txtSueldo.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(55, 142);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(85, 28);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _24
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 203);
            Controls.Add(btnCalcular);
            Controls.Add(txtSueldo);
            Controls.Add(txtMonto);
            Controls.Add(lblSueldo);
            Controls.Add(lblMonto);
            Name = "_24";
            Text = "_24";
       
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblSueldo;
        private TextBox txtMonto;
        private TextBox txtSueldo;
        private Button btnCalcular;
    }
}