namespace appFP_NET.secuenciales
{
    partial class Frm09
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
            btnCalcular = new Button();
            txtSuma = new TextBox();
            txtNumero = new TextBox();
            lblSuma = new Label();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 229);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 29);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(147, 154);
            txtSuma.Name = "txtSuma";
            txtSuma.ReadOnly = true;
            txtSuma.Size = new Size(101, 23);
            txtSuma.TabIndex = 9;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(147, 73);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(101, 23);
            txtNumero.TabIndex = 8;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(84, 162);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(43, 15);
            lblSuma.TabIndex = 4;
            lblSuma.Text = "Suma :";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(84, 81);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Numero :";
            // 
            // Frm09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 330);
            Controls.Add(btnCalcular);
            Controls.Add(txtSuma);
            Controls.Add(txtNumero);
            Controls.Add(lblSuma);
            Controls.Add(lblNumero);
            Name = "Frm09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtSuma;
        private TextBox txtNumero;
        private Label lblSuma;
        private Label lblNumero;
    }
}