namespace appFP.repetitivos
{
    partial class _17
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
            lblTexto = new Label();
            lblSubTexto = new Label();
            lblResultado = new Label();
            txtTexto = new TextBox();
            txtResultado = new TextBox();
            txtSub = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(34, 36);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(41, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto :";
            // 
            // lblSubTexto
            // 
            lblSubTexto.AutoSize = true;
            lblSubTexto.Location = new Point(34, 84);
            lblSubTexto.Name = "lblSubTexto";
            lblSubTexto.Size = new Size(62, 15);
            lblSubTexto.TabIndex = 0;
            lblSubTexto.Text = "Sub texto :";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(34, 131);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado :";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(102, 33);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(120, 23);
            txtTexto.TabIndex = 1;
            txtTexto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(102, 128);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(120, 23);
            txtResultado.TabIndex = 3;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSub
            // 
            txtSub.Location = new Point(102, 81);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(120, 23);
            txtSub.TabIndex = 2;
            txtSub.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(73, 178);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 25);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 224);
            Controls.Add(btnCalcular);
            Controls.Add(txtSub);
            Controls.Add(txtResultado);
            Controls.Add(txtTexto);
            Controls.Add(lblResultado);
            Controls.Add(lblSubTexto);
            Controls.Add(lblTexto);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Label lblSubTexto;
        private Label lblResultado;
        private TextBox txtTexto;
        private TextBox txtResultado;
        private TextBox txtSub;
        private Button btnCalcular;
    }
}