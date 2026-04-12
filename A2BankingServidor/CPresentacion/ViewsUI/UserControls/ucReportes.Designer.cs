namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucReportes
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
            panelInformacion = new Panel();
            labelTexto = new Label();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panelBotones = new Panel();
            panelReportesServicios = new Panel();
            BuTransferencias = new ReaLTaiizor.Controls.CyberButton();
            BuRetiros = new ReaLTaiizor.Controls.CyberButton();
            BuDepositos = new ReaLTaiizor.Controls.CyberButton();
            BuReportesServicios = new ReaLTaiizor.Controls.CyberButton();
            panelReportesCuentas = new Panel();
            BuCuentasCanceladas = new ReaLTaiizor.Controls.CyberButton();
            BuCuentasInactivas = new ReaLTaiizor.Controls.CyberButton();
            BuCuentasActivas = new ReaLTaiizor.Controls.CyberButton();
            BuCuentasGeneral = new ReaLTaiizor.Controls.CyberButton();
            BuCuentas = new ReaLTaiizor.Controls.CyberButton();
            panelInfo = new Panel();
            panelContainer = new Panel();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            panelBotones.SuspendLayout();
            panelReportesServicios.SuspendLayout();
            panelReportesCuentas.SuspendLayout();
            panelInfo.SuspendLayout();
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
            panelInformacion.Size = new Size(801, 72);
            panelInformacion.TabIndex = 2;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(108, 24);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(137, 36);
            labelTexto.TabIndex = 5;
            labelTexto.Text = "Reportes";
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.Transparent;
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.FileText;
            pbIcono.IconColor = Color.White;
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 50;
            pbIcono.Location = new Point(52, 16);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(50, 50);
            pbIcono.TabIndex = 4;
            pbIcono.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 5);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 16;
            label1.Text = "Opciones";
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(panelReportesServicios);
            panelBotones.Controls.Add(BuReportesServicios);
            panelBotones.Controls.Add(panelReportesCuentas);
            panelBotones.Controls.Add(BuCuentas);
            panelBotones.Controls.Add(panelInfo);
            panelBotones.Dock = DockStyle.Right;
            panelBotones.Location = new Point(640, 72);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(161, 531);
            panelBotones.TabIndex = 17;
            // 
            // panelReportesServicios
            // 
            panelReportesServicios.BackColor = Color.WhiteSmoke;
            panelReportesServicios.Controls.Add(BuTransferencias);
            panelReportesServicios.Controls.Add(BuRetiros);
            panelReportesServicios.Controls.Add(BuDepositos);
            panelReportesServicios.Dock = DockStyle.Top;
            panelReportesServicios.Location = new Point(0, 257);
            panelReportesServicios.Name = "panelReportesServicios";
            panelReportesServicios.Size = new Size(161, 117);
            panelReportesServicios.TabIndex = 5;
            panelReportesServicios.Visible = false;
            // 
            // BuTransferencias
            // 
            BuTransferencias.Alpha = 20;
            BuTransferencias.BackColor = Color.Transparent;
            BuTransferencias.Background = true;
            BuTransferencias.Background_WidthPen = 4F;
            BuTransferencias.BackgroundPen = true;
            BuTransferencias.ColorBackground = Color.CadetBlue;
            BuTransferencias.ColorBackground_1 = Color.CadetBlue;
            BuTransferencias.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuTransferencias.ColorBackground_Pen = Color.DarkGray;
            BuTransferencias.ColorLighting = Color.DarkGray;
            BuTransferencias.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuTransferencias.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuTransferencias.Cursor = Cursors.Hand;
            BuTransferencias.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuTransferencias.Dock = DockStyle.Top;
            BuTransferencias.Effect_1 = true;
            BuTransferencias.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuTransferencias.Effect_1_Transparency = 25;
            BuTransferencias.Effect_2 = true;
            BuTransferencias.Effect_2_ColorBackground = Color.White;
            BuTransferencias.Effect_2_Transparency = 20;
            BuTransferencias.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuTransferencias.ForeColor = Color.FromArgb(245, 245, 245);
            BuTransferencias.Lighting = false;
            BuTransferencias.LinearGradient_Background = false;
            BuTransferencias.LinearGradientPen = false;
            BuTransferencias.Location = new Point(0, 70);
            BuTransferencias.Name = "BuTransferencias";
            BuTransferencias.PenWidth = 15;
            BuTransferencias.Rounding = true;
            BuTransferencias.RoundingInt = 70;
            BuTransferencias.Size = new Size(161, 35);
            BuTransferencias.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuTransferencias.TabIndex = 4;
            BuTransferencias.Tag = "Cyber";
            BuTransferencias.TextButton = "Transferencias";
            BuTransferencias.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuTransferencias.Timer_Effect_1 = 5;
            BuTransferencias.Timer_RGB = 300;
            // 
            // BuRetiros
            // 
            BuRetiros.Alpha = 20;
            BuRetiros.BackColor = Color.Transparent;
            BuRetiros.Background = true;
            BuRetiros.Background_WidthPen = 4F;
            BuRetiros.BackgroundPen = true;
            BuRetiros.ColorBackground = Color.CadetBlue;
            BuRetiros.ColorBackground_1 = Color.CadetBlue;
            BuRetiros.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuRetiros.ColorBackground_Pen = Color.DarkGray;
            BuRetiros.ColorLighting = Color.DarkGray;
            BuRetiros.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuRetiros.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuRetiros.Cursor = Cursors.Hand;
            BuRetiros.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuRetiros.Dock = DockStyle.Top;
            BuRetiros.Effect_1 = true;
            BuRetiros.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuRetiros.Effect_1_Transparency = 25;
            BuRetiros.Effect_2 = true;
            BuRetiros.Effect_2_ColorBackground = Color.White;
            BuRetiros.Effect_2_Transparency = 20;
            BuRetiros.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuRetiros.ForeColor = Color.FromArgb(245, 245, 245);
            BuRetiros.Lighting = false;
            BuRetiros.LinearGradient_Background = false;
            BuRetiros.LinearGradientPen = false;
            BuRetiros.Location = new Point(0, 35);
            BuRetiros.Name = "BuRetiros";
            BuRetiros.PenWidth = 15;
            BuRetiros.Rounding = true;
            BuRetiros.RoundingInt = 70;
            BuRetiros.Size = new Size(161, 35);
            BuRetiros.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuRetiros.TabIndex = 3;
            BuRetiros.Tag = "Cyber";
            BuRetiros.TextButton = "Retiros";
            BuRetiros.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuRetiros.Timer_Effect_1 = 5;
            BuRetiros.Timer_RGB = 300;
            // 
            // BuDepositos
            // 
            BuDepositos.Alpha = 20;
            BuDepositos.BackColor = Color.Transparent;
            BuDepositos.Background = true;
            BuDepositos.Background_WidthPen = 4F;
            BuDepositos.BackgroundPen = true;
            BuDepositos.ColorBackground = Color.CadetBlue;
            BuDepositos.ColorBackground_1 = Color.CadetBlue;
            BuDepositos.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuDepositos.ColorBackground_Pen = Color.DarkGray;
            BuDepositos.ColorLighting = Color.DarkGray;
            BuDepositos.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuDepositos.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuDepositos.Cursor = Cursors.Hand;
            BuDepositos.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuDepositos.Dock = DockStyle.Top;
            BuDepositos.Effect_1 = true;
            BuDepositos.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuDepositos.Effect_1_Transparency = 25;
            BuDepositos.Effect_2 = true;
            BuDepositos.Effect_2_ColorBackground = Color.White;
            BuDepositos.Effect_2_Transparency = 20;
            BuDepositos.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuDepositos.ForeColor = Color.FromArgb(245, 245, 245);
            BuDepositos.Lighting = false;
            BuDepositos.LinearGradient_Background = false;
            BuDepositos.LinearGradientPen = false;
            BuDepositos.Location = new Point(0, 0);
            BuDepositos.Name = "BuDepositos";
            BuDepositos.PenWidth = 15;
            BuDepositos.Rounding = true;
            BuDepositos.RoundingInt = 70;
            BuDepositos.Size = new Size(161, 35);
            BuDepositos.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuDepositos.TabIndex = 2;
            BuDepositos.Tag = "Cyber";
            BuDepositos.TextButton = "Dépositos";
            BuDepositos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuDepositos.Timer_Effect_1 = 5;
            BuDepositos.Timer_RGB = 300;
            // 
            // BuReportesServicios
            // 
            BuReportesServicios.Alpha = 20;
            BuReportesServicios.BackColor = Color.Transparent;
            BuReportesServicios.Background = true;
            BuReportesServicios.Background_WidthPen = 4F;
            BuReportesServicios.BackgroundPen = true;
            BuReportesServicios.ColorBackground = Color.FromArgb(77, 182, 198);
            BuReportesServicios.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuReportesServicios.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuReportesServicios.ColorBackground_Pen = Color.DarkGray;
            BuReportesServicios.ColorLighting = Color.DarkGray;
            BuReportesServicios.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuReportesServicios.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuReportesServicios.Cursor = Cursors.Hand;
            BuReportesServicios.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuReportesServicios.Dock = DockStyle.Top;
            BuReportesServicios.Effect_1 = true;
            BuReportesServicios.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuReportesServicios.Effect_1_Transparency = 25;
            BuReportesServicios.Effect_2 = true;
            BuReportesServicios.Effect_2_ColorBackground = Color.White;
            BuReportesServicios.Effect_2_Transparency = 20;
            BuReportesServicios.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuReportesServicios.ForeColor = Color.FromArgb(245, 245, 245);
            BuReportesServicios.Lighting = false;
            BuReportesServicios.LinearGradient_Background = false;
            BuReportesServicios.LinearGradientPen = false;
            BuReportesServicios.Location = new Point(0, 222);
            BuReportesServicios.Name = "BuReportesServicios";
            BuReportesServicios.PenWidth = 15;
            BuReportesServicios.Rounding = true;
            BuReportesServicios.RoundingInt = 70;
            BuReportesServicios.Size = new Size(161, 35);
            BuReportesServicios.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuReportesServicios.TabIndex = 5;
            BuReportesServicios.Tag = "Cyber";
            BuReportesServicios.TextButton = "Servicios";
            BuReportesServicios.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuReportesServicios.Timer_Effect_1 = 5;
            BuReportesServicios.Timer_RGB = 300;
            BuReportesServicios.Click += BuReportesServicios_Click;
            // 
            // panelReportesCuentas
            // 
            panelReportesCuentas.BackColor = Color.WhiteSmoke;
            panelReportesCuentas.Controls.Add(BuCuentasCanceladas);
            panelReportesCuentas.Controls.Add(BuCuentasInactivas);
            panelReportesCuentas.Controls.Add(BuCuentasActivas);
            panelReportesCuentas.Controls.Add(BuCuentasGeneral);
            panelReportesCuentas.Dock = DockStyle.Top;
            panelReportesCuentas.Location = new Point(0, 68);
            panelReportesCuentas.Name = "panelReportesCuentas";
            panelReportesCuentas.Size = new Size(161, 154);
            panelReportesCuentas.TabIndex = 4;
            panelReportesCuentas.Visible = false;
            // 
            // BuCuentasCanceladas
            // 
            BuCuentasCanceladas.Alpha = 20;
            BuCuentasCanceladas.BackColor = Color.Transparent;
            BuCuentasCanceladas.Background = true;
            BuCuentasCanceladas.Background_WidthPen = 4F;
            BuCuentasCanceladas.BackgroundPen = true;
            BuCuentasCanceladas.ColorBackground = Color.CadetBlue;
            BuCuentasCanceladas.ColorBackground_1 = Color.CadetBlue;
            BuCuentasCanceladas.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuCuentasCanceladas.ColorBackground_Pen = Color.DarkGray;
            BuCuentasCanceladas.ColorLighting = Color.DarkGray;
            BuCuentasCanceladas.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuCuentasCanceladas.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuCuentasCanceladas.Cursor = Cursors.Hand;
            BuCuentasCanceladas.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuCuentasCanceladas.Dock = DockStyle.Top;
            BuCuentasCanceladas.Effect_1 = true;
            BuCuentasCanceladas.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuCuentasCanceladas.Effect_1_Transparency = 25;
            BuCuentasCanceladas.Effect_2 = true;
            BuCuentasCanceladas.Effect_2_ColorBackground = Color.White;
            BuCuentasCanceladas.Effect_2_Transparency = 20;
            BuCuentasCanceladas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuCuentasCanceladas.ForeColor = Color.FromArgb(245, 245, 245);
            BuCuentasCanceladas.Lighting = false;
            BuCuentasCanceladas.LinearGradient_Background = false;
            BuCuentasCanceladas.LinearGradientPen = false;
            BuCuentasCanceladas.Location = new Point(0, 105);
            BuCuentasCanceladas.Name = "BuCuentasCanceladas";
            BuCuentasCanceladas.PenWidth = 15;
            BuCuentasCanceladas.Rounding = true;
            BuCuentasCanceladas.RoundingInt = 70;
            BuCuentasCanceladas.Size = new Size(161, 35);
            BuCuentasCanceladas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuCuentasCanceladas.TabIndex = 5;
            BuCuentasCanceladas.Tag = "Cyber";
            BuCuentasCanceladas.TextButton = "Canceladas";
            BuCuentasCanceladas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuCuentasCanceladas.Timer_Effect_1 = 5;
            BuCuentasCanceladas.Timer_RGB = 300;
            BuCuentasCanceladas.Click += BuCuentasCanceladas_Click;
            // 
            // BuCuentasInactivas
            // 
            BuCuentasInactivas.Alpha = 20;
            BuCuentasInactivas.BackColor = Color.Transparent;
            BuCuentasInactivas.Background = true;
            BuCuentasInactivas.Background_WidthPen = 4F;
            BuCuentasInactivas.BackgroundPen = true;
            BuCuentasInactivas.ColorBackground = Color.CadetBlue;
            BuCuentasInactivas.ColorBackground_1 = Color.CadetBlue;
            BuCuentasInactivas.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuCuentasInactivas.ColorBackground_Pen = Color.DarkGray;
            BuCuentasInactivas.ColorLighting = Color.DarkGray;
            BuCuentasInactivas.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuCuentasInactivas.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuCuentasInactivas.Cursor = Cursors.Hand;
            BuCuentasInactivas.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuCuentasInactivas.Dock = DockStyle.Top;
            BuCuentasInactivas.Effect_1 = true;
            BuCuentasInactivas.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuCuentasInactivas.Effect_1_Transparency = 25;
            BuCuentasInactivas.Effect_2 = true;
            BuCuentasInactivas.Effect_2_ColorBackground = Color.White;
            BuCuentasInactivas.Effect_2_Transparency = 20;
            BuCuentasInactivas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuCuentasInactivas.ForeColor = Color.FromArgb(245, 245, 245);
            BuCuentasInactivas.Lighting = false;
            BuCuentasInactivas.LinearGradient_Background = false;
            BuCuentasInactivas.LinearGradientPen = false;
            BuCuentasInactivas.Location = new Point(0, 70);
            BuCuentasInactivas.Name = "BuCuentasInactivas";
            BuCuentasInactivas.PenWidth = 15;
            BuCuentasInactivas.Rounding = true;
            BuCuentasInactivas.RoundingInt = 70;
            BuCuentasInactivas.Size = new Size(161, 35);
            BuCuentasInactivas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuCuentasInactivas.TabIndex = 4;
            BuCuentasInactivas.Tag = "Cyber";
            BuCuentasInactivas.TextButton = "Inactivas";
            BuCuentasInactivas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuCuentasInactivas.Timer_Effect_1 = 5;
            BuCuentasInactivas.Timer_RGB = 300;
            BuCuentasInactivas.Click += BuCuentasInactivas_Click;
            // 
            // BuCuentasActivas
            // 
            BuCuentasActivas.Alpha = 20;
            BuCuentasActivas.BackColor = Color.Transparent;
            BuCuentasActivas.Background = true;
            BuCuentasActivas.Background_WidthPen = 4F;
            BuCuentasActivas.BackgroundPen = true;
            BuCuentasActivas.ColorBackground = Color.CadetBlue;
            BuCuentasActivas.ColorBackground_1 = Color.CadetBlue;
            BuCuentasActivas.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuCuentasActivas.ColorBackground_Pen = Color.DarkGray;
            BuCuentasActivas.ColorLighting = Color.DarkGray;
            BuCuentasActivas.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuCuentasActivas.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuCuentasActivas.Cursor = Cursors.Hand;
            BuCuentasActivas.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuCuentasActivas.Dock = DockStyle.Top;
            BuCuentasActivas.Effect_1 = true;
            BuCuentasActivas.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuCuentasActivas.Effect_1_Transparency = 25;
            BuCuentasActivas.Effect_2 = true;
            BuCuentasActivas.Effect_2_ColorBackground = Color.White;
            BuCuentasActivas.Effect_2_Transparency = 20;
            BuCuentasActivas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuCuentasActivas.ForeColor = Color.FromArgb(245, 245, 245);
            BuCuentasActivas.Lighting = false;
            BuCuentasActivas.LinearGradient_Background = false;
            BuCuentasActivas.LinearGradientPen = false;
            BuCuentasActivas.Location = new Point(0, 35);
            BuCuentasActivas.Name = "BuCuentasActivas";
            BuCuentasActivas.PenWidth = 15;
            BuCuentasActivas.Rounding = true;
            BuCuentasActivas.RoundingInt = 70;
            BuCuentasActivas.Size = new Size(161, 35);
            BuCuentasActivas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuCuentasActivas.TabIndex = 3;
            BuCuentasActivas.Tag = "Cyber";
            BuCuentasActivas.TextButton = "Activas";
            BuCuentasActivas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuCuentasActivas.Timer_Effect_1 = 5;
            BuCuentasActivas.Timer_RGB = 300;
            BuCuentasActivas.Click += BuCuentasActivas_Click;
            // 
            // BuCuentasGeneral
            // 
            BuCuentasGeneral.Alpha = 20;
            BuCuentasGeneral.BackColor = Color.Transparent;
            BuCuentasGeneral.Background = true;
            BuCuentasGeneral.Background_WidthPen = 4F;
            BuCuentasGeneral.BackgroundPen = true;
            BuCuentasGeneral.ColorBackground = Color.CadetBlue;
            BuCuentasGeneral.ColorBackground_1 = Color.CadetBlue;
            BuCuentasGeneral.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuCuentasGeneral.ColorBackground_Pen = Color.DarkGray;
            BuCuentasGeneral.ColorLighting = Color.DarkGray;
            BuCuentasGeneral.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuCuentasGeneral.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuCuentasGeneral.Cursor = Cursors.Hand;
            BuCuentasGeneral.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuCuentasGeneral.Dock = DockStyle.Top;
            BuCuentasGeneral.Effect_1 = true;
            BuCuentasGeneral.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuCuentasGeneral.Effect_1_Transparency = 25;
            BuCuentasGeneral.Effect_2 = true;
            BuCuentasGeneral.Effect_2_ColorBackground = Color.White;
            BuCuentasGeneral.Effect_2_Transparency = 20;
            BuCuentasGeneral.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuCuentasGeneral.ForeColor = Color.FromArgb(245, 245, 245);
            BuCuentasGeneral.Lighting = false;
            BuCuentasGeneral.LinearGradient_Background = false;
            BuCuentasGeneral.LinearGradientPen = false;
            BuCuentasGeneral.Location = new Point(0, 0);
            BuCuentasGeneral.Name = "BuCuentasGeneral";
            BuCuentasGeneral.PenWidth = 15;
            BuCuentasGeneral.Rounding = true;
            BuCuentasGeneral.RoundingInt = 70;
            BuCuentasGeneral.Size = new Size(161, 35);
            BuCuentasGeneral.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuCuentasGeneral.TabIndex = 2;
            BuCuentasGeneral.Tag = "Cyber";
            BuCuentasGeneral.TextButton = "General";
            BuCuentasGeneral.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuCuentasGeneral.Timer_Effect_1 = 5;
            BuCuentasGeneral.Timer_RGB = 300;
            BuCuentasGeneral.Click += BuCuentasGeneral_Click;
            // 
            // BuCuentas
            // 
            BuCuentas.Alpha = 20;
            BuCuentas.BackColor = Color.Transparent;
            BuCuentas.Background = true;
            BuCuentas.Background_WidthPen = 4F;
            BuCuentas.BackgroundPen = true;
            BuCuentas.ColorBackground = Color.FromArgb(77, 182, 198);
            BuCuentas.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuCuentas.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuCuentas.ColorBackground_Pen = Color.DarkGray;
            BuCuentas.ColorLighting = Color.DarkGray;
            BuCuentas.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuCuentas.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuCuentas.Cursor = Cursors.Hand;
            BuCuentas.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuCuentas.Dock = DockStyle.Top;
            BuCuentas.Effect_1 = true;
            BuCuentas.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuCuentas.Effect_1_Transparency = 25;
            BuCuentas.Effect_2 = true;
            BuCuentas.Effect_2_ColorBackground = Color.White;
            BuCuentas.Effect_2_Transparency = 20;
            BuCuentas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuCuentas.ForeColor = Color.FromArgb(245, 245, 245);
            BuCuentas.Lighting = false;
            BuCuentas.LinearGradient_Background = false;
            BuCuentas.LinearGradientPen = false;
            BuCuentas.Location = new Point(0, 33);
            BuCuentas.Name = "BuCuentas";
            BuCuentas.PenWidth = 15;
            BuCuentas.Rounding = true;
            BuCuentas.RoundingInt = 70;
            BuCuentas.Size = new Size(161, 35);
            BuCuentas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuCuentas.TabIndex = 1;
            BuCuentas.Tag = "Cyber";
            BuCuentas.TextButton = "Cuentas";
            BuCuentas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuCuentas.Timer_Effect_1 = 5;
            BuCuentas.Timer_RGB = 300;
            BuCuentas.Click += BuCuentas_Click;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.WhiteSmoke;
            panelInfo.Controls.Add(label1);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(161, 33);
            panelInfo.TabIndex = 2;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Gainsboro;
            panelContainer.Dock = DockStyle.Left;
            panelContainer.Location = new Point(0, 72);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(640, 531);
            panelContainer.TabIndex = 18;
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(0, 0);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(396, 246);
            reportViewer.TabIndex = 0;
            // 
            // ucReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Controls.Add(panelBotones);
            Controls.Add(panelInformacion);
            Name = "ucReportes";
            Size = new Size(801, 603);
            Load += ucReportes_Load;
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            panelBotones.ResumeLayout(false);
            panelReportesServicios.ResumeLayout(false);
            panelReportesCuentas.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel panelInformacion;
        public Label labelTexto;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        public Panel panelBotones;
        public Label label1;
        private Panel panelContainer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panelInfo;
        private ReaLTaiizor.Controls.CyberButton BuCuentas;
        private Panel panelReportesCuentas;
        private ReaLTaiizor.Controls.CyberButton BuCuentasGeneral;
        private ReaLTaiizor.Controls.CyberButton BuCuentasInactivas;
        private ReaLTaiizor.Controls.CyberButton BuCuentasActivas;
        private ReaLTaiizor.Controls.CyberButton BuCuentasCanceladas;
        private ReaLTaiizor.Controls.CyberButton BuReportesServicios;
        private Panel panelReportesServicios;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.CyberButton BuTransferencias;
        private ReaLTaiizor.Controls.CyberButton BuRetiros;
        private ReaLTaiizor.Controls.CyberButton BuDepositos;
    }
}
