namespace appFP_NET.secuenciales
{
    partial class Frm01
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
            label1 = new Label();
            label2 = new Label();
            lblPVarones = new Label();
            lblPMujeres = new Label();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 49);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 130);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 0;
            label2.Text = "%";
            // 
            // lblPVarones
            // 
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(64, 49);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(51, 15);
            lblPVarones.TabIndex = 0;
            lblPVarones.Text = "Varones:";
            // 
            // lblPMujeres
            // 
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(64, 130);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(52, 15);
            lblPMujeres.TabIndex = 0;
            lblPMujeres.Text = "Mujeres:";
            // 
            // txtVarones
            // 
            txtVarones.Location = new Point(127, 41);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(101, 23);
            txtVarones.TabIndex = 1;
            txtVarones.TextChanged += txtVarones_TextChanged;
            // 
            // txtMujeres
            // 
            txtMujeres.Location = new Point(127, 122);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(101, 23);
            txtMujeres.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(108, 197);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // Frm01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 266);
            Controls.Add(btnCalcular);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(lblPMujeres);
            Controls.Add(label2);
            Controls.Add(lblPVarones);
            Controls.Add(label1);
            Name = "Frm01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblPVarones;
        private Label lblPMujeres;
        private TextBox txtVarones;
        private TextBox txtMujeres;
        private Button btnCalcular;
    }
}