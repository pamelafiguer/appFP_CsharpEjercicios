namespace appFP.repetitivos
{
    partial class _11
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
            lblCopicuas = new Label();
            btnCalcular = new Button();
            txtCopicuas = new TextBox();
            SuspendLayout();
            // 
            // lblCopicuas
            // 
            lblCopicuas.AutoSize = true;
            lblCopicuas.Location = new Point(12, 42);
            lblCopicuas.Name = "lblCopicuas";
            lblCopicuas.Size = new Size(170, 15);
            lblCopicuas.TabIndex = 0;
            lblCopicuas.Text = "Numeros Copicuas de 3 cifras :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(129, 78);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 28);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCopicuas
            // 
            txtCopicuas.Location = new Point(188, 39);
            txtCopicuas.Name = "txtCopicuas";
            txtCopicuas.ReadOnly = true;
            txtCopicuas.Size = new Size(129, 23);
            txtCopicuas.TabIndex = 2;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 128);
            Controls.Add(txtCopicuas);
            Controls.Add(btnCalcular);
            Controls.Add(lblCopicuas);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCopicuas;
        private Button btnCalcular;
        private TextBox txtCopicuas;
    }
}