namespace appFP.repetitivos
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
            lblMenor = new Label();
            txtMenores = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            lblSuma = new Label();
            lblMultiplos = new Label();
            txtMultiplos = new TextBox();
            SuspendLayout();
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(37, 47);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(71, 15);
            lblMenor.TabIndex = 0;
            lblMenor.Text = "Menores a  :";
            // 
            // txtMenores
            // 
            txtMenores.Location = new Point(114, 44);
            txtMenores.Name = "txtMenores";
            txtMenores.Size = new Size(91, 23);
            txtMenores.TabIndex = 1;
            txtMenores.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(62, 154);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.Size = new Size(164, 148);
            txtRpta.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(88, 338);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(29, 94);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(112, 15);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "Suma de Múltiplos :";
            // 
            // lblMultiplos
            // 
            lblMultiplos.AutoSize = true;
            lblMultiplos.Location = new Point(29, 127);
            lblMultiplos.Name = "lblMultiplos";
            lblMultiplos.Size = new Size(140, 15);
            lblMultiplos.TabIndex = 3;
            lblMultiplos.Text = "Números Múltiplos de 3 :";
            // 
            // txtMultiplos
            // 
            txtMultiplos.Location = new Point(147, 91);
            txtMultiplos.Name = "txtMultiplos";
            txtMultiplos.Size = new Size(91, 23);
            txtMultiplos.TabIndex = 2;
            txtMultiplos.TextAlign = HorizontalAlignment.Right;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 392);
            Controls.Add(lblMultiplos);
            Controls.Add(lblSuma);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtMultiplos);
            Controls.Add(txtMenores);
            Controls.Add(lblMenor);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenor;
        private TextBox txtMenores;
        private TextBox txtRpta;
        private Button btnCalcular;
        private Label lblSuma;
        private Label lblMultiplos;
        private TextBox txtMultiplos;
    }
}