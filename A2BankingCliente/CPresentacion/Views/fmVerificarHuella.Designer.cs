namespace CPresentacion.Views
{
    partial class fmVerificarHuella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmVerificarHuella));
            panelInfo = new Panel();
            label6 = new Label();
            label9 = new Label();
            panelConatiner = new Panel();
            pbResultado = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbEstados = new Label();
            panelInfo.SuspendLayout();
            panelConatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(label6);
            panelInfo.Controls.Add(label9);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(430, 59);
            panelInfo.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Jumper PERSONAL USE ONLY Ex-Bd", 17F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(221, 15);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 15;
            label6.Text = "de huella";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Jumper PERSONAL USE ONLY Ex-Bd", 17F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.FromArgb(77, 182, 198);
            label9.Location = new Point(77, 15);
            label9.Name = "label9";
            label9.Size = new Size(147, 28);
            label9.TabIndex = 14;
            label9.Text = "Validación";
            // 
            // panelConatiner
            // 
            panelConatiner.BackColor = Color.White;
            panelConatiner.Controls.Add(pbResultado);
            panelConatiner.Controls.Add(label1);
            panelConatiner.Controls.Add(pictureBox1);
            panelConatiner.Controls.Add(lbEstados);
            panelConatiner.Dock = DockStyle.Fill;
            panelConatiner.Location = new Point(0, 59);
            panelConatiner.Name = "panelConatiner";
            panelConatiner.Size = new Size(430, 190);
            panelConatiner.TabIndex = 1;
            // 
            // pbResultado
            // 
            pbResultado.Location = new Point(176, 49);
            pbResultado.Name = "pbResultado";
            pbResultado.Size = new Size(75, 75);
            pbResultado.SizeMode = PictureBoxSizeMode.Zoom;
            pbResultado.TabIndex = 15;
            pbResultado.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 11F, FontStyle.Bold);
            label1.Location = new Point(176, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 14;
            label1.Text = "Resulado:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Huella;
            pictureBox1.Location = new Point(21, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lbEstados
            // 
            lbEstados.AutoSize = true;
            lbEstados.Font = new Font("Montserrat", 11F, FontStyle.Bold);
            lbEstados.Location = new Point(21, 141);
            lbEstados.Name = "lbEstados";
            lbEstados.Size = new Size(43, 21);
            lbEstados.TabIndex = 12;
            lbEstados.Text = "Text";
            // 
            // fmVerificarHuella
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 249);
            Controls.Add(panelConatiner);
            Controls.Add(panelInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmVerificarHuella";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Verificar huella";
            FormClosing += fmVerificarHuella_FormClosing;
            Load += fmVerificarHuella_Load;
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelConatiner.ResumeLayout(false);
            panelConatiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Panel panelConatiner;
        private Label label6;
        private Label label9;
        private PictureBox pictureBox1;
        private Label lbEstados;
        private PictureBox pbResultado;
        private Label label1;
    }
}