namespace appFP.Secuenciales
{
    partial class _02
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
            lblMetros = new Label();
            txtMetros = new TextBox();
            lblYardas = new Label();
            txtCentimetros = new TextBox();
            lblCentimetros = new Label();
            lblPies = new Label();
            lblPulgadas = new Label();
            txtPies = new TextBox();
            txtYardas = new TextBox();
            txtPulgadas = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(36, 20);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(53, 15);
            lblMetros.TabIndex = 0;
            lblMetros.Text = "Metros : ";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(118, 17);
            txtMetros.Margin = new Padding(3, 3, 10, 3);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(100, 23);
            txtMetros.TabIndex = 1;
            txtMetros.TextAlign = HorizontalAlignment.Right;
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(36, 106);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(50, 15);
            lblYardas.TabIndex = 0;
            lblYardas.Text = "Yardas : ";
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(118, 61);
            txtCentimetros.Margin = new Padding(3, 3, 10, 3);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.ReadOnly = true;
            txtCentimetros.Size = new Size(80, 23);
            txtCentimetros.TabIndex = 2;
            txtCentimetros.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCentimetros
            // 
            lblCentimetros.AutoSize = true;
            lblCentimetros.Location = new Point(36, 64);
            lblCentimetros.Name = "lblCentimetros";
            lblCentimetros.Size = new Size(78, 15);
            lblCentimetros.TabIndex = 0;
            lblCentimetros.Text = "Centimetros :";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(36, 149);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(37, 15);
            lblPies.TabIndex = 2;
            lblPies.Text = "Pies : ";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(36, 187);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(64, 15);
            lblPulgadas.TabIndex = 0;
            lblPulgadas.Text = "Pulgadas : ";
            // 
            // txtPies
            // 
            txtPies.Location = new Point(118, 146);
            txtPies.Margin = new Padding(3, 3, 10, 3);
            txtPies.Name = "txtPies";
            txtPies.ReadOnly = true;
            txtPies.Size = new Size(80, 23);
            txtPies.TabIndex = 4;
            txtPies.TextAlign = HorizontalAlignment.Right;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(118, 106);
            txtYardas.Margin = new Padding(3, 3, 10, 3);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(80, 23);
            txtYardas.TabIndex = 3;
            txtYardas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(118, 184);
            txtPulgadas.Margin = new Padding(3, 3, 10, 3);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.ReadOnly = true;
            txtPulgadas.Size = new Size(80, 23);
            txtPulgadas.TabIndex = 5;
            txtPulgadas.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(118, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 36);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 290);
            Controls.Add(btnCalcular);
            Controls.Add(txtYardas);
            Controls.Add(txtPulgadas);
            Controls.Add(txtPies);
            Controls.Add(txtCentimetros);
            Controls.Add(lblCentimetros);
            Controls.Add(lblPulgadas);
            Controls.Add(lblPies);
            Controls.Add(lblYardas);
            Controls.Add(txtMetros);
            Controls.Add(lblMetros);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetros;
        private TextBox txtMetros;
        private Label lblYardas;
        private TextBox txtCentimetros;
        private Label lblCentimetros;
        private Label lblPies;
        private Label lblPulgadas;
        private TextBox txtPies;
        private TextBox txtYardas;
        private TextBox txtPulgadas;
        private Button btnCalcular;
    }
}