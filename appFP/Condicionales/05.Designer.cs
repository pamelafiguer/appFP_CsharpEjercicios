namespace appFP.Condicionales
{
    partial class _05
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(90, 262);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 39);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "C&alcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(94, 202);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.ReadOnly = true;
            this.txtNuevo.Size = new System.Drawing.Size(100, 23);
            this.txtNuevo.TabIndex = 13;
            this.txtNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(92, 143);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.ReadOnly = true;
            this.txtMenor.Size = new System.Drawing.Size(100, 23);
            this.txtMenor.TabIndex = 12;
            this.txtMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(94, 87);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.ReadOnly = true;
            this.txtMayor.Size = new System.Drawing.Size(100, 23);
            this.txtMayor.TabIndex = 11;
            this.txtMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(103, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(38, 90);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(50, 15);
            this.lblMayor.TabIndex = 8;
            this.lblMayor.Text = "Mayor : ";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Location = new System.Drawing.Point(33, 205);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(51, 15);
            this.lblNuevo.TabIndex = 9;
            this.lblNuevo.Text = "Nuevo : ";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(33, 146);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(51, 15);
            this.lblMenor.TabIndex = 10;
            this.lblMenor.Text = "Menor : ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(37, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(60, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número : ";
            // 
            // _05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 322);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblNumero);
            this.Name = "_05";
            this.Text = "_05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNuevo;
        private TextBox txtMenor;
        private TextBox txtMayor;
        private TextBox txtNumero;
        private Label lblMayor;
        private Label lblNuevo;
        private Label lblMenor;
        private Label lblNumero;
    }
}