namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucRetiros
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
            label8 = new Label();
            textbFiltro = new ReaLTaiizor.Controls.DungeonTextBox();
            BuAplicar = new ReaLTaiizor.Controls.CyberButton();
            BuLimpiar = new ReaLTaiizor.Controls.CyberButton();
            BuBuscar = new ReaLTaiizor.Controls.CyberButton();
            label5 = new Label();
            dungeonTextBox4 = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            dungeonTextBox2 = new ReaLTaiizor.Controls.DungeonTextBox();
            label4 = new Label();
            dungeonTextBox3 = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            textbIdUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(label8);
            panelContainer.Controls.Add(textbFiltro);
            panelContainer.Controls.Add(BuAplicar);
            panelContainer.Controls.Add(BuLimpiar);
            panelContainer.Controls.Add(BuBuscar);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(dungeonTextBox4);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(dungeonTextBox2);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(dungeonTextBox3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(dungeonTextBox1);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdUsuario);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(textbIdUsuario, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox1, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox3, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox2, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox4, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            panelContainer.Controls.SetChildIndex(BuBuscar, 0);
            panelContainer.Controls.SetChildIndex(BuLimpiar, 0);
            panelContainer.Controls.SetChildIndex(BuAplicar, 0);
            panelContainer.Controls.SetChildIndex(textbFiltro, 0);
            panelContainer.Controls.SetChildIndex(label8, 0);
            // 
            // pbIcono
            // 
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            // 
            // labelTexto
            // 
            labelTexto.Size = new Size(233, 36);
            labelTexto.Text = "Retiro de dinero";
            // 
            // label6
            // 
            label6.Size = new Size(145, 22);
            label6.Text = "Lista de cuentas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(241, 264);
            label8.Name = "label8";
            label8.Size = new Size(122, 22);
            label8.TabIndex = 58;
            label8.Text = "Buscar por №";
            // 
            // textbFiltro
            // 
            textbFiltro.BackColor = Color.Transparent;
            textbFiltro.BorderColor = Color.FromArgb(180, 180, 180);
            textbFiltro.EdgeColor = Color.White;
            textbFiltro.Font = new Font("Tahoma", 12F);
            textbFiltro.ForeColor = Color.Black;
            textbFiltro.Location = new Point(369, 264);
            textbFiltro.MaxLength = 32767;
            textbFiltro.Multiline = false;
            textbFiltro.Name = "textbFiltro";
            textbFiltro.ReadOnly = false;
            textbFiltro.Size = new Size(385, 30);
            textbFiltro.TabIndex = 57;
            textbFiltro.TextAlignment = HorizontalAlignment.Left;
            textbFiltro.UseSystemPasswordChar = false;
            // 
            // BuAplicar
            // 
            BuAplicar.Alpha = 20;
            BuAplicar.BackColor = Color.Transparent;
            BuAplicar.Background = true;
            BuAplicar.Background_WidthPen = 4F;
            BuAplicar.BackgroundPen = true;
            BuAplicar.ColorBackground = Color.Green;
            BuAplicar.ColorBackground_1 = Color.Green;
            BuAplicar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuAplicar.ColorBackground_Pen = Color.DarkGray;
            BuAplicar.ColorLighting = Color.DarkGray;
            BuAplicar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuAplicar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuAplicar.Cursor = Cursors.Hand;
            BuAplicar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuAplicar.Effect_1 = true;
            BuAplicar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuAplicar.Effect_1_Transparency = 25;
            BuAplicar.Effect_2 = true;
            BuAplicar.Effect_2_ColorBackground = Color.White;
            BuAplicar.Effect_2_Transparency = 20;
            BuAplicar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuAplicar.ForeColor = Color.FromArgb(245, 245, 245);
            BuAplicar.Lighting = false;
            BuAplicar.LinearGradient_Background = false;
            BuAplicar.LinearGradientPen = false;
            BuAplicar.Location = new Point(585, 73);
            BuAplicar.Name = "BuAplicar";
            BuAplicar.PenWidth = 15;
            BuAplicar.Rounding = true;
            BuAplicar.RoundingInt = 70;
            BuAplicar.Size = new Size(169, 43);
            BuAplicar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuAplicar.TabIndex = 56;
            BuAplicar.Tag = "Cyber";
            BuAplicar.TextButton = "Aplicar";
            BuAplicar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuAplicar.Timer_Effect_1 = 5;
            BuAplicar.Timer_RGB = 300;
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
            BuLimpiar.Location = new Point(585, 124);
            BuLimpiar.Name = "BuLimpiar";
            BuLimpiar.PenWidth = 15;
            BuLimpiar.Rounding = true;
            BuLimpiar.RoundingInt = 70;
            BuLimpiar.Size = new Size(169, 43);
            BuLimpiar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuLimpiar.TabIndex = 55;
            BuLimpiar.Tag = "Cyber";
            BuLimpiar.TextButton = "Limpiar campos";
            BuLimpiar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuLimpiar.Timer_Effect_1 = 5;
            BuLimpiar.Timer_RGB = 300;
            // 
            // BuBuscar
            // 
            BuBuscar.Alpha = 20;
            BuBuscar.BackColor = Color.Transparent;
            BuBuscar.Background = true;
            BuBuscar.Background_WidthPen = 4F;
            BuBuscar.BackgroundPen = true;
            BuBuscar.ColorBackground = Color.Green;
            BuBuscar.ColorBackground_1 = Color.Green;
            BuBuscar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuBuscar.ColorBackground_Pen = Color.DarkGray;
            BuBuscar.ColorLighting = Color.DarkGray;
            BuBuscar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuBuscar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuBuscar.Cursor = Cursors.Hand;
            BuBuscar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuBuscar.Effect_1 = true;
            BuBuscar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuBuscar.Effect_1_Transparency = 25;
            BuBuscar.Effect_2 = true;
            BuBuscar.Effect_2_ColorBackground = Color.White;
            BuBuscar.Effect_2_Transparency = 20;
            BuBuscar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuBuscar.ForeColor = Color.FromArgb(245, 245, 245);
            BuBuscar.Lighting = false;
            BuBuscar.LinearGradient_Background = false;
            BuBuscar.LinearGradientPen = false;
            BuBuscar.Location = new Point(585, 24);
            BuBuscar.Name = "BuBuscar";
            BuBuscar.PenWidth = 15;
            BuBuscar.Rounding = true;
            BuBuscar.RoundingInt = 70;
            BuBuscar.Size = new Size(169, 43);
            BuBuscar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuBuscar.TabIndex = 54;
            BuBuscar.Tag = "Cyber";
            BuBuscar.TextButton = "Buscar titular";
            BuBuscar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuBuscar.Timer_Effect_1 = 5;
            BuBuscar.Timer_RGB = 300;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(227, 145);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 53;
            label5.Text = "Cantidad";
            // 
            // dungeonTextBox4
            // 
            dungeonTextBox4.BackColor = Color.Transparent;
            dungeonTextBox4.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox4.EdgeColor = Color.White;
            dungeonTextBox4.Enabled = false;
            dungeonTextBox4.Font = new Font("Tahoma", 12F);
            dungeonTextBox4.ForeColor = Color.Black;
            dungeonTextBox4.Location = new Point(227, 170);
            dungeonTextBox4.MaxLength = 32767;
            dungeonTextBox4.Multiline = false;
            dungeonTextBox4.Name = "dungeonTextBox4";
            dungeonTextBox4.ReadOnly = false;
            dungeonTextBox4.Size = new Size(169, 30);
            dungeonTextBox4.TabIndex = 52;
            dungeonTextBox4.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox4.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(227, 77);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 49;
            label3.Text = "№ cuenta";
            // 
            // dungeonTextBox2
            // 
            dungeonTextBox2.BackColor = Color.Transparent;
            dungeonTextBox2.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox2.EdgeColor = Color.White;
            dungeonTextBox2.Enabled = false;
            dungeonTextBox2.Font = new Font("Tahoma", 12F);
            dungeonTextBox2.ForeColor = Color.Black;
            dungeonTextBox2.Location = new Point(227, 102);
            dungeonTextBox2.MaxLength = 32767;
            dungeonTextBox2.Multiline = false;
            dungeonTextBox2.Name = "dungeonTextBox2";
            dungeonTextBox2.ReadOnly = false;
            dungeonTextBox2.Size = new Size(169, 30);
            dungeonTextBox2.TabIndex = 48;
            dungeonTextBox2.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(52, 77);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 47;
            label4.Text = "Id cuenta";
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Enabled = false;
            dungeonTextBox3.Font = new Font("Tahoma", 12F);
            dungeonTextBox3.ForeColor = Color.Black;
            dungeonTextBox3.Location = new Point(52, 102);
            dungeonTextBox3.MaxLength = 32767;
            dungeonTextBox3.Multiline = false;
            dungeonTextBox3.Name = "dungeonTextBox3";
            dungeonTextBox3.ReadOnly = false;
            dungeonTextBox3.Size = new Size(169, 30);
            dungeonTextBox3.TabIndex = 46;
            dungeonTextBox3.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox3.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 45;
            label1.Text = "Nombre";
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Enabled = false;
            dungeonTextBox1.Font = new Font("Tahoma", 12F);
            dungeonTextBox1.ForeColor = Color.Black;
            dungeonTextBox1.Location = new Point(227, 37);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(169, 30);
            dungeonTextBox1.TabIndex = 44;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 12);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 43;
            label2.Text = "Id titular";
            // 
            // textbIdUsuario
            // 
            textbIdUsuario.BackColor = Color.Transparent;
            textbIdUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdUsuario.EdgeColor = Color.White;
            textbIdUsuario.Enabled = false;
            textbIdUsuario.Font = new Font("Tahoma", 12F);
            textbIdUsuario.ForeColor = Color.Black;
            textbIdUsuario.Location = new Point(52, 37);
            textbIdUsuario.MaxLength = 32767;
            textbIdUsuario.Multiline = false;
            textbIdUsuario.Name = "textbIdUsuario";
            textbIdUsuario.ReadOnly = false;
            textbIdUsuario.Size = new Size(169, 30);
            textbIdUsuario.TabIndex = 42;
            textbIdUsuario.TextAlignment = HorizontalAlignment.Left;
            textbIdUsuario.UseSystemPasswordChar = false;
            // 
            // ucRetiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucRetiros";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private ReaLTaiizor.Controls.DungeonTextBox textbFiltro;
        private ReaLTaiizor.Controls.CyberButton BuAplicar;
        private ReaLTaiizor.Controls.CyberButton BuLimpiar;
        private ReaLTaiizor.Controls.CyberButton BuBuscar;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox4;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox3;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox textbIdUsuario;
    }
}
