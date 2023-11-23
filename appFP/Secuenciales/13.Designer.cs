namespace appFP.Secuenciales
{
    partial class _13
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
            lblCO = new Label();
            lblHipotenusa = new Label();
            lblCA = new Label();
            txtCO = new TextBox();
            txtHipotenusa = new TextBox();
            txtCA = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblCO
            // 
            lblCO.AutoSize = true;
            lblCO.Location = new Point(40, 47);
            lblCO.Name = "lblCO";
            lblCO.Size = new Size(96, 15);
            lblCO.TabIndex = 0;
            lblCO.Text = "Cateto Opuesto :";
            // 
            // lblHipotenusa
            // 
            lblHipotenusa.AutoSize = true;
            lblHipotenusa.Location = new Point(40, 136);
            lblHipotenusa.Name = "lblHipotenusa";
            lblHipotenusa.Size = new Size(74, 15);
            lblHipotenusa.TabIndex = 0;
            lblHipotenusa.Text = "Hipotenusa :";
            // 
            // lblCA
            // 
            lblCA.AutoSize = true;
            lblCA.Location = new Point(40, 91);
            lblCA.Name = "lblCA";
            lblCA.Size = new Size(107, 15);
            lblCA.TabIndex = 0;
            lblCA.Text = "Cateto Adyacente :";
            // 
            // txtCO
            // 
            txtCO.Location = new Point(159, 44);
            txtCO.Name = "txtCO";
            txtCO.Size = new Size(63, 23);
            txtCO.TabIndex = 1;
            txtCO.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHipotenusa
            // 
            txtHipotenusa.Location = new Point(159, 133);
            txtHipotenusa.Name = "txtHipotenusa";
            txtHipotenusa.ReadOnly = true;
            txtHipotenusa.Size = new Size(74, 23);
            txtHipotenusa.TabIndex = 1;
            txtHipotenusa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCA
            // 
            txtCA.Location = new Point(159, 88);
            txtCA.Name = "txtCA";
            txtCA.Size = new Size(63, 23);
            txtCA.TabIndex = 1;
            txtCA.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 180);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 27);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 242);
            Controls.Add(btnCalcular);
            Controls.Add(txtCA);
            Controls.Add(txtHipotenusa);
            Controls.Add(txtCO);
            Controls.Add(lblCA);
            Controls.Add(lblHipotenusa);
            Controls.Add(lblCO);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCO;
        private Label lblHipotenusa;
        private Label lblCA;
        private TextBox txtCO;
        private TextBox txtHipotenusa;
        private TextBox txtCA;
        private Button btnCalcular;
    }
}