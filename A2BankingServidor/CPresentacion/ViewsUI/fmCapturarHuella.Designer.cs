namespace CPresentacion.ViewsUI
{
    partial class fmCapturarHuella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCapturarHuella));
            panelInformacion = new Panel();
            labelTexto = new Label();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            panelConatiner = new Panel();
            pbImagenHuella = new PictureBox();
            BuIniciar = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            label2 = new Label();
            lbEstados = new Label();
            barraProbreso = new ReaLTaiizor.Controls.CyberProgressBar();
            label4 = new Label();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            panelConatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenHuella).BeginInit();
            SuspendLayout();
            // 
            // panelInformacion
            // 
            panelInformacion.BackColor = Color.FromArgb(77, 182, 198);
            panelInformacion.Controls.Add(labelTexto);
            panelInformacion.Controls.Add(pbIcono);
            panelInformacion.Dock = DockStyle.Top;
            panelInformacion.Location = new Point(0, 0);
            panelInformacion.Name = "panelInformacion";
            panelInformacion.Size = new Size(602, 72);
            panelInformacion.TabIndex = 1;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(107, 19);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(256, 36);
            labelTexto.TabIndex = 7;
            labelTexto.Text = "Captura de huella";
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.Transparent;
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            pbIcono.IconColor = Color.White;
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 50;
            pbIcono.Location = new Point(51, 11);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(50, 50);
            pbIcono.TabIndex = 6;
            pbIcono.TabStop = false;
            // 
            // panelConatiner
            // 
            panelConatiner.BackColor = Color.White;
            panelConatiner.Controls.Add(label4);
            panelConatiner.Controls.Add(barraProbreso);
            panelConatiner.Controls.Add(lbEstados);
            panelConatiner.Controls.Add(label2);
            panelConatiner.Controls.Add(label1);
            panelConatiner.Controls.Add(BuIniciar);
            panelConatiner.Controls.Add(pbImagenHuella);
            panelConatiner.Dock = DockStyle.Fill;
            panelConatiner.Location = new Point(0, 72);
            panelConatiner.Name = "panelConatiner";
            panelConatiner.Size = new Size(602, 448);
            panelConatiner.TabIndex = 2;
            // 
            // pbImagenHuella
            // 
            pbImagenHuella.Location = new Point(51, 71);
            pbImagenHuella.Name = "pbImagenHuella";
            pbImagenHuella.Size = new Size(312, 270);
            pbImagenHuella.TabIndex = 4;
            pbImagenHuella.TabStop = false;
            // 
            // BuIniciar
            // 
            BuIniciar.Alpha = 20;
            BuIniciar.BackColor = Color.Transparent;
            BuIniciar.Background = true;
            BuIniciar.Background_WidthPen = 4F;
            BuIniciar.BackgroundPen = true;
            BuIniciar.ColorBackground = Color.FromArgb(77, 182, 198);
            BuIniciar.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuIniciar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuIniciar.ColorBackground_Pen = Color.DarkGray;
            BuIniciar.ColorLighting = Color.DarkGray;
            BuIniciar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuIniciar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuIniciar.Cursor = Cursors.Hand;
            BuIniciar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuIniciar.Effect_1 = true;
            BuIniciar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuIniciar.Effect_1_Transparency = 25;
            BuIniciar.Effect_2 = true;
            BuIniciar.Effect_2_ColorBackground = Color.White;
            BuIniciar.Effect_2_Transparency = 20;
            BuIniciar.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuIniciar.ForeColor = Color.FromArgb(245, 245, 245);
            BuIniciar.Lighting = false;
            BuIniciar.LinearGradient_Background = false;
            BuIniciar.LinearGradientPen = false;
            BuIniciar.Location = new Point(401, 71);
            BuIniciar.Name = "BuIniciar";
            BuIniciar.PenWidth = 15;
            BuIniciar.Rounding = true;
            BuIniciar.RoundingInt = 70;
            BuIniciar.Size = new Size(169, 50);
            BuIniciar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuIniciar.TabIndex = 5;
            BuIniciar.Tag = "Cyber";
            BuIniciar.TextButton = "Iniciar";
            BuIniciar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuIniciar.Timer_Effect_1 = 5;
            BuIniciar.Timer_RGB = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 33);
            label1.Name = "label1";
            label1.Size = new Size(174, 22);
            label1.TabIndex = 21;
            label1.Text = "Imagen de la huella";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(51, 367);
            label2.Name = "label2";
            label2.Size = new Size(127, 22);
            label2.TabIndex = 22;
            label2.Text = "Estado actual:";
            // 
            // lbEstados
            // 
            lbEstados.AutoSize = true;
            lbEstados.BackColor = Color.Transparent;
            lbEstados.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            lbEstados.ForeColor = Color.Black;
            lbEstados.Location = new Point(51, 392);
            lbEstados.Name = "lbEstados";
            lbEstados.Size = new Size(45, 22);
            lbEstados.TabIndex = 23;
            lbEstados.Text = "Text";
            // 
            // barraProbreso
            // 
            barraProbreso.Alpha = 50;
            barraProbreso.BackColor = Color.Transparent;
            barraProbreso.Background = true;
            barraProbreso.Background_WidthPen = 3F;
            barraProbreso.BackgroundPen = true;
            barraProbreso.ColorBackground = Color.FromArgb(37, 52, 68);
            barraProbreso.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            barraProbreso.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            barraProbreso.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            barraProbreso.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            barraProbreso.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            barraProbreso.ColorLighting = Color.FromArgb(29, 200, 238);
            barraProbreso.ColorPen_1 = Color.FromArgb(37, 52, 68);
            barraProbreso.ColorPen_2 = Color.FromArgb(41, 63, 86);
            barraProbreso.ColorProgressBar = Color.FromArgb(29, 200, 238);
            barraProbreso.ColorValue_Transparency = 200;
            barraProbreso.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            barraProbreso.Font = new Font("Arial", 11F);
            barraProbreso.ForeColor = Color.FromArgb(245, 245, 245);
            barraProbreso.Lighting = false;
            barraProbreso.LinearGradient_Background = false;
            barraProbreso.LinearGradient_Value = false;
            barraProbreso.LinearGradientPen = false;
            barraProbreso.Location = new Point(375, 181);
            barraProbreso.Maximum = 100;
            barraProbreso.Minimum = 0;
            barraProbreso.Name = "barraProbreso";
            barraProbreso.PenWidth = 10;
            barraProbreso.ProgressText = true;
            barraProbreso.RGB = false;
            barraProbreso.Rounding = true;
            barraProbreso.RoundingInt = 70;
            barraProbreso.Size = new Size(195, 34);
            barraProbreso.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            barraProbreso.StartDrawingValue = 0;
            barraProbreso.TabIndex = 24;
            barraProbreso.Tag = "Cyber";
            barraProbreso.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            barraProbreso.Timer_RGB = 300;
            barraProbreso.Value = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(375, 156);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 25;
            label4.Text = "Probreso";
            // 
            // fmCapturarHuella
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 520);
            Controls.Add(panelConatiner);
            Controls.Add(panelInformacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmCapturarHuella";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A1 Banking - Capturar Huella";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            panelConatiner.ResumeLayout(false);
            panelConatiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenHuella).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformacion;
        public Label labelTexto;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        private Panel panelConatiner;
        private PictureBox pbImagenHuella;
        private ReaLTaiizor.Controls.CyberButton BuIniciar;
        private Label lbEstados;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.CyberProgressBar barraProbreso;
        private Label label4;
    }
}