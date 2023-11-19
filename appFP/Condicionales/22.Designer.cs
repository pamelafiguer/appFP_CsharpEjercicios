namespace appFP.Condicionales
{
    partial class _22
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
            lblCA = new Label();
            lblCB = new Label();
            lblImporteA = new Label();
            lblImporteB = new Label();
            lblDescA = new Label();
            lblDescB = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            txtCB = new TextBox();
            txtImporteB = new TextBox();
            txtDescuentoB = new TextBox();
            txtTotal = new TextBox();
            txtCA = new TextBox();
            txtImporteA = new TextBox();
            txtDescuentoA = new TextBox();
            SuspendLayout();
            // 
            // lblCA
            // 
            lblCA.AutoSize = true;
            lblCA.Location = new Point(12, 53);
            lblCA.Name = "lblCA";
            lblCA.Size = new Size(72, 15);
            lblCA.TabIndex = 0;
            lblCA.Text = "Cantidad A :";
            // 
            // lblCB
            // 
            lblCB.AutoSize = true;
            lblCB.Location = new Point(192, 53);
            lblCB.Name = "lblCB";
            lblCB.Size = new Size(71, 15);
            lblCB.TabIndex = 0;
            lblCB.Text = "Cantidad B :";
            // 
            // lblImporteA
            // 
            lblImporteA.AutoSize = true;
            lblImporteA.Location = new Point(12, 113);
            lblImporteA.Name = "lblImporteA";
            lblImporteA.Size = new Size(66, 15);
            lblImporteA.TabIndex = 0;
            lblImporteA.Text = "Importe A :";
            // 
            // lblImporteB
            // 
            lblImporteB.AutoSize = true;
            lblImporteB.Location = new Point(192, 118);
            lblImporteB.Name = "lblImporteB";
            lblImporteB.Size = new Size(65, 15);
            lblImporteB.TabIndex = 0;
            lblImporteB.Text = "Importe B :";
            // 
            // lblDescA
            // 
            lblDescA.AutoSize = true;
            lblDescA.Location = new Point(12, 174);
            lblDescA.Name = "lblDescA";
            lblDescA.Size = new Size(80, 15);
            lblDescA.TabIndex = 0;
            lblDescA.Text = "Descuento A :";
            // 
            // lblDescB
            // 
            lblDescB.AutoSize = true;
            lblDescB.Location = new Point(192, 179);
            lblDescB.Name = "lblDescB";
            lblDescB.Size = new Size(79, 15);
            lblDescB.TabIndex = 0;
            lblDescB.Text = "Descuento B :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(73, 250);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total de ambos :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(127, 330);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 29);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCB
            // 
            txtCB.Location = new Point(269, 53);
            txtCB.Name = "txtCB";
            txtCB.Size = new Size(84, 23);
            txtCB.TabIndex = 2;
            txtCB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporteB
            // 
            txtImporteB.Location = new Point(269, 113);
            txtImporteB.Name = "txtImporteB";
            txtImporteB.ReadOnly = true;
            txtImporteB.Size = new Size(84, 23);
            txtImporteB.TabIndex = 4;
            txtImporteB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuentoB
            // 
            txtDescuentoB.Location = new Point(269, 174);
            txtDescuentoB.Name = "txtDescuentoB";
            txtDescuentoB.ReadOnly = true;
            txtDescuentoB.Size = new Size(84, 23);
            txtDescuentoB.TabIndex = 6;
            txtDescuentoB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(173, 247);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(84, 23);
            txtTotal.TabIndex = 7;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCA
            // 
            txtCA.Location = new Point(90, 50);
            txtCA.Name = "txtCA";
            txtCA.Size = new Size(84, 23);
            txtCA.TabIndex = 1;
            txtCA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporteA
            // 
            txtImporteA.CausesValidation = false;
            txtImporteA.Location = new Point(90, 110);
            txtImporteA.Name = "txtImporteA";
            txtImporteA.ReadOnly = true;
            txtImporteA.Size = new Size(84, 23);
            txtImporteA.TabIndex = 3;
            txtImporteA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuentoA
            // 
            txtDescuentoA.CausesValidation = false;
            txtDescuentoA.Location = new Point(90, 171);
            txtDescuentoA.Name = "txtDescuentoA";
            txtDescuentoA.ReadOnly = true;
            txtDescuentoA.Size = new Size(84, 23);
            txtDescuentoA.TabIndex = 5;
            txtDescuentoA.TextAlign = HorizontalAlignment.Right;
            // 
            // _22
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 384);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuentoA);
            Controls.Add(txtDescuentoB);
            Controls.Add(txtImporteA);
            Controls.Add(txtImporteB);
            Controls.Add(txtCA);
            Controls.Add(txtCB);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(lblDescB);
            Controls.Add(lblDescA);
            Controls.Add(lblImporteB);
            Controls.Add(lblImporteA);
            Controls.Add(lblCB);
            Controls.Add(lblCA);
            Name = "_22";
            Text = "_22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCA;
        private Label lblCB;
        private Label lblImporteA;
        private Label lblImporteB;
        private Label lblDescA;
        private Label lblDescB;
        private Label lblTotal;
        private Button btnCalcular;
        private TextBox txtCB;
        private TextBox txtImporteB;
        private TextBox txtDescuentoB;
        private TextBox txtTotal;
        private TextBox txtCA;
        private TextBox txtImporteA;
        private TextBox txtDescuentoA;
    }
}