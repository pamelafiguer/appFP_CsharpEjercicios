namespace appFP.Condicionales
{
    partial class _35
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
            lblCodigo = new Label();
            lblEmpleado = new Label();
            txtEmpleado = new TextBox();
            txtCodigo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(28, 44);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código :";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(28, 94);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(66, 15);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado :";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(103, 91);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.ReadOnly = true;
            txtEmpleado.Size = new Size(100, 23);
            txtEmpleado.TabIndex = 2;
            txtEmpleado.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(103, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(81, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(46, 142);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 27);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _35
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 201);
            Controls.Add(btnCalcular);
            Controls.Add(txtCodigo);
            Controls.Add(txtEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(lblCodigo);
            Name = "_35";
            Text = "_35";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblEmpleado;
        private TextBox txtEmpleado;
        private TextBox txtCodigo;
        private Button btnCalcular;
    }
}