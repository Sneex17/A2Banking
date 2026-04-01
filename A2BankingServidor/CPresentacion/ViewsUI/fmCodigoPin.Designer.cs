namespace CPresentacion.ViewsUI
{
    partial class fmCodigoPin
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
            panelConatiner = new Panel();
            lbMensaje = new Label();
            BuVerPin = new FontAwesome.Sharp.IconPictureBox();
            textbPinConfirmacion = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            textbPin = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            BuGuardar = new ReaLTaiizor.Controls.CyberButton();
            panelInformacion = new Panel();
            labelTexto = new Label();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            panelConatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BuVerPin).BeginInit();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelConatiner
            // 
            panelConatiner.BackColor = Color.White;
            panelConatiner.Controls.Add(lbMensaje);
            panelConatiner.Controls.Add(BuVerPin);
            panelConatiner.Controls.Add(textbPinConfirmacion);
            panelConatiner.Controls.Add(label3);
            panelConatiner.Controls.Add(textbPin);
            panelConatiner.Controls.Add(label1);
            panelConatiner.Controls.Add(BuGuardar);
            panelConatiner.Dock = DockStyle.Fill;
            panelConatiner.Location = new Point(0, 72);
            panelConatiner.Name = "panelConatiner";
            panelConatiner.Size = new Size(453, 314);
            panelConatiner.TabIndex = 4;
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
            // BuVerPin
            // 
            BuVerPin.BackColor = Color.Transparent;
            BuVerPin.Cursor = Cursors.Hand;
            BuVerPin.ForeColor = Color.Gray;
            BuVerPin.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BuVerPin.IconColor = Color.Gray;
            BuVerPin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BuVerPin.IconSize = 40;
            BuVerPin.Location = new Point(301, 53);
            BuVerPin.Name = "BuVerPin";
            BuVerPin.Size = new Size(50, 40);
            BuVerPin.TabIndex = 8;
            BuVerPin.TabStop = false;
            BuVerPin.Click += BuVerPin_Click;
            // 
            // textbPinConfirmacion
            // 
            textbPinConfirmacion.BackColor = Color.Transparent;
            textbPinConfirmacion.BorderColor = Color.FromArgb(180, 180, 180);
            textbPinConfirmacion.EdgeColor = Color.White;
            textbPinConfirmacion.Font = new Font("Tahoma", 12F);
            textbPinConfirmacion.ForeColor = Color.Black;
            textbPinConfirmacion.Location = new Point(101, 126);
            textbPinConfirmacion.MaxLength = 32767;
            textbPinConfirmacion.Multiline = false;
            textbPinConfirmacion.Name = "textbPinConfirmacion";
            textbPinConfirmacion.ReadOnly = false;
            textbPinConfirmacion.Size = new Size(194, 30);
            textbPinConfirmacion.TabIndex = 30;
            textbPinConfirmacion.TextAlignment = HorizontalAlignment.Left;
            textbPinConfirmacion.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(101, 96);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 29;
            label3.Text = "Confirmación";
            // 
            // textbPin
            // 
            textbPin.BackColor = Color.Transparent;
            textbPin.BorderColor = Color.FromArgb(180, 180, 180);
            textbPin.EdgeColor = Color.White;
            textbPin.Font = new Font("Tahoma", 12F);
            textbPin.ForeColor = Color.Black;
            textbPin.Location = new Point(101, 55);
            textbPin.MaxLength = 32767;
            textbPin.Multiline = false;
            textbPin.Name = "textbPin";
            textbPin.ReadOnly = false;
            textbPin.Size = new Size(194, 30);
            textbPin.TabIndex = 28;
            textbPin.TextAlignment = HorizontalAlignment.Left;
            textbPin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(101, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 22);
            label1.TabIndex = 21;
            label1.Text = "Código Pin";
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
            BuGuardar.Location = new Point(142, 231);
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
            panelInformacion.Size = new Size(453, 72);
            panelInformacion.TabIndex = 3;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(94, 19);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(321, 36);
            labelTexto.TabIndex = 7;
            labelTexto.Text = "Captura de código PIN";
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.Transparent;
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            pbIcono.IconColor = Color.White;
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 50;
            pbIcono.Location = new Point(38, 11);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(50, 50);
            pbIcono.TabIndex = 6;
            pbIcono.TabStop = false;
            // 
            // fmCodigoPin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 386);
            Controls.Add(panelConatiner);
            Controls.Add(panelInformacion);
            Name = "fmCodigoPin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Captura del código Pin";
            panelConatiner.ResumeLayout(false);
            panelConatiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BuVerPin).EndInit();
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConatiner;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton BuGuardar;
        private Panel panelInformacion;
        public Label labelTexto;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        private ReaLTaiizor.Controls.DungeonTextBox textbPinConfirmacion;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox textbPin;
        private FontAwesome.Sharp.IconPictureBox BuVerPin;
        private Label lbMensaje;
    }
}