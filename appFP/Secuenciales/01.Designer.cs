namespace appFP.Secuenciales
{
    partial class _01
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
            lblMujeres = new Label();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            btnCalcular = new Button();
            lblPVarones = new Label();
            lblPMujeres = new Label();
            lblVarones = new Label();
            SuspendLayout();
            // 
            // lblMujeres
            // 
            lblMujeres.AutoSize = true;
            lblMujeres.Location = new Point(22, 66);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(58, 15);
            lblMujeres.TabIndex = 0;
            lblMujeres.Text = "Mujeres : ";
            // 
            // txtVarones
            // 
            txtVarones.Location = new Point(76, 24);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(58, 23);
            txtVarones.TabIndex = 1;
            // 
            // txtMujeres
            // 
            txtMujeres.Location = new Point(76, 66);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(58, 23);
            txtMujeres.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(76, 137);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPVarones
            // 
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(140, 32);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(17, 15);
            lblPVarones.TabIndex = 0;
            lblPVarones.Text = "%";
            // 
            // lblPMujeres
            // 
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(140, 69);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(17, 15);
            lblPMujeres.TabIndex = 0;
            lblPMujeres.Text = "%";
            // 
            // lblVarones
            // 
            lblVarones.AutoSize = true;
            lblVarones.Location = new Point(22, 27);
            lblVarones.Name = "lblVarones";
            lblVarones.Size = new Size(57, 15);
            lblVarones.TabIndex = 0;
            lblVarones.Text = "Varones : ";
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(btnCalcular);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(lblPVarones);
            Controls.Add(lblPMujeres);
            Controls.Add(lblVarones);
            Controls.Add(lblMujeres);
            Name = "_01";
            Text = "_01";
     
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMujeres;
        private TextBox txtVarones;
        private TextBox txtMujeres;
       
      
        private Button btnCalcular;
        private Label lblPVarones;
      
        private Label lblPMujeres;
        private Label lblVarones;
    }
}