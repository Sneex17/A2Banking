namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucDepositos
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
            label2 = new Label();
            textbIdCliente = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            textbNombreCliente = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            textbNumeroCuenta = new ReaLTaiizor.Controls.DungeonTextBox();
            label4 = new Label();
            texbIdCuenta = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            textbCantidad = new ReaLTaiizor.Controls.DungeonTextBox();
            label7 = new Label();
            textbTitular = new ReaLTaiizor.Controls.DungeonTextBox();
            BuLimpiar = new ReaLTaiizor.Controls.CyberButton();
            BuBuscar = new ReaLTaiizor.Controls.CyberButton();
            BuAplicar = new ReaLTaiizor.Controls.CyberButton();
            label8 = new Label();
            textbFiltro = new ReaLTaiizor.Controls.DungeonTextBox();
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
            panelContainer.Controls.Add(textbCantidad);
            panelContainer.Controls.Add(label7);
            panelContainer.Controls.Add(textbTitular);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(textbNumeroCuenta);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(texbIdCuenta);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbNombreCliente);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdCliente);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(textbIdCliente, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(textbNombreCliente, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(texbIdCuenta, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(textbNumeroCuenta, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(textbTitular, 0);
            panelContainer.Controls.SetChildIndex(label7, 0);
            panelContainer.Controls.SetChildIndex(textbCantidad, 0);
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
            labelTexto.Size = new Size(287, 36);
            labelTexto.Text = "Dépositos de dinero";
            // 
            // label6
            // 
            label6.Size = new Size(145, 22);
            label6.Text = "Lista de cuentas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 15);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 18;
            label2.Text = "Id cliente";
            // 
            // textbIdCliente
            // 
            textbIdCliente.BackColor = Color.Transparent;
            textbIdCliente.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdCliente.EdgeColor = Color.White;
            textbIdCliente.Enabled = false;
            textbIdCliente.Font = new Font("Tahoma", 12F);
            textbIdCliente.ForeColor = Color.Black;
            textbIdCliente.Location = new Point(52, 40);
            textbIdCliente.MaxLength = 32767;
            textbIdCliente.Multiline = false;
            textbIdCliente.Name = "textbIdCliente";
            textbIdCliente.ReadOnly = false;
            textbIdCliente.Size = new Size(169, 30);
            textbIdCliente.TabIndex = 17;
            textbIdCliente.TextAlignment = HorizontalAlignment.Left;
            textbIdCliente.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 15);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 20;
            label1.Text = "Cliente";
            // 
            // textbNombreCliente
            // 
            textbNombreCliente.BackColor = Color.Transparent;
            textbNombreCliente.BorderColor = Color.FromArgb(180, 180, 180);
            textbNombreCliente.EdgeColor = Color.White;
            textbNombreCliente.Enabled = false;
            textbNombreCliente.Font = new Font("Tahoma", 12F);
            textbNombreCliente.ForeColor = Color.Black;
            textbNombreCliente.Location = new Point(227, 40);
            textbNombreCliente.MaxLength = 32767;
            textbNombreCliente.Multiline = false;
            textbNombreCliente.Name = "textbNombreCliente";
            textbNombreCliente.ReadOnly = false;
            textbNombreCliente.Size = new Size(169, 30);
            textbNombreCliente.TabIndex = 19;
            textbNombreCliente.TextAlignment = HorizontalAlignment.Left;
            textbNombreCliente.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(227, 80);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 24;
            label3.Text = "№ cuenta";
            // 
            // textbNumeroCuenta
            // 
            textbNumeroCuenta.BackColor = Color.Transparent;
            textbNumeroCuenta.BorderColor = Color.FromArgb(180, 180, 180);
            textbNumeroCuenta.EdgeColor = Color.White;
            textbNumeroCuenta.Enabled = false;
            textbNumeroCuenta.Font = new Font("Tahoma", 12F);
            textbNumeroCuenta.ForeColor = Color.Black;
            textbNumeroCuenta.Location = new Point(227, 105);
            textbNumeroCuenta.MaxLength = 32767;
            textbNumeroCuenta.Multiline = false;
            textbNumeroCuenta.Name = "textbNumeroCuenta";
            textbNumeroCuenta.ReadOnly = false;
            textbNumeroCuenta.Size = new Size(169, 30);
            textbNumeroCuenta.TabIndex = 23;
            textbNumeroCuenta.TextAlignment = HorizontalAlignment.Left;
            textbNumeroCuenta.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(52, 80);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 22;
            label4.Text = "Id cuenta";
            // 
            // texbIdCuenta
            // 
            texbIdCuenta.BackColor = Color.Transparent;
            texbIdCuenta.BorderColor = Color.FromArgb(180, 180, 180);
            texbIdCuenta.EdgeColor = Color.White;
            texbIdCuenta.Enabled = false;
            texbIdCuenta.Font = new Font("Tahoma", 12F);
            texbIdCuenta.ForeColor = Color.Black;
            texbIdCuenta.Location = new Point(52, 105);
            texbIdCuenta.MaxLength = 32767;
            texbIdCuenta.Multiline = false;
            texbIdCuenta.Name = "texbIdCuenta";
            texbIdCuenta.ReadOnly = false;
            texbIdCuenta.Size = new Size(169, 30);
            texbIdCuenta.TabIndex = 21;
            texbIdCuenta.TextAlignment = HorizontalAlignment.Left;
            texbIdCuenta.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(227, 148);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 28;
            label5.Text = "Cantidad";
            // 
            // textbCantidad
            // 
            textbCantidad.BackColor = Color.Transparent;
            textbCantidad.BorderColor = Color.FromArgb(180, 180, 180);
            textbCantidad.EdgeColor = Color.White;
            textbCantidad.Font = new Font("Tahoma", 12F);
            textbCantidad.ForeColor = Color.Black;
            textbCantidad.Location = new Point(227, 173);
            textbCantidad.MaxLength = 32767;
            textbCantidad.Multiline = false;
            textbCantidad.Name = "textbCantidad";
            textbCantidad.ReadOnly = false;
            textbCantidad.Size = new Size(169, 30);
            textbCantidad.TabIndex = 27;
            textbCantidad.TextAlignment = HorizontalAlignment.Left;
            textbCantidad.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(52, 148);
            label7.Name = "label7";
            label7.Size = new Size(65, 22);
            label7.TabIndex = 26;
            label7.Text = "Titular";
            // 
            // textbTitular
            // 
            textbTitular.BackColor = Color.Transparent;
            textbTitular.BorderColor = Color.FromArgb(180, 180, 180);
            textbTitular.EdgeColor = Color.White;
            textbTitular.Enabled = false;
            textbTitular.Font = new Font("Tahoma", 12F);
            textbTitular.ForeColor = Color.Black;
            textbTitular.Location = new Point(52, 173);
            textbTitular.MaxLength = 32767;
            textbTitular.Multiline = false;
            textbTitular.Name = "textbTitular";
            textbTitular.ReadOnly = false;
            textbTitular.Size = new Size(169, 30);
            textbTitular.TabIndex = 25;
            textbTitular.TextAlignment = HorizontalAlignment.Left;
            textbTitular.UseSystemPasswordChar = false;
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
            BuLimpiar.Location = new Point(585, 127);
            BuLimpiar.Name = "BuLimpiar";
            BuLimpiar.PenWidth = 15;
            BuLimpiar.Rounding = true;
            BuLimpiar.RoundingInt = 70;
            BuLimpiar.Size = new Size(169, 43);
            BuLimpiar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuLimpiar.TabIndex = 38;
            BuLimpiar.Tag = "Cyber";
            BuLimpiar.TextButton = "Limpiar campos";
            BuLimpiar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuLimpiar.Timer_Effect_1 = 5;
            BuLimpiar.Timer_RGB = 300;
            BuLimpiar.Click += BuLimpiar_Click;
            // 
            // BuBuscar
            // 
            BuBuscar.Alpha = 20;
            BuBuscar.BackColor = Color.Transparent;
            BuBuscar.Background = true;
            BuBuscar.Background_WidthPen = 4F;
            BuBuscar.BackgroundPen = true;
            BuBuscar.ColorBackground = Color.FromArgb(77, 182, 198);
            BuBuscar.ColorBackground_1 = Color.FromArgb(77, 182, 198);
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
            BuBuscar.Location = new Point(585, 27);
            BuBuscar.Name = "BuBuscar";
            BuBuscar.PenWidth = 15;
            BuBuscar.Rounding = true;
            BuBuscar.RoundingInt = 70;
            BuBuscar.Size = new Size(169, 43);
            BuBuscar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuBuscar.TabIndex = 37;
            BuBuscar.Tag = "Cyber";
            BuBuscar.TextButton = "Buscar cliente";
            BuBuscar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuBuscar.Timer_Effect_1 = 5;
            BuBuscar.Timer_RGB = 300;
            BuBuscar.Click += BuBuscar_Click;
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
            BuAplicar.Location = new Point(585, 76);
            BuAplicar.Name = "BuAplicar";
            BuAplicar.PenWidth = 15;
            BuAplicar.Rounding = true;
            BuAplicar.RoundingInt = 70;
            BuAplicar.Size = new Size(169, 43);
            BuAplicar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuAplicar.TabIndex = 39;
            BuAplicar.Tag = "Cyber";
            BuAplicar.TextButton = "Aplicar";
            BuAplicar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuAplicar.Timer_Effect_1 = 5;
            BuAplicar.Timer_RGB = 300;
            BuAplicar.Click += BuAplicar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(241, 267);
            label8.Name = "label8";
            label8.Size = new Size(122, 22);
            label8.TabIndex = 41;
            label8.Text = "Buscar por №";
            // 
            // textbFiltro
            // 
            textbFiltro.BackColor = Color.Transparent;
            textbFiltro.BorderColor = Color.FromArgb(180, 180, 180);
            textbFiltro.EdgeColor = Color.White;
            textbFiltro.Font = new Font("Tahoma", 12F);
            textbFiltro.ForeColor = Color.Black;
            textbFiltro.Location = new Point(369, 267);
            textbFiltro.MaxLength = 32767;
            textbFiltro.Multiline = false;
            textbFiltro.Name = "textbFiltro";
            textbFiltro.ReadOnly = false;
            textbFiltro.Size = new Size(385, 30);
            textbFiltro.TabIndex = 40;
            textbFiltro.TextAlignment = HorizontalAlignment.Left;
            textbFiltro.UseSystemPasswordChar = false;
            // 
            // ucDepositos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucDepositos";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox textbNombreCliente;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox textbIdCliente;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox textbCantidad;
        private Label label7;
        private ReaLTaiizor.Controls.DungeonTextBox textbTitular;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox textbNumeroCuenta;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox texbIdCuenta;
        private ReaLTaiizor.Controls.CyberButton BuAplicar;
        private ReaLTaiizor.Controls.CyberButton BuLimpiar;
        private ReaLTaiizor.Controls.CyberButton BuBuscar;
        private Label label8;
        private ReaLTaiizor.Controls.DungeonTextBox textbFiltro;
    }
}
