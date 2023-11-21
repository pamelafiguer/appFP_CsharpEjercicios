namespace appFP.Condicionales
{
    partial class _38
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
            lblDia = new Label();
            lblMes = new Label();
            lblAño = new Label();
            lblDmes = new Label();
            lblNMes = new Label();
            lblTranscurrido = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            txtDMes = new TextBox();
            txtNMes = new TextBox();
            txtTranscurso = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(45, 49);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(74, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día del mes :";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(45, 95);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(98, 15);
            lblMes.TabIndex = 0;
            lblMes.Text = "Número de Mes :";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(45, 138);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(35, 15);
            lblAño.TabIndex = 0;
            lblAño.Text = "Año :";
            // 
            // lblDmes
            // 
            lblDmes.AutoSize = true;
            lblDmes.Location = new Point(45, 182);
            lblDmes.Name = "lblDmes";
            lblDmes.Size = new Size(79, 15);
            lblDmes.TabIndex = 0;
            lblDmes.Text = "Días del mes :";
            // 
            // lblNMes
            // 
            lblNMes.AutoSize = true;
            lblNMes.Location = new Point(45, 229);
            lblNMes.Name = "lblNMes";
            lblNMes.Size = new Size(101, 15);
            lblNMes.TabIndex = 0;
            lblNMes.Text = "Nombre del mes :";
            // 
            // lblTranscurrido
            // 
            lblTranscurrido.AutoSize = true;
            lblTranscurrido.Location = new Point(45, 273);
            lblTranscurrido.Name = "lblTranscurrido";
            lblTranscurrido.Size = new Size(109, 15);
            lblTranscurrido.TabIndex = 0;
            lblTranscurrido.Text = "Dias Transcurridos :";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(163, 46);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(81, 23);
            txtDia.TabIndex = 1;
            txtDia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(163, 92);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(81, 23);
            txtMes.TabIndex = 2;
            txtMes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(163, 135);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(81, 23);
            txtAño.TabIndex = 3;
            txtAño.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDMes
            // 
            txtDMes.Location = new Point(163, 179);
            txtDMes.Name = "txtDMes";
            txtDMes.ReadOnly = true;
            txtDMes.Size = new Size(100, 23);
            txtDMes.TabIndex = 4;
            txtDMes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNMes
            // 
            txtNMes.Location = new Point(163, 226);
            txtNMes.Name = "txtNMes";
            txtNMes.ReadOnly = true;
            txtNMes.Size = new Size(100, 23);
            txtNMes.TabIndex = 5;
            txtNMes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTranscurso
            // 
            txtTranscurso.Location = new Point(163, 270);
            txtTranscurso.Name = "txtTranscurso";
            txtTranscurso.ReadOnly = true;
            txtTranscurso.Size = new Size(100, 23);
            txtTranscurso.TabIndex = 6;
            txtTranscurso.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(103, 324);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 33);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _38
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 386);
            Controls.Add(btnCalcular);
            Controls.Add(txtTranscurso);
            Controls.Add(txtNMes);
            Controls.Add(txtDMes);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblTranscurrido);
            Controls.Add(lblNMes);
            Controls.Add(lblDmes);
            Controls.Add(lblAño);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Name = "_38";
            Text = "_38";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblMes;
        private Label lblAño;
        private Label lblDmes;
        private Label lblNMes;
        private Label lblTranscurrido;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private TextBox txtDMes;
        private TextBox txtNMes;
        private TextBox txtTranscurso;
        private Button btnCalcular;
    }
}