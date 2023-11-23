namespace appFP.repetitivos
{
    partial class _08
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
            lblBase = new Label();
            lblExponente = new Label();
            lblResultado = new Label();
            txtBase = new TextBox();
            txtExponente = new TextBox();
            txtPotencia = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(38, 31);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(37, 15);
            lblBase.TabIndex = 0;
            lblBase.Text = "Base :";
            // 
            // lblExponente
            // 
            lblExponente.AutoSize = true;
            lblExponente.Location = new Point(38, 77);
            lblExponente.Name = "lblExponente";
            lblExponente.Size = new Size(68, 15);
            lblExponente.TabIndex = 0;
            lblExponente.Text = "Exponente :";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(38, 126);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Potencia :";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(107, 28);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(78, 23);
            txtBase.TabIndex = 1;
            txtBase.TextAlign = HorizontalAlignment.Right;
            // 
            // txtExponente
            // 
            txtExponente.Location = new Point(107, 74);
            txtExponente.Name = "txtExponente";
            txtExponente.Size = new Size(78, 23);
            txtExponente.TabIndex = 2;
            txtExponente.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPotencia
            // 
            txtPotencia.Location = new Point(107, 123);
            txtPotencia.Name = "txtPotencia";
            txtPotencia.Size = new Size(78, 23);
            txtPotencia.TabIndex = 3;
            txtPotencia.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(59, 175);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 248);
            Controls.Add(btnCalcular);
            Controls.Add(txtPotencia);
            Controls.Add(txtExponente);
            Controls.Add(txtBase);
            Controls.Add(lblResultado);
            Controls.Add(lblExponente);
            Controls.Add(lblBase);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBase;
        private Label lblExponente;
        private Label lblResultado;
        private TextBox txtBase;
        private TextBox txtExponente;
        private TextBox txtPotencia;
        private Button btnCalcular;
    }
}