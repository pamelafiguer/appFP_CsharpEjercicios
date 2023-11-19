namespace appFP.Condicionales
{
    partial class _20
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
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lbLOrden = new Label();
            btnCalcular = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtOrden = new TextBox();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(43, 36);
            lblA.Name = "lblA";
            lblA.Size = new Size(66, 15);
            lblA.TabIndex = 0;
            lblA.Text = "Número 1 :";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(43, 75);
            lblB.Name = "lblB";
            lblB.Size = new Size(66, 15);
            lblB.TabIndex = 0;
            lblB.Text = "Número 2 :";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(43, 116);
            lblC.Name = "lblC";
            lblC.Size = new Size(66, 15);
            lblC.TabIndex = 0;
            lblC.Text = "Número 3 :";
            // 
            // lbLOrden
            // 
            lbLOrden.AutoSize = true;
            lbLOrden.Location = new Point(43, 158);
            lbLOrden.Name = "lbLOrden";
            lbLOrden.Size = new Size(46, 15);
            lbLOrden.TabIndex = 0;
            lbLOrden.Text = "Orden :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(70, 203);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 27);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(115, 33);
            txtA.Name = "txtA";
            txtA.Size = new Size(78, 23);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtB
            // 
            txtB.Location = new Point(115, 72);
            txtB.Name = "txtB";
            txtB.Size = new Size(78, 23);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtC
            // 
            txtC.Location = new Point(115, 113);
            txtC.Name = "txtC";
            txtC.Size = new Size(78, 23);
            txtC.TabIndex = 3;
            txtC.TextAlign = HorizontalAlignment.Right;
            // 
            // txtOrden
            // 
            txtOrden.Location = new Point(115, 155);
            txtOrden.Name = "txtOrden";
            txtOrden.ReadOnly = true;
            txtOrden.Size = new Size(78, 23);
            txtOrden.TabIndex = 4;
            txtOrden.TextAlign = HorizontalAlignment.Right;
            // 
            // _20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 252);
            Controls.Add(txtOrden);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnCalcular);
            Controls.Add(lbLOrden);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "_20";
            Text = "_20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lbLOrden;
        private Button btnCalcular;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtOrden;
    }
}