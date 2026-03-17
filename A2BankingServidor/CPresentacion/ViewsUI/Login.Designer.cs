namespace CPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFondo = new Panel();
            label4 = new Label();
            label1 = new Label();
            gbContainer = new ReaLTaiizor.Controls.CyberGroupBox();
            BuVerPassword = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            textbPassword = new ReaLTaiizor.Controls.BigTextBox();
            pbPassword = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            textbUsuario = new ReaLTaiizor.Controls.BigTextBox();
            pbUsername = new FontAwesome.Sharp.IconPictureBox();
            BuAcceder = new ReaLTaiizor.Controls.CyberButton();
            panelFondo.SuspendLayout();
            gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BuVerPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.WhiteSmoke;
            panelFondo.Controls.Add(label4);
            panelFondo.Controls.Add(label1);
            panelFondo.Controls.Add(gbContainer);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(784, 461);
            panelFondo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Jumper PERSONAL USE ONLY Ex-Bd", 22F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(398, 30);
            label4.Name = "label4";
            label4.Size = new Size(147, 36);
            label4.TabIndex = 2;
            label4.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Jumper PERSONAL USE ONLY Ex-Bd", 22F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(77, 182, 198);
            label1.Location = new Point(239, 30);
            label1.Name = "label1";
            label1.Size = new Size(153, 36);
            label1.TabIndex = 0;
            label1.Text = "Banking";
            // 
            // gbContainer
            // 
            gbContainer.Alpha = 20;
            gbContainer.BackColor = Color.Transparent;
            gbContainer.Background = true;
            gbContainer.Background_WidthPen = 3F;
            gbContainer.BackgroundPen = true;
            gbContainer.ColorBackground = Color.White;
            gbContainer.ColorBackground_1 = Color.White;
            gbContainer.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            gbContainer.ColorBackground_Pen = Color.DarkGray;
            gbContainer.ColorLighting = Color.DarkGray;
            gbContainer.ColorPen_1 = Color.FromArgb(37, 52, 68);
            gbContainer.ColorPen_2 = Color.FromArgb(41, 63, 86);
            gbContainer.Controls.Add(BuVerPassword);
            gbContainer.Controls.Add(label3);
            gbContainer.Controls.Add(textbPassword);
            gbContainer.Controls.Add(pbPassword);
            gbContainer.Controls.Add(label2);
            gbContainer.Controls.Add(textbUsuario);
            gbContainer.Controls.Add(pbUsername);
            gbContainer.Controls.Add(BuAcceder);
            gbContainer.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            gbContainer.ForeColor = Color.FromArgb(245, 245, 245);
            gbContainer.Lighting = false;
            gbContainer.LinearGradient_Background = false;
            gbContainer.LinearGradientPen = false;
            gbContainer.Location = new Point(183, 83);
            gbContainer.Name = "gbContainer";
            gbContainer.PenWidth = 15;
            gbContainer.RGB = false;
            gbContainer.Rounding = true;
            gbContainer.RoundingInt = 17;
            gbContainer.Size = new Size(418, 305);
            gbContainer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gbContainer.TabIndex = 1;
            gbContainer.Tag = "Cyber";
            gbContainer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            gbContainer.Timer_RGB = 300;
            // 
            // BuVerPassword
            // 
            BuVerPassword.BackColor = Color.Transparent;
            BuVerPassword.Cursor = Cursors.Hand;
            BuVerPassword.ForeColor = Color.Gray;
            BuVerPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BuVerPassword.IconColor = Color.Gray;
            BuVerPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BuVerPassword.IconSize = 50;
            BuVerPassword.Location = new Point(327, 158);
            BuVerPassword.Name = "BuVerPassword";
            BuVerPassword.Size = new Size(50, 50);
            BuVerPassword.TabIndex = 6;
            BuVerPassword.TabStop = false;
            BuVerPassword.Click += BuVerPassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(97, 134);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // textbPassword
            // 
            textbPassword.BackColor = Color.Transparent;
            textbPassword.Font = new Font("Tahoma", 11F);
            textbPassword.ForeColor = Color.DimGray;
            textbPassword.Image = null;
            textbPassword.Location = new Point(97, 158);
            textbPassword.MaxLength = 32767;
            textbPassword.Multiline = false;
            textbPassword.Name = "textbPassword";
            textbPassword.ReadOnly = false;
            textbPassword.Size = new Size(224, 41);
            textbPassword.TabIndex = 4;
            textbPassword.TextAlignment = HorizontalAlignment.Left;
            textbPassword.UseSystemPasswordChar = false;
            // 
            // pbPassword
            // 
            pbPassword.BackColor = Color.Transparent;
            pbPassword.ForeColor = Color.Gray;
            pbPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            pbPassword.IconColor = Color.Gray;
            pbPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbPassword.IconSize = 50;
            pbPassword.Location = new Point(41, 158);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(50, 50);
            pbPassword.TabIndex = 3;
            pbPassword.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(97, 54);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // textbUsuario
            // 
            textbUsuario.BackColor = Color.Transparent;
            textbUsuario.Font = new Font("Tahoma", 11F);
            textbUsuario.ForeColor = Color.DimGray;
            textbUsuario.Image = null;
            textbUsuario.Location = new Point(97, 78);
            textbUsuario.MaxLength = 32767;
            textbUsuario.Multiline = false;
            textbUsuario.Name = "textbUsuario";
            textbUsuario.ReadOnly = false;
            textbUsuario.Size = new Size(224, 41);
            textbUsuario.TabIndex = 2;
            textbUsuario.TextAlignment = HorizontalAlignment.Left;
            textbUsuario.UseSystemPasswordChar = false;
            // 
            // pbUsername
            // 
            pbUsername.BackColor = Color.Transparent;
            pbUsername.ForeColor = Color.Gray;
            pbUsername.IconChar = FontAwesome.Sharp.IconChar.User;
            pbUsername.IconColor = Color.Gray;
            pbUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbUsername.IconSize = 50;
            pbUsername.Location = new Point(41, 78);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(50, 50);
            pbUsername.TabIndex = 1;
            pbUsername.TabStop = false;
            // 
            // BuAcceder
            // 
            BuAcceder.Alpha = 20;
            BuAcceder.BackColor = Color.Transparent;
            BuAcceder.Background = true;
            BuAcceder.Background_WidthPen = 4F;
            BuAcceder.BackgroundPen = true;
            BuAcceder.ColorBackground = Color.FromArgb(77, 182, 198);
            BuAcceder.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuAcceder.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuAcceder.ColorBackground_Pen = Color.DarkGray;
            BuAcceder.ColorLighting = Color.DarkGray;
            BuAcceder.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuAcceder.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuAcceder.Cursor = Cursors.Hand;
            BuAcceder.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuAcceder.Effect_1 = true;
            BuAcceder.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuAcceder.Effect_1_Transparency = 25;
            BuAcceder.Effect_2 = true;
            BuAcceder.Effect_2_ColorBackground = Color.White;
            BuAcceder.Effect_2_Transparency = 20;
            BuAcceder.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuAcceder.ForeColor = Color.FromArgb(245, 245, 245);
            BuAcceder.Lighting = false;
            BuAcceder.LinearGradient_Background = false;
            BuAcceder.LinearGradientPen = false;
            BuAcceder.Location = new Point(125, 223);
            BuAcceder.Name = "BuAcceder";
            BuAcceder.PenWidth = 15;
            BuAcceder.Rounding = true;
            BuAcceder.RoundingInt = 70;
            BuAcceder.Size = new Size(169, 50);
            BuAcceder.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuAcceder.TabIndex = 0;
            BuAcceder.Tag = "Cyber";
            BuAcceder.TextButton = "Acceder";
            BuAcceder.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuAcceder.Timer_Effect_1 = 5;
            BuAcceder.Timer_RGB = 300;
            BuAcceder.Click += BuAcceder_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panelFondo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Login";
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            gbContainer.ResumeLayout(false);
            gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BuVerPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFondo;
        private Label label1;
        private ReaLTaiizor.Controls.CyberGroupBox gbContainer;
        private ReaLTaiizor.Controls.BigTextBox textbUsuario;
        private FontAwesome.Sharp.IconPictureBox pbUsername;
        private ReaLTaiizor.Controls.CyberButton BuAcceder;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.BigTextBox textbPassword;
        private FontAwesome.Sharp.IconPictureBox pbPassword;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox BuVerPassword;
    }
}
