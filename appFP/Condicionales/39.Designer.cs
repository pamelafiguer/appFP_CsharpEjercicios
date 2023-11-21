namespace appFP.Condicionales
{
    partial class _39
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
            lblHoras = new Label();
            lblDefectuosos = new Label();
            lblNodef = new Label();
            lblEficiencia = new Label();
            txtHoras = new TextBox();
            txtDef = new TextBox();
            txtNodef = new TextBox();
            txtEficiencia = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(39, 34);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(109, 15);
            lblHoras.TabIndex = 0;
            lblHoras.Text = "Horas de ausencia :";
            // 
            // lblDefectuosos
            // 
            lblDefectuosos.AutoSize = true;
            lblDefectuosos.Location = new Point(39, 85);
            lblDefectuosos.Name = "lblDefectuosos";
            lblDefectuosos.Size = new Size(73, 15);
            lblDefectuosos.TabIndex = 0;
            lblDefectuosos.Text = "Defectuoso :";
            // 
            // lblNodef
            // 
            lblNodef.AutoSize = true;
            lblNodef.Location = new Point(39, 130);
            lblNodef.Name = "lblNodef";
            lblNodef.Size = new Size(96, 15);
            lblNodef.TabIndex = 0;
            lblNodef.Text = "No defectuosos :";
            // 
            // lblEficiencia
            // 
            lblEficiencia.AutoSize = true;
            lblEficiencia.Location = new Point(39, 171);
            lblEficiencia.Name = "lblEficiencia";
            lblEficiencia.Size = new Size(63, 15);
            lblEficiencia.TabIndex = 0;
            lblEficiencia.Text = "Eficiencia :";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(154, 31);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(82, 23);
            txtHoras.TabIndex = 1;
            txtHoras.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDef
            // 
            txtDef.Location = new Point(154, 82);
            txtDef.Name = "txtDef";
            txtDef.Size = new Size(82, 23);
            txtDef.TabIndex = 2;
            txtDef.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNodef
            // 
            txtNodef.Location = new Point(154, 127);
            txtNodef.Name = "txtNodef";
            txtNodef.Size = new Size(82, 23);
            txtNodef.TabIndex = 3;
            txtNodef.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEficiencia
            // 
            txtEficiencia.Location = new Point(154, 168);
            txtEficiencia.Name = "txtEficiencia";
            txtEficiencia.ReadOnly = true;
            txtEficiencia.Size = new Size(82, 23);
            txtEficiencia.TabIndex = 4;
            txtEficiencia.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(71, 219);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 30);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _39
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 294);
            Controls.Add(btnCalcular);
            Controls.Add(txtEficiencia);
            Controls.Add(txtNodef);
            Controls.Add(txtDef);
            Controls.Add(txtHoras);
            Controls.Add(lblEficiencia);
            Controls.Add(lblNodef);
            Controls.Add(lblDefectuosos);
            Controls.Add(lblHoras);
            Name = "_39";
            Text = "_39";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoras;
        private Label lblDefectuosos;
        private Label lblNodef;
        private Label lblEficiencia;
        private TextBox txtHoras;
        private TextBox txtDef;
        private TextBox txtNodef;
        private TextBox txtEficiencia;
        private Button btnCalcular;
    }
}