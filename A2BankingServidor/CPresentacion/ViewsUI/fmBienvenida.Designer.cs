namespace CPresentacion.ViewsUI
{
    partial class fmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmBienvenida));
            pbImg = new PictureBox();
            labelTexto = new Label();
            LbNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            SuspendLayout();
            // 
            // pbImg
            // 
            pbImg.Cursor = Cursors.Hand;
            pbImg.Location = new Point(12, 12);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(140, 140);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 18;
            pbImg.TabStop = false;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.FromArgb(77, 182, 198);
            labelTexto.Location = new Point(158, 12);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(180, 36);
            labelTexto.TabIndex = 19;
            labelTexto.Text = "Bienvenid@";
            // 
            // LbNombre
            // 
            LbNombre.AutoSize = true;
            LbNombre.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            LbNombre.ForeColor = Color.Gray;
            LbNombre.Location = new Point(158, 48);
            LbNombre.Name = "LbNombre";
            LbNombre.Size = new Size(72, 36);
            LbNombre.TabIndex = 20;
            LbNombre.Text = "Text";
            // 
            // fmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 161);
            Controls.Add(LbNombre);
            Controls.Add(labelTexto);
            Controls.Add(pbImg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Bienvenida";
            Load += fmBienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImg;
        public Label labelTexto;
        public Label LbNombre;
    }
}