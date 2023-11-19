namespace appFP.Condicionales
{
    partial class _25
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
            lblHijos = new Label();
            lblSueldo = new Label();
            lblBono = new Label();
            lblTotal = new Label();
            txtSueldoB = new TextBox();
            txtHijos = new TextBox();
            txtBono = new TextBox();
            txtTotal = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblHijos
            // 
            lblHijos.AutoSize = true;
            lblHijos.Location = new Point(43, 35);
            lblHijos.Name = "lblHijos";
            lblHijos.Size = new Size(40, 15);
            lblHijos.TabIndex = 0;
            lblHijos.Text = "Hijos :";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(43, 87);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(81, 15);
            lblSueldo.TabIndex = 0;
            lblSueldo.Text = "Sueldo Bruto :";
            // 
            // lblBono
            // 
            lblBono.AutoSize = true;
            lblBono.Location = new Point(43, 146);
            lblBono.Name = "lblBono";
            lblBono.Size = new Size(79, 15);
            lblBono.TabIndex = 0;
            lblBono.Text = "Bonificación :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(43, 204);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Sueldo Neto :";
            // 
            // txtSueldoB
            // 
            txtSueldoB.Location = new Point(132, 82);
            txtSueldoB.Name = "txtSueldoB";
            txtSueldoB.Size = new Size(85, 23);
            txtSueldoB.TabIndex = 2;
            txtSueldoB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHijos
            // 
            txtHijos.Location = new Point(132, 35);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(85, 23);
            txtHijos.TabIndex = 1;
            txtHijos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBono
            // 
            txtBono.Location = new Point(132, 143);
            txtBono.Name = "txtBono";
            txtBono.ReadOnly = true;
            txtBono.Size = new Size(85, 23);
            txtBono.TabIndex = 3;
            txtBono.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(132, 204);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(85, 23);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(70, 267);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 32);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _25
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 337);
            Controls.Add(btnCalcular);
            Controls.Add(txtHijos);
            Controls.Add(txtTotal);
            Controls.Add(txtBono);
            Controls.Add(txtSueldoB);
            Controls.Add(lblTotal);
            Controls.Add(lblBono);
            Controls.Add(lblSueldo);
            Controls.Add(lblHijos);
            Name = "_25";
            Text = "_25";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHijos;
        private Label lblSueldo;
        private Label lblBono;
        private Label lblTotal;
        private TextBox txtSueldoB;
        private TextBox txtHijos;
        private TextBox txtBono;
        private TextBox txtTotal;
        private Button btnCalcular;
    }
}