namespace appFP.Condicionales
{
    partial class _37
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
            lblPamela = new Label();
            lblCarol = new Label();
            lblGanadora = new Label();
            lblSegundo = new Label();
            txtPamela = new TextBox();
            lblFanny = new Label();
            lblTercero = new Label();
            txtFanny = new TextBox();
            txtCarol = new TextBox();
            txtGanadora = new TextBox();
            txtSegundo = new TextBox();
            txtTercero = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblPamela
            // 
            lblPamela.AutoSize = true;
            lblPamela.Location = new Point(44, 34);
            lblPamela.Name = "lblPamela";
            lblPamela.Size = new Size(84, 15);
            lblPamela.TabIndex = 0;
            lblPamela.Text = "Votos Pamela :";
            // 
            // lblCarol
            // 
            lblCarol.AutoSize = true;
            lblCarol.Location = new Point(44, 95);
            lblCarol.Name = "lblCarol";
            lblCarol.Size = new Size(73, 15);
            lblCarol.TabIndex = 0;
            lblCarol.Text = "Votos Carol :";
            // 
            // lblGanadora
            // 
            lblGanadora.AutoSize = true;
            lblGanadora.Location = new Point(44, 192);
            lblGanadora.Name = "lblGanadora";
            lblGanadora.Size = new Size(67, 15);
            lblGanadora.TabIndex = 0;
            lblGanadora.Text = "Ganadora : ";
            // 
            // lblSegundo
            // 
            lblSegundo.AutoSize = true;
            lblSegundo.Location = new Point(44, 242);
            lblSegundo.Name = "lblSegundo";
            lblSegundo.Size = new Size(60, 15);
            lblSegundo.TabIndex = 0;
            lblSegundo.Text = "Segundo :";
            // 
            // txtPamela
            // 
            txtPamela.Location = new Point(134, 34);
            txtPamela.Name = "txtPamela";
            txtPamela.Size = new Size(78, 23);
            txtPamela.TabIndex = 1;
            txtPamela.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFanny
            // 
            lblFanny.AutoSize = true;
            lblFanny.Location = new Point(44, 148);
            lblFanny.Name = "lblFanny";
            lblFanny.Size = new Size(77, 15);
            lblFanny.TabIndex = 0;
            lblFanny.Text = "Votos Fanny :";
            // 
            // lblTercero
            // 
            lblTercero.AutoSize = true;
            lblTercero.Location = new Point(44, 290);
            lblTercero.Name = "lblTercero";
            lblTercero.Size = new Size(52, 15);
            lblTercero.TabIndex = 0;
            lblTercero.Text = "Tercero :";
            // 
            // txtFanny
            // 
            txtFanny.Location = new Point(134, 148);
            txtFanny.Name = "txtFanny";
            txtFanny.Size = new Size(78, 23);
            txtFanny.TabIndex = 3;
            txtFanny.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCarol
            // 
            txtCarol.Location = new Point(134, 95);
            txtCarol.Name = "txtCarol";
            txtCarol.Size = new Size(78, 23);
            txtCarol.TabIndex = 2;
            txtCarol.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGanadora
            // 
            txtGanadora.Location = new Point(134, 192);
            txtGanadora.Name = "txtGanadora";
            txtGanadora.ReadOnly = true;
            txtGanadora.Size = new Size(103, 23);
            txtGanadora.TabIndex = 4;
            txtGanadora.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(134, 242);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.ReadOnly = true;
            txtSegundo.Size = new Size(103, 23);
            txtSegundo.TabIndex = 5;
            txtSegundo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTercero
            // 
            txtTercero.Location = new Point(134, 290);
            txtTercero.Name = "txtTercero";
            txtTercero.ReadOnly = true;
            txtTercero.Size = new Size(103, 23);
            txtTercero.TabIndex = 6;
            txtTercero.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(78, 337);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 30);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _37
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 416);
            Controls.Add(btnCalcular);
            Controls.Add(txtCarol);
            Controls.Add(txtTercero);
            Controls.Add(txtSegundo);
            Controls.Add(txtGanadora);
            Controls.Add(txtFanny);
            Controls.Add(txtPamela);
            Controls.Add(lblTercero);
            Controls.Add(lblSegundo);
            Controls.Add(lblFanny);
            Controls.Add(lblGanadora);
            Controls.Add(lblCarol);
            Controls.Add(lblPamela);
            Name = "_37";
            Text = "_37";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPamela;
        private Label lblCarol;
        private Label lblGanadora;
        private Label lblSegundo;
        private TextBox txtPamela;
        private Label lblFanny;
        private Label lblTercero;
        private TextBox txtFanny;
        private TextBox txtCarol;
        private TextBox txtGanadora;
        private TextBox txtSegundo;
        private TextBox txtTercero;
        private Button btnCalcular;
    }
}