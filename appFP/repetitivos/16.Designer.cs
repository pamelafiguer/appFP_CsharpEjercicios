namespace appFP.repetitivos
{
    partial class _16
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
            lblCadena = new Label();
            lblInvertido = new Label();
            txtInvertido = new TextBox();
            txtCadena = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblCadena
            // 
            lblCadena.AutoSize = true;
            lblCadena.Location = new Point(42, 40);
            lblCadena.Name = "lblCadena";
            lblCadena.Size = new Size(39, 15);
            lblCadena.TabIndex = 0;
            lblCadena.Text = "texto :";
            // 
            // lblInvertido
            // 
            lblInvertido.AutoSize = true;
            lblInvertido.Location = new Point(42, 93);
            lblInvertido.Name = "lblInvertido";
            lblInvertido.Size = new Size(60, 15);
            lblInvertido.TabIndex = 0;
            lblInvertido.Text = "Invertido :";
            // 
            // txtInvertido
            // 
            txtInvertido.Location = new Point(108, 90);
            txtInvertido.Name = "txtInvertido";
            txtInvertido.Size = new Size(124, 23);
            txtInvertido.TabIndex = 2;
            txtInvertido.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(108, 37);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(124, 23);
            txtCadena.TabIndex = 1;
            txtCadena.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(82, 142);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 32);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 206);
            Controls.Add(btnCalcular);
            Controls.Add(txtCadena);
            Controls.Add(txtInvertido);
            Controls.Add(lblInvertido);
            Controls.Add(lblCadena);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadena;
        private Label lblInvertido;
        private TextBox txtInvertido;
        private TextBox txtCadena;
        private Button btnCalcular;
    }
}