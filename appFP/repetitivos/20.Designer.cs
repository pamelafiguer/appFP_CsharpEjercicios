namespace appFP.repetitivos
{
    partial class _20
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
            lblNumeros = new Label();
            lblMayor = new Label();
            lblMenor = new Label();
            lblPromedio = new Label();
            txtPanel = new TextBox();
            txtMayor = new TextBox();
            txtMenor = new TextBox();
            txtPromedio = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(38, 31);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(105, 15);
            lblNumeros.TabIndex = 0;
            lblNumeros.Text = "Lista de Números :";
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(38, 251);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(47, 15);
            lblMayor.TabIndex = 0;
            lblMayor.Text = "Mayor :";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(38, 298);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(48, 15);
            lblMenor.TabIndex = 0;
            lblMenor.Text = "Menor :";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(38, 343);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(65, 15);
            lblPromedio.TabIndex = 0;
            lblPromedio.Text = "Promedio :";
            // 
            // txtPanel
            // 
            txtPanel.Location = new Point(38, 68);
            txtPanel.Multiline = true;
            txtPanel.Name = "txtPanel";
            txtPanel.ReadOnly = true;
            txtPanel.ScrollBars = ScrollBars.Vertical;
            txtPanel.Size = new Size(198, 147);
            txtPanel.TabIndex = 1;
            // 
            // txtMayor
            // 
            txtMayor.Location = new Point(91, 248);
            txtMayor.Name = "txtMayor";
            txtMayor.ReadOnly = true;
            txtMayor.Size = new Size(100, 23);
            txtMayor.TabIndex = 1;
            txtMayor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMenor
            // 
            txtMenor.Location = new Point(91, 295);
            txtMenor.Name = "txtMenor";
            txtMenor.ReadOnly = true;
            txtMenor.Size = new Size(100, 23);
            txtMenor.TabIndex = 1;
            txtMenor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(109, 340);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(100, 23);
            txtPromedio.TabIndex = 1;
            txtPromedio.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(91, 385);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 432);
            Controls.Add(btnCalcular);
            Controls.Add(txtPromedio);
            Controls.Add(txtMenor);
            Controls.Add(txtMayor);
            Controls.Add(txtPanel);
            Controls.Add(lblPromedio);
            Controls.Add(lblMenor);
            Controls.Add(lblMayor);
            Controls.Add(lblNumeros);
            Name = "_20";
            Text = "_20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeros;
        private Label lblMayor;
        private Label lblMenor;
        private Label lblPromedio;
        private TextBox txtPanel;
        private TextBox txtMayor;
        private TextBox txtMenor;
        private TextBox txtPromedio;
        private Button btnCalcular;
    }
}