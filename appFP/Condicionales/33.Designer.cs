namespace appFP.Condicionales
{
    partial class _33
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
            lblMinutos = new Label();
            lblObs = new Label();
            lblPuntajeP = new Label();
            lblPuntajeObs = new Label();
            lblPTotal = new Label();
            lblBono = new Label();
            txtMin = new TextBox();
            txtObs = new TextBox();
            txtPuntual = new TextBox();
            txtPObs = new TextBox();
            txtTotal = new TextBox();
            txtBono = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Location = new Point(32, 43);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(57, 15);
            lblMinutos.TabIndex = 0;
            lblMinutos.Text = "Minutos :";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(32, 97);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(90, 15);
            lblObs.TabIndex = 0;
            lblObs.Text = "Observaciones :";
            // 
            // lblPuntajeP
            // 
            lblPuntajeP.AutoSize = true;
            lblPuntajeP.Location = new Point(32, 151);
            lblPuntajeP.Name = "lblPuntajeP";
            lblPuntajeP.Size = new Size(97, 15);
            lblPuntajeP.TabIndex = 0;
            lblPuntajeP.Text = "Puntaje Puntual :";
            // 
            // lblPuntajeObs
            // 
            lblPuntajeObs.AutoSize = true;
            lblPuntajeObs.Location = new Point(32, 204);
            lblPuntajeObs.Name = "lblPuntajeObs";
            lblPuntajeObs.Size = new Size(75, 15);
            lblPuntajeObs.TabIndex = 0;
            lblPuntajeObs.Text = "Puntaje obs :";
            // 
            // lblPTotal
            // 
            lblPTotal.AutoSize = true;
            lblPTotal.Location = new Point(32, 256);
            lblPTotal.Name = "lblPTotal";
            lblPTotal.Size = new Size(80, 15);
            lblPTotal.TabIndex = 0;
            lblPTotal.Text = "Puntaje total :";
            // 
            // lblBono
            // 
            lblBono.AutoSize = true;
            lblBono.Location = new Point(32, 304);
            lblBono.Name = "lblBono";
            lblBono.Size = new Size(79, 15);
            lblBono.TabIndex = 0;
            lblBono.Text = "Bonificación :";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(139, 40);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 1;
            txtMin.TextAlign = HorizontalAlignment.Right;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(139, 94);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(100, 23);
            txtObs.TabIndex = 2;
            txtObs.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPuntual
            // 
            txtPuntual.Location = new Point(139, 148);
            txtPuntual.Name = "txtPuntual";
            txtPuntual.ReadOnly = true;
            txtPuntual.Size = new Size(100, 23);
            txtPuntual.TabIndex = 3;
            txtPuntual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPObs
            // 
            txtPObs.Location = new Point(139, 201);
            txtPObs.Name = "txtPObs";
            txtPObs.ReadOnly = true;
            txtPObs.Size = new Size(100, 23);
            txtPObs.TabIndex = 4;
            txtPObs.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(139, 253);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBono
            // 
            txtBono.Location = new Point(139, 301);
            txtBono.Name = "txtBono";
            txtBono.ReadOnly = true;
            txtBono.Size = new Size(100, 23);
            txtBono.TabIndex = 6;
            txtBono.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(76, 353);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 33);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _33
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 414);
            Controls.Add(btnCalcular);
            Controls.Add(txtBono);
            Controls.Add(txtTotal);
            Controls.Add(txtPObs);
            Controls.Add(txtPuntual);
            Controls.Add(txtObs);
            Controls.Add(txtMin);
            Controls.Add(lblBono);
            Controls.Add(lblPTotal);
            Controls.Add(lblPuntajeObs);
            Controls.Add(lblPuntajeP);
            Controls.Add(lblObs);
            Controls.Add(lblMinutos);
            Name = "_33";
            Text = "_33";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinutos;
        private Label lblObs;
        private Label lblPuntajeP;
        private Label lblPuntajeObs;
        private Label lblPTotal;
        private Label lblBono;
        private TextBox txtMin;
        private TextBox txtObs;
        private TextBox txtPuntual;
        private TextBox txtPObs;
        private TextBox txtTotal;
        private TextBox txtBono;
        private Button btnCalcular;
    }
}