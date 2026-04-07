namespace CPresentacion.ViewsUI
{
    partial class fmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCorreo));
            panelConatiner = new Panel();
            BuConfirmar = new FontAwesome.Sharp.IconPictureBox();
            lbMensaje = new Label();
            BuSendCode = new FontAwesome.Sharp.IconPictureBox();
            textbCodigo = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            textbCorreo = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            BuGuardar = new ReaLTaiizor.Controls.CyberButton();
            panelInformacion = new Panel();
            labelTexto = new Label();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            panelConatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BuConfirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuSendCode).BeginInit();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelConatiner
            // 
            panelConatiner.BackColor = Color.White;
            panelConatiner.Controls.Add(BuConfirmar);
            panelConatiner.Controls.Add(lbMensaje);
            panelConatiner.Controls.Add(BuSendCode);
            panelConatiner.Controls.Add(textbCodigo);
            panelConatiner.Controls.Add(label3);
            panelConatiner.Controls.Add(textbCorreo);
            panelConatiner.Controls.Add(label1);
            panelConatiner.Controls.Add(BuGuardar);
            panelConatiner.Dock = DockStyle.Fill;
            panelConatiner.Location = new Point(0, 72);
            panelConatiner.Name = "panelConatiner";
            panelConatiner.Size = new Size(416, 316);
            panelConatiner.TabIndex = 6;
            // 
            // BuConfirmar
            // 
            BuConfirmar.BackColor = Color.Transparent;
            BuConfirmar.Cursor = Cursors.Hand;
            BuConfirmar.ForeColor = Color.Gray;
            BuConfirmar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            BuConfirmar.IconColor = Color.Gray;
            BuConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BuConfirmar.IconSize = 40;
            BuConfirmar.Location = new Point(283, 126);
            BuConfirmar.Name = "BuConfirmar";
            BuConfirmar.Size = new Size(50, 40);
            BuConfirmar.TabIndex = 32;
            BuConfirmar.TabStop = false;
            BuConfirmar.Click += BuConfirmar_Click;
            // 
            // lbMensaje
            // 
            lbMensaje.AutoSize = true;
            lbMensaje.BackColor = Color.Transparent;
            lbMensaje.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold | FontStyle.Italic);
            lbMensaje.ForeColor = Color.Black;
            lbMensaje.Location = new Point(38, 183);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(42, 21);
            lbMensaje.TabIndex = 31;
            lbMensaje.Text = "Text";
            lbMensaje.Visible = false;
            // 
            // BuSendCode
            // 
            BuSendCode.BackColor = Color.Transparent;
            BuSendCode.Cursor = Cursors.Hand;
            BuSendCode.ForeColor = Color.Gray;
            BuSendCode.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            BuSendCode.IconColor = Color.Gray;
            BuSendCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BuSendCode.IconSize = 40;
            BuSendCode.Location = new Point(283, 53);
            BuSendCode.Name = "BuSendCode";
            BuSendCode.Size = new Size(50, 40);
            BuSendCode.TabIndex = 8;
            BuSendCode.TabStop = false;
            BuSendCode.Click += BuSendCode_Click;
            // 
            // textbCodigo
            // 
            textbCodigo.BackColor = Color.Transparent;
            textbCodigo.BorderColor = Color.FromArgb(180, 180, 180);
            textbCodigo.EdgeColor = Color.White;
            textbCodigo.Font = new Font("Tahoma", 12F);
            textbCodigo.ForeColor = Color.Black;
            textbCodigo.Location = new Point(83, 126);
            textbCodigo.MaxLength = 32767;
            textbCodigo.Multiline = false;
            textbCodigo.Name = "textbCodigo";
            textbCodigo.ReadOnly = false;
            textbCodigo.Size = new Size(194, 30);
            textbCodigo.TabIndex = 30;
            textbCodigo.TextAlignment = HorizontalAlignment.Left;
            textbCodigo.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(83, 96);
            label3.Name = "label3";
            label3.Size = new Size(195, 22);
            label3.TabIndex = 29;
            label3.Text = "Código de verificación";
            // 
            // textbCorreo
            // 
            textbCorreo.BackColor = Color.Transparent;
            textbCorreo.BorderColor = Color.FromArgb(180, 180, 180);
            textbCorreo.EdgeColor = Color.White;
            textbCorreo.Font = new Font("Tahoma", 12F);
            textbCorreo.ForeColor = Color.Black;
            textbCorreo.Location = new Point(83, 55);
            textbCorreo.MaxLength = 32767;
            textbCorreo.Multiline = false;
            textbCorreo.Name = "textbCorreo";
            textbCorreo.ReadOnly = false;
            textbCorreo.Size = new Size(194, 30);
            textbCorreo.TabIndex = 28;
            textbCorreo.TextAlignment = HorizontalAlignment.Left;
            textbCorreo.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(83, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 22);
            label1.TabIndex = 21;
            label1.Text = "Correo";
            // 
            // BuGuardar
            // 
            BuGuardar.Alpha = 20;
            BuGuardar.BackColor = Color.Transparent;
            BuGuardar.Background = true;
            BuGuardar.Background_WidthPen = 4F;
            BuGuardar.BackgroundPen = true;
            BuGuardar.ColorBackground = Color.FromArgb(77, 182, 198);
            BuGuardar.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuGuardar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuGuardar.ColorBackground_Pen = Color.DarkGray;
            BuGuardar.ColorLighting = Color.DarkGray;
            BuGuardar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuGuardar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuGuardar.Cursor = Cursors.Hand;
            BuGuardar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuGuardar.Effect_1 = true;
            BuGuardar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuGuardar.Effect_1_Transparency = 25;
            BuGuardar.Effect_2 = true;
            BuGuardar.Effect_2_ColorBackground = Color.White;
            BuGuardar.Effect_2_Transparency = 20;
            BuGuardar.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuGuardar.ForeColor = Color.FromArgb(245, 245, 245);
            BuGuardar.Lighting = false;
            BuGuardar.LinearGradient_Background = false;
            BuGuardar.LinearGradientPen = false;
            BuGuardar.Location = new Point(124, 231);
            BuGuardar.Name = "BuGuardar";
            BuGuardar.PenWidth = 15;
            BuGuardar.Rounding = true;
            BuGuardar.RoundingInt = 70;
            BuGuardar.Size = new Size(169, 50);
            BuGuardar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuGuardar.TabIndex = 5;
            BuGuardar.Tag = "Cyber";
            BuGuardar.TextButton = "Guardar";
            BuGuardar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuGuardar.Timer_Effect_1 = 5;
            BuGuardar.Timer_RGB = 300;
            BuGuardar.Click += BuGuardar_Click;
            // 
            // panelInformacion
            // 
            panelInformacion.BackColor = Color.FromArgb(77, 182, 198);
            panelInformacion.Controls.Add(labelTexto);
            panelInformacion.Controls.Add(pbIcono);
            panelInformacion.Dock = DockStyle.Top;
            panelInformacion.Location = new Point(0, 0);
            panelInformacion.Name = "panelInformacion";
            panelInformacion.Size = new Size(416, 72);
            panelInformacion.TabIndex = 5;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(94, 19);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(204, 36);
            labelTexto.TabIndex = 7;
            labelTexto.Text = "Validar correo";
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.Transparent;
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            pbIcono.IconColor = Color.White;
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 50;
            pbIcono.Location = new Point(38, 11);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(50, 50);
            pbIcono.TabIndex = 6;
            pbIcono.TabStop = false;
            // 
            // fmCorreo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 388);
            Controls.Add(panelConatiner);
            Controls.Add(panelInformacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmCorreo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Validar Correo";
            panelConatiner.ResumeLayout(false);
            panelConatiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BuConfirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuSendCode).EndInit();
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConatiner;
        private Label lbMensaje;
        private FontAwesome.Sharp.IconPictureBox BuSendCode;
        private ReaLTaiizor.Controls.DungeonTextBox textbCodigo;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox textbCorreo;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton BuGuardar;
        private Panel panelInformacion;
        public Label labelTexto;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        private FontAwesome.Sharp.IconPictureBox BuConfirmar;
    }
}