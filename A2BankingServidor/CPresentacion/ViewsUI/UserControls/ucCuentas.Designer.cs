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
            textbCodigoPin = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            textbNombreTitular = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            label1 = new Label();
            textbIdTitular = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            textbIdCuenta = new ReaLTaiizor.Controls.DungeonTextBox();
            label7 = new Label();
            textbNumeroCuenta = new ReaLTaiizor.Controls.DungeonTextBox();
            textbEstadoCuenta = new ReaLTaiizor.Controls.DungeonTextBox();
            label8 = new Label();
            textbHuella = new ReaLTaiizor.Controls.DungeonTextBox();
            BuGuardar = new ReaLTaiizor.Controls.CyberButton();
            BuBuscarPersonas = new ReaLTaiizor.Controls.CyberButton();
            BuCapturarHuella = new ReaLTaiizor.Controls.CyberButton();
            BuLimpiar = new ReaLTaiizor.Controls.CyberButton();
            BuCapturarPIN = new FontAwesome.Sharp.IconPictureBox();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuCapturarPIN).BeginInit();
            SuspendLayout();
            // 
            // panelInformacion
            // 
            panelInformacion.Margin = new Padding(3, 2, 3, 2);
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(BuCapturarPIN);
            panelContainer.Controls.Add(BuLimpiar);
            panelContainer.Controls.Add(BuCapturarHuella);
            panelContainer.Controls.Add(BuGuardar);
            panelContainer.Controls.Add(BuBuscarPersonas);
            panelContainer.Controls.Add(textbHuella);
            panelContainer.Controls.Add(label8);
            panelContainer.Controls.Add(textbEstadoCuenta);
            panelContainer.Controls.Add(label7);
            panelContainer.Controls.Add(textbNumeroCuenta);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(textbCodigoPin);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(textbNombreTitular);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbIdTitular);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdCuenta);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(textbIdCuenta, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(textbIdTitular, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(textbNombreTitular, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            panelContainer.Controls.SetChildIndex(textbCodigoPin, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(textbNumeroCuenta, 0);
            panelContainer.Controls.SetChildIndex(label7, 0);
            panelContainer.Controls.SetChildIndex(textbEstadoCuenta, 0);
            panelContainer.Controls.SetChildIndex(label8, 0);
            panelContainer.Controls.SetChildIndex(textbHuella, 0);
            panelContainer.Controls.SetChildIndex(BuBuscarPersonas, 0);
            panelContainer.Controls.SetChildIndex(BuGuardar, 0);
            panelContainer.Controls.SetChildIndex(BuCapturarHuella, 0);
            panelContainer.Controls.SetChildIndex(BuLimpiar, 0);
            panelContainer.Controls.SetChildIndex(BuCapturarPIN, 0);
            // 
            // pbIcono
            // 
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            pbIcono.IconSize = 57;
            pbIcono.Location = new Point(46, 12);
            pbIcono.Margin = new Padding(3, 4, 3, 4);
            pbIcono.Size = new Size(57, 67);
            // 
            // labelTexto
            // 
            labelTexto.Location = new Point(94, 18);
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
            // textbCodigoPin
            // 
            textbCodigoPin.BackColor = Color.Transparent;
            textbCodigoPin.BorderColor = Color.FromArgb(180, 180, 180);
            textbCodigoPin.EdgeColor = Color.White;
            textbCodigoPin.Enabled = false;
            textbCodigoPin.Font = new Font("Tahoma", 12F);
            textbCodigoPin.ForeColor = Color.Black;
            textbCodigoPin.Location = new Point(244, 196);
            textbCodigoPin.MaxLength = 32767;
            textbCodigoPin.Multiline = false;
            textbCodigoPin.Name = "textbCodigoPin";
            textbCodigoPin.ReadOnly = false;
            textbCodigoPin.Size = new Size(169, 30);
            textbCodigoPin.TabIndex = 24;
            textbCodigoPin.TextAlignment = HorizontalAlignment.Left;
            textbCodigoPin.UseSystemPasswordChar = false;
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
            // textbNombreTitular
            // 
            textbNombreTitular.BackColor = Color.Transparent;
            textbNombreTitular.BorderColor = Color.FromArgb(180, 180, 180);
            textbNombreTitular.EdgeColor = Color.White;
            textbNombreTitular.Enabled = false;
            textbNombreTitular.Font = new Font("Tahoma", 12F);
            textbNombreTitular.ForeColor = Color.Black;
            textbNombreTitular.Location = new Point(244, 121);
            textbNombreTitular.MaxLength = 32767;
            textbNombreTitular.Multiline = false;
            textbNombreTitular.Name = "textbNombreTitular";
            textbNombreTitular.ReadOnly = false;
            textbNombreTitular.Size = new Size(169, 30);
            textbNombreTitular.TabIndex = 22;
            textbNombreTitular.TextAlignment = HorizontalAlignment.Left;
            textbNombreTitular.UseSystemPasswordChar = false;
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
            // textbIdTitular
            // 
            textbIdTitular.BackColor = Color.Transparent;
            textbIdTitular.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdTitular.EdgeColor = Color.White;
            textbIdTitular.Enabled = false;
            textbIdTitular.Font = new Font("Tahoma", 12F);
            textbIdTitular.ForeColor = Color.Black;
            textbIdTitular.Location = new Point(52, 121);
            textbIdTitular.MaxLength = 32767;
            textbIdTitular.Multiline = false;
            textbIdTitular.Name = "textbIdTitular";
            textbIdTitular.ReadOnly = false;
            textbIdTitular.Size = new Size(169, 30);
            textbIdTitular.TabIndex = 19;
            textbIdTitular.TextAlignment = HorizontalAlignment.Left;
            textbIdTitular.UseSystemPasswordChar = false;
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
            // textbIdCuenta
            // 
            textbIdCuenta.BackColor = Color.Transparent;
            textbIdCuenta.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdCuenta.EdgeColor = Color.White;
            textbIdCuenta.Enabled = false;
            textbIdCuenta.Font = new Font("Tahoma", 12F);
            textbIdCuenta.ForeColor = Color.Black;
            textbIdCuenta.Location = new Point(52, 55);
            textbIdCuenta.MaxLength = 32767;
            textbIdCuenta.Multiline = false;
            textbIdCuenta.Name = "textbIdCuenta";
            textbIdCuenta.ReadOnly = false;
            textbIdCuenta.Size = new Size(169, 30);
            textbIdCuenta.TabIndex = 17;
            textbIdCuenta.TextAlignment = HorizontalAlignment.Left;
            textbIdCuenta.UseSystemPasswordChar = false;
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
            // textbNumeroCuenta
            // 
            textbNumeroCuenta.BackColor = Color.Transparent;
            textbNumeroCuenta.BorderColor = Color.FromArgb(180, 180, 180);
            textbNumeroCuenta.EdgeColor = Color.White;
            textbNumeroCuenta.Enabled = false;
            textbNumeroCuenta.Font = new Font("Tahoma", 12F);
            textbNumeroCuenta.ForeColor = Color.Black;
            textbNumeroCuenta.Location = new Point(244, 55);
            textbNumeroCuenta.MaxLength = 32767;
            textbNumeroCuenta.Multiline = false;
            textbNumeroCuenta.Name = "textbNumeroCuenta";
            textbNumeroCuenta.ReadOnly = false;
            textbNumeroCuenta.Size = new Size(169, 30);
            textbNumeroCuenta.TabIndex = 27;
            textbNumeroCuenta.TextAlignment = HorizontalAlignment.Left;
            textbNumeroCuenta.UseSystemPasswordChar = false;
            // 
            // textbEstadoCuenta
            // 
            textbEstadoCuenta.BackColor = Color.Transparent;
            textbEstadoCuenta.BorderColor = Color.FromArgb(180, 180, 180);
            textbEstadoCuenta.EdgeColor = Color.White;
            textbEstadoCuenta.Enabled = false;
            textbEstadoCuenta.Font = new Font("Tahoma", 12F);
            textbEstadoCuenta.ForeColor = Color.Black;
            textbEstadoCuenta.Location = new Point(52, 196);
            textbEstadoCuenta.MaxLength = 32767;
            textbEstadoCuenta.Multiline = false;
            textbEstadoCuenta.Name = "textbEstadoCuenta";
            textbEstadoCuenta.ReadOnly = false;
            textbEstadoCuenta.Size = new Size(169, 30);
            textbEstadoCuenta.TabIndex = 29;
            textbEstadoCuenta.TextAlignment = HorizontalAlignment.Left;
            textbEstadoCuenta.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(244, 234);
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
            textbHuella.Location = new Point(244, 259);
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
            BuGuardar.Click += BuGuardar_Click;
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
            BuBuscarPersonas.Click += BuBuscarPersonas_Click;
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
            BuLimpiar.Location = new Point(585, 189);
            BuLimpiar.Name = "BuLimpiar";
            BuLimpiar.PenWidth = 15;
            BuLimpiar.Rounding = true;
            BuLimpiar.RoundingInt = 70;
            BuLimpiar.Size = new Size(169, 43);
            BuLimpiar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuLimpiar.TabIndex = 37;
            BuLimpiar.Tag = "Cyber";
            BuLimpiar.TextButton = "Limpiar campos";
            BuLimpiar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuLimpiar.Timer_Effect_1 = 5;
            BuLimpiar.Timer_RGB = 300;
            BuLimpiar.Click += BuLimpiar_Click;
            // 
            // BuCapturarPIN
            // 
            BuCapturarPIN.BackColor = Color.Transparent;
            BuCapturarPIN.Cursor = Cursors.Hand;
            BuCapturarPIN.ForeColor = Color.Gray;
            BuCapturarPIN.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BuCapturarPIN.IconColor = Color.Gray;
            BuCapturarPIN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BuCapturarPIN.IconSize = 50;
            BuCapturarPIN.Location = new Point(419, 189);
            BuCapturarPIN.Name = "BuCapturarPIN";
            BuCapturarPIN.Size = new Size(50, 50);
            BuCapturarPIN.TabIndex = 38;
            BuCapturarPIN.TabStop = false;
            BuCapturarPIN.Click += BuCapturarPIN_Click;
            // 
            // ucCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucCuentas";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuCapturarPIN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox textbEstadoCuenta;
        private Label label7;
        private ReaLTaiizor.Controls.DungeonTextBox textbNumeroCuenta;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox textbCodigoPin;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox textbNombreTitular;
        private Label label3;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox textbIdTitular;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox textbIdCuenta;
        private Label label8;
        private ReaLTaiizor.Controls.DungeonTextBox textbHuella;
        private ReaLTaiizor.Controls.CyberButton BuCapturarHuella;
        private ReaLTaiizor.Controls.CyberButton BuGuardar;
        private ReaLTaiizor.Controls.CyberButton BuBuscarPersonas;
        private ReaLTaiizor.Controls.CyberButton BuLimpiar;
        private FontAwesome.Sharp.IconPictureBox BuCapturarPIN;
    }
}
