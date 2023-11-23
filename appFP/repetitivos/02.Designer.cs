namespace appFP.repetitivos
{
    partial class _02
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
            lblN1 = new Label();
            lblProducto = new Label();
            lblN2 = new Label();
            txtMultiplicando = new TextBox();
            txtMultiplicador = new TextBox();
            txtProducto = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(40, 37);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(66, 15);
            lblN1.TabIndex = 0;
            lblN1.Text = "Número 1 :";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(40, 123);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(62, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto :";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(40, 80);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(66, 15);
            lblN2.TabIndex = 0;
            lblN2.Text = "Número 2 :";
            // 
            // txtMultiplicando
            // 
            txtMultiplicando.Location = new Point(112, 34);
            txtMultiplicando.Name = "txtMultiplicando";
            txtMultiplicando.Size = new Size(78, 23);
            txtMultiplicando.TabIndex = 1;
            txtMultiplicando.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMultiplicador
            // 
            txtMultiplicador.Location = new Point(112, 77);
            txtMultiplicador.Name = "txtMultiplicador";
            txtMultiplicador.Size = new Size(78, 23);
            txtMultiplicador.TabIndex = 2;
            txtMultiplicador.TextAlign = HorizontalAlignment.Right;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(112, 120);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(78, 23);
            txtProducto.TabIndex = 3;
            txtProducto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(54, 162);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(81, 28);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 220);
            Controls.Add(btnCalcular);
            Controls.Add(txtProducto);
            Controls.Add(txtMultiplicador);
            Controls.Add(txtMultiplicando);
            Controls.Add(lblN2);
            Controls.Add(lblProducto);
            Controls.Add(lblN1);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN1;
        private Label lblProducto;
        private Label lblN2;
        private TextBox txtMultiplicando;
        private TextBox txtMultiplicador;
        private TextBox txtProducto;
        private Button btnCalcular;
    }
}