namespace appFP.Condicionales
{
    partial class _23
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
            lblMatematica = new Label();
            lblFisica = new Label();
            lblPropina = new Label();
            lblPromedio = new Label();
            lblReloj = new Label();
            txtMatematica = new TextBox();
            txtFisica = new TextBox();
            txtPropina = new TextBox();
            txtPromedio = new TextBox();
            txtReloj = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMatematica
            // 
            lblMatematica.AutoSize = true;
            lblMatematica.Location = new Point(24, 32);
            lblMatematica.Name = "lblMatematica";
            lblMatematica.Size = new Size(76, 15);
            lblMatematica.TabIndex = 0;
            lblMatematica.Text = "Matemática :";
            // 
            // lblFisica
            // 
            lblFisica.AutoSize = true;
            lblFisica.Location = new Point(24, 82);
            lblFisica.Name = "lblFisica";
            lblFisica.Size = new Size(42, 15);
            lblFisica.TabIndex = 0;
            lblFisica.Text = "Física :";
            // 
            // lblPropina
            // 
            lblPropina.AutoSize = true;
            lblPropina.Location = new Point(24, 131);
            lblPropina.Name = "lblPropina";
            lblPropina.Size = new Size(54, 15);
            lblPropina.TabIndex = 0;
            lblPropina.Text = "Propina :";
       
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(24, 176);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(65, 15);
            lblPromedio.TabIndex = 0;
            lblPromedio.Text = "Promedio :";
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Location = new Point(24, 225);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(39, 15);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "Reloj :";
         
            // 
            // txtMatematica
            // 
            txtMatematica.Location = new Point(106, 29);
            txtMatematica.Name = "txtMatematica";
            txtMatematica.Size = new Size(87, 23);
            txtMatematica.TabIndex = 1;
            txtMatematica.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFisica
            // 
            txtFisica.Location = new Point(106, 79);
            txtFisica.Name = "txtFisica";
            txtFisica.Size = new Size(87, 23);
            txtFisica.TabIndex = 2;
            txtFisica.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPropina
            // 
            txtPropina.Location = new Point(106, 128);
            txtPropina.Name = "txtPropina";
            txtPropina.ReadOnly = true;
            txtPropina.Size = new Size(87, 23);
            txtPropina.TabIndex = 3;
            txtPropina.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(106, 173);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(87, 23);
            txtPromedio.TabIndex = 4;
            txtPromedio.TextAlign = HorizontalAlignment.Right;
          
            // 
            // txtReloj
            // 
            txtReloj.Location = new Point(106, 222);
            txtReloj.Name = "txtReloj";
            txtReloj.ReadOnly = true;
            txtReloj.Size = new Size(87, 23);
            txtReloj.TabIndex = 5;
            txtReloj.TextAlign = HorizontalAlignment.Right;
      
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(50, 280);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 357);
            Controls.Add(btnCalcular);
            Controls.Add(txtReloj);
            Controls.Add(txtPromedio);
            Controls.Add(txtPropina);
            Controls.Add(txtFisica);
            Controls.Add(txtMatematica);
            Controls.Add(lblReloj);
            Controls.Add(lblPromedio);
            Controls.Add(lblPropina);
            Controls.Add(lblFisica);
            Controls.Add(lblMatematica);
            Name = "_23";
            Text = "_23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatematica;
        private Label lblFisica;
        private Label lblPropina;
        private Label lblPromedio;
        private Label lblReloj;
        private TextBox txtMatematica;
        private TextBox txtFisica;
        private TextBox txtPropina;
        private TextBox txtPromedio;
        private TextBox txtReloj;
        private Button btnCalcular;
    }
}