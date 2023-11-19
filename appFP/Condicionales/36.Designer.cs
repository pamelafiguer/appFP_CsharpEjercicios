namespace appFP.Condicionales
{
    partial class _36
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
            lblCuadernos = new Label();
            lblLucas = new Label();
            lblPilot = new Label();
            lblFaber = new Label();
            txtCuadernos = new TextBox();
            txtPilot = new TextBox();
            txtLucas = new TextBox();
            txtFaber = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblCuadernos
            // 
            lblCuadernos.AutoSize = true;
            lblCuadernos.Location = new Point(37, 38);
            lblCuadernos.Name = "lblCuadernos";
            lblCuadernos.Size = new Size(70, 15);
            lblCuadernos.TabIndex = 0;
            lblCuadernos.Text = "Cuadernos :";
            // 
            // lblLucas
            // 
            lblLucas.AutoSize = true;
            lblLucas.Location = new Point(37, 81);
            lblLucas.Name = "lblLucas";
            lblLucas.Size = new Size(43, 15);
            lblLucas.TabIndex = 0;
            lblLucas.Text = "Lucas :";
            // 
            // lblPilot
            // 
            lblPilot.AutoSize = true;
            lblPilot.Location = new Point(37, 119);
            lblPilot.Name = "lblPilot";
            lblPilot.Size = new Size(37, 15);
            lblPilot.TabIndex = 0;
            lblPilot.Text = "Pilot :";
            // 
            // lblFaber
            // 
            lblFaber.AutoSize = true;
            lblFaber.Location = new Point(37, 158);
            lblFaber.Name = "lblFaber";
            lblFaber.Size = new Size(42, 15);
            lblFaber.TabIndex = 0;
            lblFaber.Text = "Faber :";
            // 
            // txtCuadernos
            // 
            txtCuadernos.Location = new Point(113, 35);
            txtCuadernos.Name = "txtCuadernos";
            txtCuadernos.Size = new Size(87, 23);
            txtCuadernos.TabIndex = 1;
            txtCuadernos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPilot
            // 
            txtPilot.Location = new Point(113, 116);
            txtPilot.Name = "txtPilot";
            txtPilot.ReadOnly = true;
            txtPilot.Size = new Size(87, 23);
            txtPilot.TabIndex = 3;
            txtPilot.TextAlign = HorizontalAlignment.Right;
          
            // 
            // txtLucas
            // 
            txtLucas.Location = new Point(113, 78);
            txtLucas.Name = "txtLucas";
            txtLucas.ReadOnly = true;
            txtLucas.Size = new Size(87, 23);
            txtLucas.TabIndex = 2;
            txtLucas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFaber
            // 
            txtFaber.Location = new Point(113, 155);
            txtFaber.Name = "txtFaber";
            txtFaber.ReadOnly = true;
            txtFaber.Size = new Size(87, 23);
            txtFaber.TabIndex = 4;
            txtFaber.TextAlign = HorizontalAlignment.Right;
          
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(69, 208);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 27);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _36
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 280);
            Controls.Add(btnCalcular);
            Controls.Add(txtLucas);
            Controls.Add(txtFaber);
            Controls.Add(txtPilot);
            Controls.Add(txtCuadernos);
            Controls.Add(lblFaber);
            Controls.Add(lblPilot);
            Controls.Add(lblLucas);
            Controls.Add(lblCuadernos);
            Name = "_36";
            Text = "_36";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuadernos;
        private Label lblLucas;
        private Label lblPilot;
        private Label lblFaber;
        private TextBox txtCuadernos;
        private TextBox txtPilot;
        private TextBox txtLucas;
        private TextBox txtFaber;
        private Button btnCalcular;
    }
}