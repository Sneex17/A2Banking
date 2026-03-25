namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            textbIdUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            label1 = new Label();
            textbNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            label4 = new Label();
            textbPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            textbUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            comboRoles = new ReaLTaiizor.Controls.AloneComboBox();
            BuGuardar = new ReaLTaiizor.Controls.CyberButton();
            BuLimpiar = new ReaLTaiizor.Controls.CyberButton();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(BuLimpiar);
            panelContainer.Controls.Add(BuGuardar);
            panelContainer.Controls.Add(comboRoles);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(textbPassword);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(textbUsuario);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbNombre);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdUsuario);
            panelContainer.Controls.SetChildIndex(textbIdUsuario, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(textbNombre, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(textbUsuario, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            panelContainer.Controls.SetChildIndex(textbPassword, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(comboRoles, 0);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(BuGuardar, 0);
            panelContainer.Controls.SetChildIndex(BuLimpiar, 0);
            // 
            // pbIcono
            // 
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.User;
            // 
            // labelTexto
            // 
            labelTexto.Size = new Size(283, 36);
            labelTexto.Text = "Gestión de usuarios";
            // 
            // textbIdUsuario
            // 
            textbIdUsuario.BackColor = Color.Transparent;
            textbIdUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdUsuario.EdgeColor = Color.White;
            textbIdUsuario.Enabled = false;
            textbIdUsuario.Font = new Font("Tahoma", 12F);
            textbIdUsuario.ForeColor = Color.Black;
            textbIdUsuario.Location = new Point(52, 64);
            textbIdUsuario.MaxLength = 32767;
            textbIdUsuario.Multiline = false;
            textbIdUsuario.Name = "textbIdUsuario";
            textbIdUsuario.ReadOnly = false;
            textbIdUsuario.Size = new Size(169, 30);
            textbIdUsuario.TabIndex = 0;
            textbIdUsuario.TextAlignment = HorizontalAlignment.Left;
            textbIdUsuario.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 39);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 3;
            label2.Text = "Id usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 105);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // textbNombre
            // 
            textbNombre.BackColor = Color.Transparent;
            textbNombre.BorderColor = Color.FromArgb(180, 180, 180);
            textbNombre.EdgeColor = Color.White;
            textbNombre.Font = new Font("Tahoma", 12F);
            textbNombre.ForeColor = Color.Black;
            textbNombre.Location = new Point(52, 130);
            textbNombre.MaxLength = 32767;
            textbNombre.Multiline = false;
            textbNombre.Name = "textbNombre";
            textbNombre.ReadOnly = false;
            textbNombre.Size = new Size(169, 30);
            textbNombre.TabIndex = 4;
            textbNombre.TextAlignment = HorizontalAlignment.Left;
            textbNombre.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 180);
            label3.Name = "label3";
            label3.Size = new Size(37, 22);
            label3.TabIndex = 7;
            label3.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(244, 180);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 11;
            label4.Text = "Contraseña";
            // 
            // textbPassword
            // 
            textbPassword.BackColor = Color.Transparent;
            textbPassword.BorderColor = Color.FromArgb(180, 180, 180);
            textbPassword.EdgeColor = Color.White;
            textbPassword.Font = new Font("Tahoma", 12F);
            textbPassword.ForeColor = Color.Black;
            textbPassword.Location = new Point(244, 205);
            textbPassword.MaxLength = 32767;
            textbPassword.Multiline = false;
            textbPassword.Name = "textbPassword";
            textbPassword.ReadOnly = false;
            textbPassword.Size = new Size(169, 30);
            textbPassword.TabIndex = 10;
            textbPassword.TextAlignment = HorizontalAlignment.Left;
            textbPassword.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(244, 105);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 9;
            label5.Text = "Usuario";
            // 
            // textbUsuario
            // 
            textbUsuario.BackColor = Color.Transparent;
            textbUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            textbUsuario.EdgeColor = Color.White;
            textbUsuario.Font = new Font("Tahoma", 12F);
            textbUsuario.ForeColor = Color.Black;
            textbUsuario.Location = new Point(244, 130);
            textbUsuario.MaxLength = 32767;
            textbUsuario.Multiline = false;
            textbUsuario.Name = "textbUsuario";
            textbUsuario.ReadOnly = false;
            textbUsuario.Size = new Size(169, 30);
            textbUsuario.TabIndex = 8;
            textbUsuario.TextAlignment = HorizontalAlignment.Left;
            textbUsuario.UseSystemPasswordChar = false;
            // 
            // comboRoles
            // 
            comboRoles.DrawMode = DrawMode.OwnerDrawFixed;
            comboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRoles.EnabledCalc = true;
            comboRoles.FormattingEnabled = true;
            comboRoles.ItemHeight = 20;
            comboRoles.Location = new Point(52, 209);
            comboRoles.Name = "comboRoles";
            comboRoles.Size = new Size(169, 26);
            comboRoles.TabIndex = 12;
            // 
            // BuGuardar
            // 
            BuGuardar.Alpha = 20;
            BuGuardar.BackColor = Color.Transparent;
            BuGuardar.Background = true;
            BuGuardar.Background_WidthPen = 4F;
            BuGuardar.BackgroundPen = true;
            BuGuardar.ColorBackground = Color.Green;
            BuGuardar.ColorBackground_1 = Color.Green;
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
            BuGuardar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuGuardar.ForeColor = Color.FromArgb(245, 245, 245);
            BuGuardar.Lighting = false;
            BuGuardar.LinearGradient_Background = false;
            BuGuardar.LinearGradientPen = false;
            BuGuardar.Location = new Point(585, 39);
            BuGuardar.Name = "BuGuardar";
            BuGuardar.PenWidth = 15;
            BuGuardar.Rounding = true;
            BuGuardar.RoundingInt = 70;
            BuGuardar.Size = new Size(169, 43);
            BuGuardar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuGuardar.TabIndex = 35;
            BuGuardar.Tag = "Cyber";
            BuGuardar.TextButton = "Registrar";
            BuGuardar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuGuardar.Timer_Effect_1 = 5;
            BuGuardar.Timer_RGB = 300;
            BuGuardar.Click += BuGuardar_Click;
            // 
            // BuLimpiar
            // 
            BuLimpiar.Alpha = 20;
            BuLimpiar.BackColor = Color.Transparent;
            BuLimpiar.Background = true;
            BuLimpiar.Background_WidthPen = 4F;
            BuLimpiar.BackgroundPen = true;
            BuLimpiar.ColorBackground = Color.Tan;
            BuLimpiar.ColorBackground_1 = Color.Tan;
            BuLimpiar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuLimpiar.ColorBackground_Pen = Color.DarkGray;
            BuLimpiar.ColorLighting = Color.DarkGray;
            BuLimpiar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuLimpiar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuLimpiar.Cursor = Cursors.Hand;
            BuLimpiar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuLimpiar.Effect_1 = true;
            BuLimpiar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuLimpiar.Effect_1_Transparency = 25;
            BuLimpiar.Effect_2 = true;
            BuLimpiar.Effect_2_ColorBackground = Color.White;
            BuLimpiar.Effect_2_Transparency = 20;
            BuLimpiar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuLimpiar.ForeColor = Color.FromArgb(245, 245, 245);
            BuLimpiar.Lighting = false;
            BuLimpiar.LinearGradient_Background = false;
            BuLimpiar.LinearGradientPen = false;
            BuLimpiar.Location = new Point(585, 88);
            BuLimpiar.Name = "BuLimpiar";
            BuLimpiar.PenWidth = 15;
            BuLimpiar.Rounding = true;
            BuLimpiar.RoundingInt = 70;
            BuLimpiar.Size = new Size(169, 43);
            BuLimpiar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuLimpiar.TabIndex = 36;
            BuLimpiar.Tag = "Cyber";
            BuLimpiar.TextButton = "Limpiar campos";
            BuLimpiar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuLimpiar.Timer_Effect_1 = 5;
            BuLimpiar.Timer_RGB = 300;
            BuLimpiar.Click += BuLimpiar_Click;
            // 
            // ucUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucUsuarios";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox textbIdUsuario;
        private Label label2;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox textbUsuario;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox textbPassword;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox textbNombre;
        private ReaLTaiizor.Controls.AloneComboBox comboRoles;
        private ReaLTaiizor.Controls.CyberButton BuGuardar;
        private ReaLTaiizor.Controls.CyberButton BuLimpiar;
    }
}
