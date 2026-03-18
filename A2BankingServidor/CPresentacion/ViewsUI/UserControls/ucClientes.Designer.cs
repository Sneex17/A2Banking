namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucClientes
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
            BuBuscarPersonas = new ReaLTaiizor.Controls.CyberButton();
            BuGuardar = new ReaLTaiizor.Controls.CyberButton();
            label4 = new Label();
            textbOcupacion = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            textbEdad = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            label1 = new Label();
            textbNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            textbIdTitular = new ReaLTaiizor.Controls.DungeonTextBox();
            texbSexo = new ReaLTaiizor.Controls.DungeonTextBox();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(texbSexo);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(textbOcupacion);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(textbEdad);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbNombre);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdTitular);
            panelContainer.Controls.Add(BuGuardar);
            panelContainer.Controls.Add(BuBuscarPersonas);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(BuBuscarPersonas, 0);
            panelContainer.Controls.SetChildIndex(BuGuardar, 0);
            panelContainer.Controls.SetChildIndex(textbIdTitular, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(textbNombre, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(textbEdad, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            panelContainer.Controls.SetChildIndex(textbOcupacion, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(texbSexo, 0);
            // 
            // pbIcono
            // 
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            // 
            // labelTexto
            // 
            labelTexto.Size = new Size(273, 36);
            labelTexto.Text = "Gestión de clientes";
            // 
            // label6
            // 
            label6.Size = new Size(144, 22);
            label6.Text = "Lista de clientes";
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
            BuBuscarPersonas.Location = new Point(585, 26);
            BuBuscarPersonas.Name = "BuBuscarPersonas";
            BuBuscarPersonas.PenWidth = 15;
            BuBuscarPersonas.Rounding = true;
            BuBuscarPersonas.RoundingInt = 70;
            BuBuscarPersonas.Size = new Size(169, 43);
            BuBuscarPersonas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuBuscarPersonas.TabIndex = 17;
            BuBuscarPersonas.Tag = "Cyber";
            BuBuscarPersonas.TextButton = "Buscar";
            BuBuscarPersonas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuBuscarPersonas.Timer_Effect_1 = 5;
            BuBuscarPersonas.Timer_RGB = 300;
            BuBuscarPersonas.Click += BuBuscarPersonas_Click;
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
            BuGuardar.Location = new Point(585, 75);
            BuGuardar.Name = "BuGuardar";
            BuGuardar.PenWidth = 15;
            BuGuardar.Rounding = true;
            BuGuardar.RoundingInt = 70;
            BuGuardar.Size = new Size(169, 43);
            BuGuardar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuGuardar.TabIndex = 18;
            BuGuardar.Tag = "Cyber";
            BuGuardar.TextButton = "Registrar";
            BuGuardar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuGuardar.Timer_Effect_1 = 5;
            BuGuardar.Timer_RGB = 300;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(244, 171);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 27;
            label4.Text = "Ocupación";
            // 
            // textbOcupacion
            // 
            textbOcupacion.BackColor = Color.Transparent;
            textbOcupacion.BorderColor = Color.FromArgb(180, 180, 180);
            textbOcupacion.EdgeColor = Color.White;
            textbOcupacion.Enabled = false;
            textbOcupacion.Font = new Font("Tahoma", 12F);
            textbOcupacion.ForeColor = Color.Black;
            textbOcupacion.Location = new Point(244, 196);
            textbOcupacion.MaxLength = 32767;
            textbOcupacion.Multiline = false;
            textbOcupacion.Name = "textbOcupacion";
            textbOcupacion.ReadOnly = false;
            textbOcupacion.Size = new Size(169, 30);
            textbOcupacion.TabIndex = 26;
            textbOcupacion.TextAlignment = HorizontalAlignment.Left;
            textbOcupacion.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(244, 96);
            label5.Name = "label5";
            label5.Size = new Size(53, 22);
            label5.TabIndex = 25;
            label5.Text = "Edad";
            // 
            // textbEdad
            // 
            textbEdad.BackColor = Color.Transparent;
            textbEdad.BorderColor = Color.FromArgb(180, 180, 180);
            textbEdad.EdgeColor = Color.White;
            textbEdad.Enabled = false;
            textbEdad.Font = new Font("Tahoma", 12F);
            textbEdad.ForeColor = Color.Black;
            textbEdad.Location = new Point(244, 121);
            textbEdad.MaxLength = 32767;
            textbEdad.Multiline = false;
            textbEdad.Name = "textbEdad";
            textbEdad.ReadOnly = false;
            textbEdad.Size = new Size(169, 30);
            textbEdad.TabIndex = 24;
            textbEdad.TextAlignment = HorizontalAlignment.Left;
            textbEdad.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 171);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 23;
            label3.Text = "Sexo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 96);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // textbNombre
            // 
            textbNombre.BackColor = Color.Transparent;
            textbNombre.BorderColor = Color.FromArgb(180, 180, 180);
            textbNombre.EdgeColor = Color.White;
            textbNombre.Enabled = false;
            textbNombre.Font = new Font("Tahoma", 12F);
            textbNombre.ForeColor = Color.Black;
            textbNombre.Location = new Point(52, 121);
            textbNombre.MaxLength = 32767;
            textbNombre.Multiline = false;
            textbNombre.Name = "textbNombre";
            textbNombre.ReadOnly = false;
            textbNombre.Size = new Size(169, 30);
            textbNombre.TabIndex = 21;
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
            label2.Size = new Size(82, 22);
            label2.TabIndex = 20;
            label2.Text = "Id titular";
            // 
            // textbIdTitular
            // 
            textbIdTitular.BackColor = Color.Transparent;
            textbIdTitular.BorderColor = Color.FromArgb(180, 180, 180);
            textbIdTitular.EdgeColor = Color.White;
            textbIdTitular.Enabled = false;
            textbIdTitular.Font = new Font("Tahoma", 12F);
            textbIdTitular.ForeColor = Color.Black;
            textbIdTitular.Location = new Point(52, 55);
            textbIdTitular.MaxLength = 32767;
            textbIdTitular.Multiline = false;
            textbIdTitular.Name = "textbIdTitular";
            textbIdTitular.ReadOnly = false;
            textbIdTitular.Size = new Size(169, 30);
            textbIdTitular.TabIndex = 19;
            textbIdTitular.TextAlignment = HorizontalAlignment.Left;
            textbIdTitular.UseSystemPasswordChar = false;
            // 
            // texbSexo
            // 
            texbSexo.BackColor = Color.Transparent;
            texbSexo.BorderColor = Color.FromArgb(180, 180, 180);
            texbSexo.EdgeColor = Color.White;
            texbSexo.Enabled = false;
            texbSexo.Font = new Font("Tahoma", 12F);
            texbSexo.ForeColor = Color.Black;
            texbSexo.Location = new Point(52, 196);
            texbSexo.MaxLength = 32767;
            texbSexo.Multiline = false;
            texbSexo.Name = "texbSexo";
            texbSexo.ReadOnly = false;
            texbSexo.Size = new Size(169, 30);
            texbSexo.TabIndex = 28;
            texbSexo.TextAlignment = HorizontalAlignment.Left;
            texbSexo.UseSystemPasswordChar = false;
            // 
            // ucClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucClientes";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton BuGuardar;
        private ReaLTaiizor.Controls.CyberButton BuBuscarPersonas;
        private ReaLTaiizor.Controls.DungeonTextBox texbSexo;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox textbOcupacion;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox textbEdad;
        private Label label3;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox textbNombre;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox textbIdTitular;
    }
}
