namespace appFP.repetitivos
{
    partial class _10
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(35, 37);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(131, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Números encontrados :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(172, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(145, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(57, 73);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.ScrollBars = ScrollBars.Vertical;
            txtRpta.Size = new Size(175, 189);
            txtRpta.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(79, 289);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 28);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 329);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}