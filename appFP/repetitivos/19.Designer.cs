namespace appFP.repetitivos
{
    partial class _19
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
            lblAleatorio = new Label();
            txtNumero = new TextBox();
            txtPanel = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblAleatorio
            // 
            lblAleatorio.AutoSize = true;
            lblAleatorio.Location = new Point(39, 33);
            lblAleatorio.Name = "lblAleatorio";
            lblAleatorio.Size = new Size(57, 15);
            lblAleatorio.TabIndex = 0;
            lblAleatorio.Text = "Número :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(108, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtPanel
            // 
            txtPanel.Location = new Point(39, 72);
            txtPanel.Multiline = true;
            txtPanel.Name = "txtPanel";
            txtPanel.ReadOnly = true;
            txtPanel.ScrollBars = ScrollBars.Vertical;
            txtPanel.Size = new Size(201, 148);
            txtPanel.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(68, 240);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 285);
            Controls.Add(btnCalcular);
            Controls.Add(txtPanel);
            Controls.Add(txtNumero);
            Controls.Add(lblAleatorio);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAleatorio;
        private TextBox txtNumero;
        private TextBox txtPanel;
        private Button btnCalcular;
    }
}