namespace appFP.Repetitivos
{
    partial class _01
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
            lblDividendo = new Label();
            lblDivisor = new Label();
            lblCociente = new Label();
            lblResto = new Label();
            txtDividendo = new TextBox();
            txtDivisor = new TextBox();
            txtCociente = new TextBox();
            txtResto = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDividendo
            // 
            lblDividendo.AutoSize = true;
            lblDividendo.Location = new Point(30, 39);
            lblDividendo.Name = "lblDividendo";
            lblDividendo.Size = new Size(67, 15);
            lblDividendo.TabIndex = 0;
            lblDividendo.Text = "Dividendo :";
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(30, 89);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(49, 15);
            lblDivisor.TabIndex = 0;
            lblDivisor.Text = "Divisor :";
            // 
            // lblCociente
            // 
            lblCociente.AutoSize = true;
            lblCociente.Location = new Point(30, 137);
            lblCociente.Name = "lblCociente";
            lblCociente.Size = new Size(60, 15);
            lblCociente.TabIndex = 0;
            lblCociente.Text = "Cociente :";
            // 
            // lblResto
            // 
            lblResto.AutoSize = true;
            lblResto.Location = new Point(30, 183);
            lblResto.Name = "lblResto";
            lblResto.Size = new Size(42, 15);
            lblResto.TabIndex = 0;
            lblResto.Text = "Resto :";
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(105, 36);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(79, 23);
            txtDividendo.TabIndex = 1;
            txtDividendo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(105, 86);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(79, 23);
            txtDivisor.TabIndex = 2;
            txtDivisor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCociente
            // 
            txtCociente.Location = new Point(105, 134);
            txtCociente.Name = "txtCociente";
            txtCociente.ReadOnly = true;
            txtCociente.Size = new Size(79, 23);
            txtCociente.TabIndex = 3;
            txtCociente.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResto
            // 
            txtResto.Location = new Point(105, 180);
            txtResto.Name = "txtResto";
            txtResto.ReadOnly = true;
            txtResto.Size = new Size(79, 23);
            txtResto.TabIndex = 4;
            txtResto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(55, 226);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(80, 27);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 272);
            Controls.Add(btnCalcular);
            Controls.Add(txtResto);
            Controls.Add(txtCociente);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividendo);
            Controls.Add(lblResto);
            Controls.Add(lblCociente);
            Controls.Add(lblDivisor);
            Controls.Add(lblDividendo);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDividendo;
        private Label lblDivisor;
        private Label lblCociente;
        private Label lblResto;
        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private TextBox txtCociente;
        private TextBox txtResto;
        private Button btnCalcular;
    }
}