namespace appFP.Condicionales
{
    partial class _34
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
            lblPeso = new Label();
            lblEstatura = new Label();
            lblimc = new Label();
            txtPeso = new TextBox();
            txtEstatura = new TextBox();
            txtimc = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(47, 55);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(38, 15);
            lblPeso.TabIndex = 0;
            lblPeso.Text = "Peso :";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(47, 106);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(55, 15);
            lblEstatura.TabIndex = 0;
            lblEstatura.Text = "Estatura :";
            // 
            // lblimc
            // 
            lblimc.AutoSize = true;
            lblimc.Location = new Point(47, 158);
            lblimc.Name = "lblimc";
            lblimc.Size = new Size(38, 15);
            lblimc.TabIndex = 0;
            lblimc.Text = "IMC : ";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(114, 52);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(66, 23);
            txtPeso.TabIndex = 1;
            txtPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(114, 103);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(66, 23);
            txtEstatura.TabIndex = 2;
            txtEstatura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtimc
            // 
            txtimc.Location = new Point(114, 155);
            txtimc.Name = "txtimc";
            txtimc.ReadOnly = true;
            txtimc.Size = new Size(79, 23);
            txtimc.TabIndex = 3;
            txtimc.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(61, 201);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _34
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 260);
            Controls.Add(btnCalcular);
            Controls.Add(txtimc);
            Controls.Add(txtEstatura);
            Controls.Add(txtPeso);
            Controls.Add(lblimc);
            Controls.Add(lblEstatura);
            Controls.Add(lblPeso);
            Name = "_34";
            Text = "_34";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeso;
        private Label lblEstatura;
        private Label lblimc;
        private TextBox txtPeso;
        private TextBox txtEstatura;
        private TextBox txtimc;
        private Button btnCalcular;
    }
}