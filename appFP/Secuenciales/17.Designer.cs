namespace appFP.Secuenciales
{
    partial class _17
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
            lblDonacion = new Label();
            lblSalud = new Label();
            lblEscuela = new Label();
            lblComedor = new Label();
            lblAsilo = new Label();
            txtDonacion = new TextBox();
            txtSalud = new TextBox();
            txtComedor = new TextBox();
            txtEscuela = new TextBox();
            txtAsilo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDonacion
            // 
            lblDonacion.AutoSize = true;
            lblDonacion.Location = new Point(24, 28);
            lblDonacion.Name = "lblDonacion";
            lblDonacion.Size = new Size(64, 15);
            lblDonacion.TabIndex = 0;
            lblDonacion.Text = "Donación :";
            // 
            // lblSalud
            // 
            lblSalud.AutoSize = true;
            lblSalud.Location = new Point(24, 70);
            lblSalud.Name = "lblSalud";
            lblSalud.Size = new Size(81, 15);
            lblSalud.TabIndex = 0;
            lblSalud.Text = "Centro Salud :";
            // 
            // lblEscuela
            // 
            lblEscuela.AutoSize = true;
            lblEscuela.Location = new Point(24, 159);
            lblEscuela.Name = "lblEscuela";
            lblEscuela.Size = new Size(52, 15);
            lblEscuela.TabIndex = 0;
            lblEscuela.Text = "Escuela :";
            // 
            // lblComedor
            // 
            lblComedor.AutoSize = true;
            lblComedor.Location = new Point(24, 115);
            lblComedor.Name = "lblComedor";
            lblComedor.Size = new Size(103, 15);
            lblComedor.TabIndex = 0;
            lblComedor.Text = "Comedor Infantil :";
            // 
            // lblAsilo
            // 
            lblAsilo.AutoSize = true;
            lblAsilo.Location = new Point(24, 199);
            lblAsilo.Name = "lblAsilo";
            lblAsilo.Size = new Size(39, 15);
            lblAsilo.TabIndex = 0;
            lblAsilo.Text = "Asilo :";
            // 
            // txtDonacion
            // 
            txtDonacion.Location = new Point(134, 28);
            txtDonacion.Name = "txtDonacion";
            txtDonacion.Size = new Size(85, 23);
            txtDonacion.TabIndex = 1;
            txtDonacion.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSalud
            // 
            txtSalud.Location = new Point(134, 70);
            txtSalud.Name = "txtSalud";
            txtSalud.ReadOnly = true;
            txtSalud.Size = new Size(85, 23);
            txtSalud.TabIndex = 2;
            txtSalud.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComedor
            // 
            txtComedor.Location = new Point(134, 115);
            txtComedor.Name = "txtComedor";
            txtComedor.ReadOnly = true;
            txtComedor.Size = new Size(85, 23);
            txtComedor.TabIndex = 3;
            txtComedor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEscuela
            // 
            txtEscuela.Location = new Point(134, 159);
            txtEscuela.Name = "txtEscuela";
            txtEscuela.ReadOnly = true;
            txtEscuela.Size = new Size(85, 23);
            txtEscuela.TabIndex = 4;
            txtEscuela.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAsilo
            // 
            txtAsilo.Location = new Point(134, 199);
            txtAsilo.Name = "txtAsilo";
            txtAsilo.ReadOnly = true;
            txtAsilo.Size = new Size(85, 23);
            txtAsilo.TabIndex = 5;
            txtAsilo.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(76, 235);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 26);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 286);
            Controls.Add(btnCalcular);
            Controls.Add(txtAsilo);
            Controls.Add(txtEscuela);
            Controls.Add(txtComedor);
            Controls.Add(txtSalud);
            Controls.Add(txtDonacion);
            Controls.Add(lblComedor);
            Controls.Add(lblAsilo);
            Controls.Add(lblEscuela);
            Controls.Add(lblSalud);
            Controls.Add(lblDonacion);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDonacion;
        private Label lblSalud;
        private Label lblEscuela;
        private Label lblComedor;
        private Label lblAsilo;
        private TextBox txtDonacion;
        private TextBox txtSalud;
        private TextBox txtComedor;
        private TextBox txtEscuela;
        private TextBox txtAsilo;
        private Button btnCalcular;
    }
}