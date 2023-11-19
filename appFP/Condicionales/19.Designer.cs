namespace appFP.Condicionales
{
    partial class _19
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
            lblGenero = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            txtGenero = new TextBox();
            txtEdad = new TextBox();
            txtCategoria = new TextBox();
            SuspendLayout();
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(32, 39);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(51, 15);
            lblGenero.TabIndex = 0;
            lblGenero.Text = "Género :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Edad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 125);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            label3.Text = "Categoría :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(59, 183);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 28);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(100, 36);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(86, 23);
            txtGenero.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(100, 78);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(86, 23);
            txtEdad.TabIndex = 2;

            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(103, 122);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(86, 23);
            txtCategoria.TabIndex = 3;
    
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 245);
            Controls.Add(txtCategoria);
            Controls.Add(txtEdad);
            Controls.Add(txtGenero);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblGenero);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenero;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private TextBox txtGenero;
        private TextBox txtEdad;
        private TextBox txtCategoria;
    }
}