namespace appFP.repetitivos
{
    partial class _06
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
            lblInicio = new Label();
            lblFinal = new Label();
            txtNumero = new TextBox();
            txtInicio = new TextBox();
            txtFinal = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(29, 23);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(60, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Tabla del :";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(29, 67);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(30, 15);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "Del :";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(29, 109);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(43, 15);
            lblFinal.TabIndex = 0;
            lblFinal.Text = "Hasta :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(95, 20);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(88, 64);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 2;
            txtInicio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(88, 106);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(100, 23);
            txtFinal.TabIndex = 3;
            txtFinal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(48, 147);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.ScrollBars = ScrollBars.Vertical;
            txtRpta.Size = new Size(159, 178);
            txtRpta.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(69, 348);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 28);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 422);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtFinal);
            Controls.Add(txtInicio);
            Controls.Add(txtNumero);
            Controls.Add(lblFinal);
            Controls.Add(lblInicio);
            Controls.Add(lblNumero);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblInicio;
        private Label lblFinal;
        private TextBox txtNumero;
        private TextBox txtInicio;
        private TextBox txtFinal;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}