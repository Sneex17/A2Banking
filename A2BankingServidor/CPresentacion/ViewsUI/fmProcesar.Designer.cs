namespace CPresentacion.ViewsUI
{
    partial class fmProcesar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmProcesar));
            LbTime = new Label();
            labelTexto = new Label();
            pbImg = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LbTime
            // 
            LbTime.AutoSize = true;
            LbTime.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            LbTime.ForeColor = Color.Gray;
            LbTime.Location = new Point(128, 54);
            LbTime.Name = "LbTime";
            LbTime.Size = new Size(163, 22);
            LbTime.TabIndex = 23;
            LbTime.Text = "Tiempo restante 3";
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 11F, FontStyle.Bold);
            labelTexto.ForeColor = Color.Black;
            labelTexto.Location = new Point(128, 19);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(122, 21);
            labelTexto.TabIndex = 22;
            labelTexto.Text = "Procesando . . ";
            // 
            // pbImg
            // 
            pbImg.Cursor = Cursors.Hand;
            pbImg.Location = new Point(11, 8);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(100, 100);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 21;
            pbImg.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(LbTime);
            panel1.Controls.Add(pbImg);
            panel1.Controls.Add(labelTexto);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 117);
            panel1.TabIndex = 24;
            // 
            // fmProcesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(77, 182, 198);
            ClientSize = new Size(384, 141);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmProcesar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Procesar";
            Load += fmProcesar_Load;
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LbTime;
        private Label labelTexto;
        private PictureBox pbImg;
        private Panel panel1;
    }
}