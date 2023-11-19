namespace appFP.Condicionales
{
    partial class _13
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
            lblNumero = new Label();
            lblTipo = new Label();
            txtTipo = new TextBox();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(24, 37);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(24, 86);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(89, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo  de Cifras :";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(128, 83);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(95, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(95, 142);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 34);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 207);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblNumero);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblTipo;
        private TextBox txtTipo;
        private TextBox txtNumero;
        private Button btnCalcular;
    }
}