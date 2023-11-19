namespace appFP.Condicionales
{
    partial class _03
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
            this.lblAngulo = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.txtCalsificacion = new System.Windows.Forms.TextBox();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(39, 34);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(53, 15);
            this.lblAngulo.TabIndex = 0;
            this.lblAngulo.Text = "ángulo : ";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(39, 87);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(83, 15);
            this.lblClasificacion.TabIndex = 0;
            this.lblClasificacion.Text = "Clasificación : ";
            // 
            // txtCalsificacion
            // 
            this.txtCalsificacion.Location = new System.Drawing.Point(123, 84);
            this.txtCalsificacion.Name = "txtCalsificacion";
            this.txtCalsificacion.ReadOnly = true;
            this.txtCalsificacion.Size = new System.Drawing.Size(85, 23);
            this.txtCalsificacion.TabIndex = 2;
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(123, 26);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(85, 23);
            this.txtAngulo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "C&alcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAngulo);
            this.Controls.Add(this.txtCalsificacion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblAngulo);
            this.Name = "_03";
            this.Text = "_03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAngulo;
        private Label lblClasificacion;
        private TextBox txtCalsificacion;
        private TextBox txtAngulo;
        private Button button1;
    }
}