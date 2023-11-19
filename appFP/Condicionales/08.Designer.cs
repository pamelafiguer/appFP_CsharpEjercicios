namespace appFP.Condicionales
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblPropina = new Label();
            lblNota3 = new Label();
            txtNota1 = new TextBox();
            txtMonto = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(35, 34);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(63, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Examen 1 :";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(35, 77);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(63, 15);
            lblNota2.TabIndex = 0;
            lblNota2.Text = "Examen 2 :";
            // 
            // lblPropina
            // 
            lblPropina.AutoSize = true;
            lblPropina.Location = new Point(35, 160);
            lblPropina.Name = "lblPropina";
            lblPropina.Size = new Size(52, 15);
            lblPropina.TabIndex = 0;
            lblPropina.Text = "Monto : ";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(35, 118);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(63, 15);
            lblNota3.TabIndex = 0;
            lblNota3.Text = "Examen 3 :";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(104, 31);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 1;
            txtNota1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(104, 157);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 4;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(104, 115);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 3;
            txtNota3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(104, 77);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 2;
            txtNota2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(85, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(106, 33);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 273);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota1);
            Controls.Add(txtNota2);
            Controls.Add(txtMonto);
            Controls.Add(txtNota3);
            Controls.Add(lblNota3);
            Controls.Add(lblPropina);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblPropina;
        private Label lblNota3;
        private TextBox txtNota1;
        private TextBox txtMonto;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private Button btnCalcular;
    }
}