namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucCuentas
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
            label4 = new Label();
            textbPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            textbUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            label1 = new Label();
            textbNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            textbIdUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            label7 = new Label();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonTextBox2 = new ReaLTaiizor.Controls.DungeonTextBox();
            label8 = new Label();
            textbHuella = new ReaLTaiizor.Controls.DungeonTextBox();
            BuGuardar = new ReaLTaiizor.Controls.CyberButton();
            BuBuscarPersonas = new ReaLTaiizor.Controls.CyberButton();
            BuCapturarHuella = new ReaLTaiizor.Controls.CyberButton();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(BuCapturarHuella);
            panelContainer.Controls.Add(BuGuardar);
            panelContainer.Controls.Add(BuBuscarPersonas);
            panelContainer.Controls.Add(textbHuella);
            panelContainer.Controls.Add(label8);
            panelContainer.Controls.Add(dungeonTextBox2);
            panelContainer.Controls.Add(label7);
            panelContainer.Controls.Add(dungeonTextBox1);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(textbPassword);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(textbUsuario);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbNombre);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdUsuario);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(textbIdUsuario, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(textbNombre, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(textbUsuario, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            panelContainer.Controls.SetChildIndex(textbPassword, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox1, 0);
            panelContainer.Controls.SetChildIndex(label7, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox2, 0);
            panelContainer.Controls.SetChildIndex(label8, 0);
            panelContainer.Controls.SetChildIndex(textbHuella, 0);
            panelContainer.Controls.SetChildIndex(BuBuscarPersonas, 0);
            panelContainer.Controls.SetChildIndex(BuGuardar, 0);
            panelContainer.Controls.SetChildIndex(BuCapturarHuella, 0);
            // 
            // pbIcono
            // 
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            // 
            // labelTexto
            // 
            labelTexto.Size = new Size(275, 36);
            labelTexto.Text = "Gestión de cuentas";
            // 
            // label6
            // 
            label6.Size = new Size(145, 22);
            label6.Text = "Lista de cuentas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(244, 171);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 25;
            label4.Text = "Código PIN";
            // 
            // textbPassword
            // 
            textbPassword.BackColor = Color.Transparent;
            textbPassword.BorderColor = Color.FromArgb(180, 180, 180);
            textbPassword.EdgeColor = Color.White;
            textbPassword.Font = new Font("Tahoma", 12F);
            textbPassword.ForeColor = Color.Black;
            textbPassword.Location = new Point(244, 196);
            textbPassword.MaxLength = 32767;
            textbPassword.Multiline = false;
            textbPassword.Name = "textbPassword";
            textbPassword.ReadOnly = false;
            textbPassword.Size = new Size(169, 30);
            textbPassword.TabIndex = 24;
            textbPassword.TextAlignment = HorizontalAlignment.Left;
            textbPassword.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(244, 96);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 23;
            label5.Text = "Nombre";
            // 
            // textbUsuario
            // 
            textbUsuario.BackColor = Color.Transparent;
            textbUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            textbUsuario.EdgeColor = Color.White;
            textbUsuario.Font = new Font("Tahoma", 12F);
            textbUsuario.ForeColor = Color.Black;
            textbUsuario.Location = new Point(244, 121);
            textbUsuario.MaxLength = 32767;
            textbUsuario.Multiline = false;
            textbUsuario.Name = "textbUsuario";
            textbUsuario.ReadOnly = false;
            textbUsuario.Size = new Size(169, 30);
            textbUsuario.TabIndex = 22;
            textbUsuario.TextAlignment = HorizontalAlignment.Left;
            textbUsuario.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 171);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 21;
            label3.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 96);
            label1.Name = "label1";
            label1.Size = new Size(82, 22);
            label1.TabIndex = 20;
            label1.Text = "Id titular";
            // 
            // textbNombre
            // 
            textbNombre.BackColor = Color.Transparent;
            textbNombre.BorderColor = Color.FromArgb(180, 180, 180);
            textbNombre.EdgeColor = Color.White;
            textbNombre.Font = new Font("Tahoma", 12F);
            textbNombre.ForeColor = Color.Black;
            textbNombre.Location = new Point(52, 121);
            textbNombre.MaxLength = 32767;
            textbNombre.Multiline = false;
            textbNombre.Name = "textbNombre";
            textbNombre.ReadOnly = false;
            textbNombre.Size = new Size(169, 30);
            textbNombre.TabIndex = 19;
            textbNombre.TextAlignment = HorizontalAlignment.Left;
            textbNombre.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 30);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 18;
            label2.Text = "Id cuenta";
            // 
            // textbIdUsuario
            // 
            textbIdUsuario.BackColor = Color.Transparent;
            textbIdUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdUsuario.EdgeColor = Color.White;
            textbIdUsuario.Enabled = false;
            textbIdUsuario.Font = new Font("Tahoma", 12F);
            textbIdUsuario.ForeColor = Color.Black;
            textbIdUsuario.Location = new Point(52, 55);
            textbIdUsuario.MaxLength = 32767;
            textbIdUsuario.Multiline = false;
            textbIdUsuario.Name = "textbIdUsuario";
            textbIdUsuario.ReadOnly = false;
            textbIdUsuario.Size = new Size(169, 30);
            textbIdUsuario.TabIndex = 17;
            textbIdUsuario.TextAlignment = HorizontalAlignment.Left;
            textbIdUsuario.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(244, 30);
            label7.Name = "label7";
            label7.Size = new Size(78, 22);
            label7.TabIndex = 28;
            label7.Text = "Número";
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Enabled = false;
            dungeonTextBox1.Font = new Font("Tahoma", 12F);
            dungeonTextBox1.ForeColor = Color.Black;
            dungeonTextBox1.Location = new Point(244, 55);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(169, 30);
            dungeonTextBox1.TabIndex = 27;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // dungeonTextBox2
            // 
            dungeonTextBox2.BackColor = Color.Transparent;
            dungeonTextBox2.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox2.EdgeColor = Color.White;
            dungeonTextBox2.Font = new Font("Tahoma", 12F);
            dungeonTextBox2.ForeColor = Color.Black;
            dungeonTextBox2.Location = new Point(52, 196);
            dungeonTextBox2.MaxLength = 32767;
            dungeonTextBox2.Multiline = false;
            dungeonTextBox2.Name = "dungeonTextBox2";
            dungeonTextBox2.ReadOnly = false;
            dungeonTextBox2.Size = new Size(169, 30);
            dungeonTextBox2.TabIndex = 29;
            dungeonTextBox2.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(244, 242);
            label8.Name = "label8";
            label8.Size = new Size(127, 22);
            label8.TabIndex = 31;
            label8.Text = "Código Huella";
            // 
            // textbHuella
            // 
            textbHuella.BackColor = Color.Transparent;
            textbHuella.BorderColor = Color.FromArgb(180, 180, 180);
            textbHuella.EdgeColor = Color.White;
            textbHuella.Font = new Font("Tahoma", 12F);
            textbHuella.ForeColor = Color.Black;
            textbHuella.Location = new Point(244, 267);
            textbHuella.MaxLength = 32767;
            textbHuella.Multiline = false;
            textbHuella.Name = "textbHuella";
            textbHuella.ReadOnly = false;
            textbHuella.Size = new Size(169, 30);
            textbHuella.TabIndex = 32;
            textbHuella.TextAlignment = HorizontalAlignment.Left;
            textbHuella.UseSystemPasswordChar = false;
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
            BuGuardar.Location = new Point(585, 91);
            BuGuardar.Name = "BuGuardar";
            BuGuardar.PenWidth = 15;
            BuGuardar.Rounding = true;
            BuGuardar.RoundingInt = 70;
            BuGuardar.Size = new Size(169, 43);
            BuGuardar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuGuardar.TabIndex = 34;
            BuGuardar.Tag = "Cyber";
            BuGuardar.TextButton = "Crear";
            BuGuardar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuGuardar.Timer_Effect_1 = 5;
            BuGuardar.Timer_RGB = 300;
            // 
            // BuBuscarPersonas
            // 
            BuBuscarPersonas.Alpha = 20;
            BuBuscarPersonas.BackColor = Color.Transparent;
            BuBuscarPersonas.Background = true;
            BuBuscarPersonas.Background_WidthPen = 4F;
            BuBuscarPersonas.BackgroundPen = true;
            BuBuscarPersonas.ColorBackground = Color.FromArgb(77, 182, 198);
            BuBuscarPersonas.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuBuscarPersonas.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuBuscarPersonas.ColorBackground_Pen = Color.DarkGray;
            BuBuscarPersonas.ColorLighting = Color.DarkGray;
            BuBuscarPersonas.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuBuscarPersonas.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuBuscarPersonas.Cursor = Cursors.Hand;
            BuBuscarPersonas.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuBuscarPersonas.Effect_1 = true;
            BuBuscarPersonas.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuBuscarPersonas.Effect_1_Transparency = 25;
            BuBuscarPersonas.Effect_2 = true;
            BuBuscarPersonas.Effect_2_ColorBackground = Color.White;
            BuBuscarPersonas.Effect_2_Transparency = 20;
            BuBuscarPersonas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuBuscarPersonas.ForeColor = Color.FromArgb(245, 245, 245);
            BuBuscarPersonas.Lighting = false;
            BuBuscarPersonas.LinearGradient_Background = false;
            BuBuscarPersonas.LinearGradientPen = false;
            BuBuscarPersonas.Location = new Point(585, 42);
            BuBuscarPersonas.Name = "BuBuscarPersonas";
            BuBuscarPersonas.PenWidth = 15;
            BuBuscarPersonas.Rounding = true;
            BuBuscarPersonas.RoundingInt = 70;
            BuBuscarPersonas.Size = new Size(169, 43);
            BuBuscarPersonas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuBuscarPersonas.TabIndex = 33;
            BuBuscarPersonas.Tag = "Cyber";
            BuBuscarPersonas.TextButton = "Buscar";
            BuBuscarPersonas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuBuscarPersonas.Timer_Effect_1 = 5;
            BuBuscarPersonas.Timer_RGB = 300;
            // 
            // BuCapturarHuella
            // 
            BuCapturarHuella.Alpha = 20;
            BuCapturarHuella.BackColor = Color.Transparent;
            BuCapturarHuella.Background = true;
            BuCapturarHuella.Background_WidthPen = 4F;
            BuCapturarHuella.BackgroundPen = true;
            BuCapturarHuella.ColorBackground = Color.Green;
            BuCapturarHuella.ColorBackground_1 = Color.Green;
            BuCapturarHuella.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuCapturarHuella.ColorBackground_Pen = Color.DarkGray;
            BuCapturarHuella.ColorLighting = Color.DarkGray;
            BuCapturarHuella.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuCapturarHuella.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuCapturarHuella.Cursor = Cursors.Hand;
            BuCapturarHuella.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuCapturarHuella.Effect_1 = true;
            BuCapturarHuella.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuCapturarHuella.Effect_1_Transparency = 25;
            BuCapturarHuella.Effect_2 = true;
            BuCapturarHuella.Effect_2_ColorBackground = Color.White;
            BuCapturarHuella.Effect_2_Transparency = 20;
            BuCapturarHuella.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuCapturarHuella.ForeColor = Color.FromArgb(245, 245, 245);
            BuCapturarHuella.Lighting = false;
            BuCapturarHuella.LinearGradient_Background = false;
            BuCapturarHuella.LinearGradientPen = false;
            BuCapturarHuella.Location = new Point(585, 140);
            BuCapturarHuella.Name = "BuCapturarHuella";
            BuCapturarHuella.PenWidth = 15;
            BuCapturarHuella.Rounding = true;
            BuCapturarHuella.RoundingInt = 70;
            BuCapturarHuella.Size = new Size(169, 43);
            BuCapturarHuella.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuCapturarHuella.TabIndex = 35;
            BuCapturarHuella.Tag = "Cyber";
            BuCapturarHuella.TextButton = "Capturar huella";
            BuCapturarHuella.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuCapturarHuella.Timer_Effect_1 = 5;
            BuCapturarHuella.Timer_RGB = 300;
            BuCapturarHuella.Click += BuCapturarHuella_Click;
            // 
            // ucCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucCuentas";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private Label label7;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox textbPassword;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox textbUsuario;
        private Label label3;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox textbNombre;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox textbIdUsuario;
        private Label label8;
        private ReaLTaiizor.Controls.DungeonTextBox textbHuella;
        private ReaLTaiizor.Controls.CyberButton BuCapturarHuella;
        private ReaLTaiizor.Controls.CyberButton BuGuardar;
        private ReaLTaiizor.Controls.CyberButton BuBuscarPersonas;
    }
}
