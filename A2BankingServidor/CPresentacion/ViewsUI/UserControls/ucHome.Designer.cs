namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucHome
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
            components = new System.ComponentModel.Container();
            panelContainer = new Panel();
            GroupbInfoPerfil = new ReaLTaiizor.Controls.ThunderGroupBox();
            LbRol = new Label();
            label3 = new Label();
            LbNombre = new Label();
            label1 = new Label();
            BuSalir = new ReaLTaiizor.Controls.CyberButton();
            pbPerfil = new PictureBox();
            panelInformacion = new Panel();
            LbFecha = new Label();
            LbHora = new Label();
            labelTexto = new Label();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            horaFecha = new System.Windows.Forms.Timer(components);
            panelContainer.SuspendLayout();
            GroupbInfoPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(GroupbInfoPerfil);
            panelContainer.Controls.Add(pbPerfil);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 72);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(801, 531);
            panelContainer.TabIndex = 3;
            // 
            // GroupbInfoPerfil
            // 
            GroupbInfoPerfil.BackColor = Color.Transparent;
            GroupbInfoPerfil.BodyColorA = Color.FromArgb(167, 189, 209);
            GroupbInfoPerfil.BodyColorB = Color.FromArgb(93, 127, 174);
            GroupbInfoPerfil.BodyColorC = Color.Silver;
            GroupbInfoPerfil.BodyColorD = Color.WhiteSmoke;
            GroupbInfoPerfil.Controls.Add(LbRol);
            GroupbInfoPerfil.Controls.Add(label3);
            GroupbInfoPerfil.Controls.Add(LbNombre);
            GroupbInfoPerfil.Controls.Add(label1);
            GroupbInfoPerfil.Controls.Add(BuSalir);
            GroupbInfoPerfil.ForeColor = Color.Black;
            GroupbInfoPerfil.Location = new Point(582, 92);
            GroupbInfoPerfil.Name = "GroupbInfoPerfil";
            GroupbInfoPerfil.Size = new Size(202, 237);
            GroupbInfoPerfil.TabIndex = 18;
            GroupbInfoPerfil.Text = "Mi Información";
            GroupbInfoPerfil.Visible = false;
            // 
            // LbRol
            // 
            LbRol.AutoSize = true;
            LbRol.BackColor = Color.Transparent;
            LbRol.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbRol.ForeColor = Color.Black;
            LbRol.Location = new Point(13, 106);
            LbRol.Name = "LbRol";
            LbRol.Size = new Size(35, 18);
            LbRol.TabIndex = 22;
            LbRol.Text = "Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 21;
            label3.Text = "Rol:";
            // 
            // LbNombre
            // 
            LbNombre.AutoSize = true;
            LbNombre.BackColor = Color.Transparent;
            LbNombre.Font = new Font("Arial", 12F);
            LbNombre.ForeColor = Color.Black;
            LbNombre.Location = new Point(13, 56);
            LbNombre.Name = "LbNombre";
            LbNombre.Size = new Size(35, 18);
            LbNombre.TabIndex = 20;
            LbNombre.Text = "Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 19;
            label1.Text = "Nombre:";
            // 
            // BuSalir
            // 
            BuSalir.Alpha = 20;
            BuSalir.BackColor = Color.Transparent;
            BuSalir.Background = true;
            BuSalir.Background_WidthPen = 4F;
            BuSalir.BackgroundPen = true;
            BuSalir.ColorBackground = Color.FromArgb(77, 182, 198);
            BuSalir.ColorBackground_1 = Color.FromArgb(77, 182, 198);
            BuSalir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuSalir.ColorBackground_Pen = Color.DarkGray;
            BuSalir.ColorLighting = Color.DarkGray;
            BuSalir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuSalir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuSalir.Cursor = Cursors.Hand;
            BuSalir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuSalir.Effect_1 = true;
            BuSalir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuSalir.Effect_1_Transparency = 25;
            BuSalir.Effect_2 = true;
            BuSalir.Effect_2_ColorBackground = Color.White;
            BuSalir.Effect_2_Transparency = 20;
            BuSalir.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuSalir.ForeColor = Color.FromArgb(245, 245, 245);
            BuSalir.Lighting = false;
            BuSalir.LinearGradient_Background = false;
            BuSalir.LinearGradientPen = false;
            BuSalir.Location = new Point(31, 189);
            BuSalir.Name = "BuSalir";
            BuSalir.PenWidth = 15;
            BuSalir.Rounding = true;
            BuSalir.RoundingInt = 70;
            BuSalir.Size = new Size(140, 37);
            BuSalir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuSalir.TabIndex = 19;
            BuSalir.Tag = "Cyber";
            BuSalir.TextButton = "Cerrar Sesión";
            BuSalir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuSalir.Timer_Effect_1 = 5;
            BuSalir.Timer_RGB = 300;
            BuSalir.Click += BuSalir_Click;
            // 
            // pbPerfil
            // 
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.Perfil;
            pbPerfil.Location = new Point(724, 17);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(60, 60);
            pbPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerfil.TabIndex = 17;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // panelInformacion
            // 
            panelInformacion.BackColor = Color.FromArgb(77, 182, 198);
            panelInformacion.Controls.Add(LbFecha);
            panelInformacion.Controls.Add(LbHora);
            panelInformacion.Controls.Add(labelTexto);
            panelInformacion.Controls.Add(pbIcono);
            panelInformacion.Dock = DockStyle.Top;
            panelInformacion.Location = new Point(0, 0);
            panelInformacion.Name = "panelInformacion";
            panelInformacion.Size = new Size(801, 72);
            panelInformacion.TabIndex = 2;
            // 
            // LbFecha
            // 
            LbFecha.AutoSize = true;
            LbFecha.BackColor = Color.Transparent;
            LbFecha.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            LbFecha.ForeColor = Color.WhiteSmoke;
            LbFecha.Location = new Point(634, 38);
            LbFecha.Name = "LbFecha";
            LbFecha.Size = new Size(60, 22);
            LbFecha.TabIndex = 20;
            LbFecha.Text = "Fecha";
            // 
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.BackColor = Color.Transparent;
            LbHora.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            LbHora.ForeColor = Color.WhiteSmoke;
            LbHora.Location = new Point(634, 16);
            LbHora.Name = "LbHora";
            LbHora.Size = new Size(50, 22);
            LbHora.TabIndex = 19;
            LbHora.Text = "Hora";
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(108, 24);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(214, 36);
            labelTexto.TabIndex = 5;
            labelTexto.Text = "Menu de inicio";
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.Transparent;
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.House;
            pbIcono.IconColor = Color.White;
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 50;
            pbIcono.Location = new Point(52, 16);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(50, 50);
            pbIcono.TabIndex = 4;
            pbIcono.TabStop = false;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // ucHome
            // 
            Controls.Add(panelContainer);
            Controls.Add(panelInformacion);
            Name = "ucHome";
            Size = new Size(801, 603);
            panelContainer.ResumeLayout(false);
            GroupbInfoPerfil.ResumeLayout(false);
            GroupbInfoPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public Panel panelContainer;
        public Panel panelInformacion;
        public Label labelTexto;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        private PictureBox pbPerfil;
        private ReaLTaiizor.Controls.ThunderGroupBox GroupbInfoPerfil;
        public Label LbNombre;
        public Label label1;
        private ReaLTaiizor.Controls.CyberButton BuSalir;
        public Label LbRol;
        public Label label3;
        public Label LbFecha;
        public Label LbHora;
        private System.Windows.Forms.Timer horaFecha;
    }
}
