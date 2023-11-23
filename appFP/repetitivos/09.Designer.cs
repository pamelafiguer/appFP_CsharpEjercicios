namespace appFP.repetitivos
{
    partial class _09
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
            lblAncho = new Label();
            txtAncho = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Location = new Point(28, 32);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(48, 15);
            lblAncho.TabIndex = 0;
            lblAncho.Text = "Ancho :";
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(84, 29);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(100, 23);
            txtAncho.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(38, 73);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.RightToLeft = RightToLeft.No;
            txtRpta.ScrollBars = ScrollBars.Vertical;
            txtRpta.Size = new Size(201, 179);
            txtRpta.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(84, 269);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 304);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtAncho);
            Controls.Add(lblAncho);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAncho;
        private TextBox txtAncho;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}