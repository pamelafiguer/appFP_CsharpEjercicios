namespace appFP.Condicionales
{
    partial class _21
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
            lblCivil = new Label();
            lblEdad = new Label();
            lblGenero = new Label();
            txtNumero = new TextBox();
            txtCivil = new TextBox();
            txtEdad = new TextBox();
            txtGenero = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(27, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número :";
            // 
            // lblCivil
            // 
            lblCivil.AutoSize = true;
            lblCivil.Location = new Point(27, 74);
            lblCivil.Name = "lblCivil";
            lblCivil.Size = new Size(74, 15);
            lblCivil.TabIndex = 0;
            lblCivil.Text = "Estado Civil :";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(27, 122);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 15);
            lblEdad.TabIndex = 0;
            lblEdad.Text = "Edad :";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(27, 171);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(51, 15);
            lblGenero.TabIndex = 0;
            lblGenero.Text = "Género :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(113, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(93, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCivil
            // 
            txtCivil.Location = new Point(113, 71);
            txtCivil.Name = "txtCivil";
            txtCivil.ReadOnly = true;
            txtCivil.Size = new Size(93, 23);
            txtCivil.TabIndex = 2;
            txtCivil.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(113, 119);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(93, 23);
            txtEdad.TabIndex = 3;
            txtEdad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(113, 168);
            txtGenero.Name = "txtGenero";
            txtGenero.ReadOnly = true;
            txtGenero.Size = new Size(93, 23);
            txtGenero.TabIndex = 4;
            txtGenero.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(72, 221);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(106, 26);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _21
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 280);
            Controls.Add(btnCalcular);
            Controls.Add(txtGenero);
            Controls.Add(txtEdad);
            Controls.Add(txtCivil);
            Controls.Add(txtNumero);
            Controls.Add(lblGenero);
            Controls.Add(lblEdad);
            Controls.Add(lblCivil);
            Controls.Add(lblNumero);
            Name = "_21";
            Text = "_21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblCivil;
        private Label lblEdad;
        private Label lblGenero;
        private TextBox txtNumero;
        private TextBox txtCivil;
        private TextBox txtEdad;
        private TextBox txtGenero;
        private Button btnCalcular;
    }
}