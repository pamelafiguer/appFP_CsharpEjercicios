namespace appFP.Secuenciales
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
            lblHoras = new Label();
            lblTarifa = new Label();
            lblBasico = new Label();
            lblSBruto = new Label();
            lblNeto = new Label();
            txtHoras = new TextBox();
            txtTarifa = new TextBox();
            txtBasico = new TextBox();
            txtSbruto = new TextBox();
            txtSueldoN = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(27, 37);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(103, 15);
            lblHoras.TabIndex = 0;
            lblHoras.Text = "Horas Trabajadas :";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(27, 75);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(42, 15);
            lblTarifa.TabIndex = 0;
            lblTarifa.Text = "Tarifa :";
            // 
            // lblBasico
            // 
            lblBasico.AutoSize = true;
            lblBasico.Location = new Point(27, 114);
            lblBasico.Name = "lblBasico";
            lblBasico.Size = new Size(80, 15);
            lblBasico.TabIndex = 0;
            lblBasico.Text = "Sueldo Básico";
            // 
            // lblSBruto
            // 
            lblSBruto.AutoSize = true;
            lblSBruto.Location = new Point(27, 156);
            lblSBruto.Name = "lblSBruto";
            lblSBruto.Size = new Size(81, 15);
            lblSBruto.TabIndex = 0;
            lblSBruto.Text = "Sueldo Bruto :";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(27, 195);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(78, 15);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "Sueldo Neto :";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(134, 34);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(87, 23);
            txtHoras.TabIndex = 1;
            txtHoras.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(134, 72);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(87, 23);
            txtTarifa.TabIndex = 2;
            txtTarifa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBasico
            // 
            txtBasico.Location = new Point(134, 111);
            txtBasico.Name = "txtBasico";
            txtBasico.ReadOnly = true;
            txtBasico.Size = new Size(87, 23);
            txtBasico.TabIndex = 3;
            txtBasico.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSbruto
            // 
            txtSbruto.Location = new Point(134, 153);
            txtSbruto.Name = "txtSbruto";
            txtSbruto.ReadOnly = true;
            txtSbruto.Size = new Size(87, 23);
            txtSbruto.TabIndex = 4;
            txtSbruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSueldoN
            // 
            txtSueldoN.Location = new Point(134, 192);
            txtSueldoN.Name = "txtSueldoN";
            txtSueldoN.ReadOnly = true;
            txtSueldoN.Size = new Size(87, 23);
            txtSueldoN.TabIndex = 5;
            txtSueldoN.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(75, 239);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 288);
            Controls.Add(btnCalcular);
            Controls.Add(txtSueldoN);
            Controls.Add(txtSbruto);
            Controls.Add(txtBasico);
            Controls.Add(txtTarifa);
            Controls.Add(txtHoras);
            Controls.Add(lblNeto);
            Controls.Add(lblSBruto);
            Controls.Add(lblBasico);
            Controls.Add(lblTarifa);
            Controls.Add(lblHoras);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoras;
        private Label lblTarifa;
        private Label lblBasico;
        private Label lblSBruto;
        private Label lblNeto;
        private TextBox txtHoras;
        private TextBox txtTarifa;
        private TextBox txtBasico;
        private TextBox txtSbruto;
        private TextBox txtSueldoN;
        private Button btnCalcular;
    }
}