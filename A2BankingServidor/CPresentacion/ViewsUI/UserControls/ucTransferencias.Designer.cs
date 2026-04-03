namespace CPresentacion.ViewsUI.UserControls
{
    partial class ucTransferencias
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
            label7 = new Label();
            textbRemitente = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            textbCuentaOrigen = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            textbCantidad = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            textbCuentaBalance = new ReaLTaiizor.Controls.DungeonTextBox();
            label4 = new Label();
            textbDestinatario = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            textbCuentaDesino = new ReaLTaiizor.Controls.DungeonTextBox();
            rTextbConcepto = new ReaLTaiizor.Controls.DungeonRichTextBox();
            label8 = new Label();
            BuTransferir = new ReaLTaiizor.Controls.CyberButton();
            pgBuBuscarOrigen = new FontAwesome.Sharp.IconPictureBox();
            pgBuBuscarDestino = new FontAwesome.Sharp.IconPictureBox();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pgBuBuscarOrigen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pgBuBuscarDestino).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(pgBuBuscarDestino);
            panelContainer.Controls.Add(pgBuBuscarOrigen);
            panelContainer.Controls.Add(BuTransferir);
            panelContainer.Controls.Add(label8);
            panelContainer.Controls.Add(rTextbConcepto);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(textbDestinatario);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(textbCuentaDesino);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbCantidad);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(textbCuentaBalance);
            panelContainer.Controls.Add(label7);
            panelContainer.Controls.Add(textbRemitente);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbCuentaOrigen);
            panelContainer.Controls.SetChildIndex(textbCuentaOrigen, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(textbRemitente, 0);
            panelContainer.Controls.SetChildIndex(label7, 0);
            panelContainer.Controls.SetChildIndex(textbCuentaBalance, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(textbCantidad, 0);
            panelContainer.Controls.SetChildIndex(label1, 0);
            panelContainer.Controls.SetChildIndex(textbCuentaDesino, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            panelContainer.Controls.SetChildIndex(textbDestinatario, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(rTextbConcepto, 0);
            panelContainer.Controls.SetChildIndex(label8, 0);
            panelContainer.Controls.SetChildIndex(BuTransferir, 0);
            panelContainer.Controls.SetChildIndex(pgBuBuscarOrigen, 0);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(pgBuBuscarDestino, 0);
            // 
            // pbIcono
            // 
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            // 
            // labelTexto
            // 
            labelTexto.Size = new Size(353, 36);
            labelTexto.Text = "Transferencias bancarias";
            // 
            // label6
            // 
            label6.Size = new Size(198, 22);
            label6.Text = "Lista de transferencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(244, 16);
            label7.Name = "label7";
            label7.Size = new Size(153, 22);
            label7.TabIndex = 32;
            label7.Text = "Titular remitente";
            // 
            // textbRemitente
            // 
            textbRemitente.BackColor = Color.Transparent;
            textbRemitente.BorderColor = Color.FromArgb(180, 180, 180);
            textbRemitente.EdgeColor = Color.White;
            textbRemitente.Enabled = false;
            textbRemitente.Font = new Font("Tahoma", 12F);
            textbRemitente.ForeColor = Color.Black;
            textbRemitente.Location = new Point(244, 41);
            textbRemitente.MaxLength = 32767;
            textbRemitente.Multiline = false;
            textbRemitente.Name = "textbRemitente";
            textbRemitente.ReadOnly = false;
            textbRemitente.Size = new Size(169, 30);
            textbRemitente.TabIndex = 31;
            textbRemitente.TextAlignment = HorizontalAlignment.Left;
            textbRemitente.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 16);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 30;
            label2.Text = "№ cuenta";
            // 
            // textbCuentaOrigen
            // 
            textbCuentaOrigen.BackColor = Color.Transparent;
            textbCuentaOrigen.BorderColor = Color.FromArgb(180, 180, 180);
            textbCuentaOrigen.EdgeColor = Color.White;
            textbCuentaOrigen.Font = new Font("Tahoma", 12F);
            textbCuentaOrigen.ForeColor = Color.Black;
            textbCuentaOrigen.Location = new Point(52, 41);
            textbCuentaOrigen.MaxLength = 32767;
            textbCuentaOrigen.Multiline = false;
            textbCuentaOrigen.Name = "textbCuentaOrigen";
            textbCuentaOrigen.ReadOnly = false;
            textbCuentaOrigen.Size = new Size(169, 30);
            textbCuentaOrigen.TabIndex = 29;
            textbCuentaOrigen.TextAlignment = HorizontalAlignment.Left;
            textbCuentaOrigen.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(244, 84);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 36;
            label1.Text = "Monto";
            // 
            // textbCantidad
            // 
            textbCantidad.BackColor = Color.Transparent;
            textbCantidad.BorderColor = Color.FromArgb(180, 180, 180);
            textbCantidad.EdgeColor = Color.White;
            textbCantidad.Font = new Font("Tahoma", 12F);
            textbCantidad.ForeColor = Color.Black;
            textbCantidad.Location = new Point(244, 109);
            textbCantidad.MaxLength = 32767;
            textbCantidad.Multiline = false;
            textbCantidad.Name = "textbCantidad";
            textbCantidad.ReadOnly = false;
            textbCantidad.Size = new Size(169, 30);
            textbCantidad.TabIndex = 35;
            textbCantidad.TextAlignment = HorizontalAlignment.Left;
            textbCantidad.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 84);
            label3.Name = "label3";
            label3.Size = new Size(168, 22);
            label3.TabIndex = 34;
            label3.Text = "Balance disponible";
            // 
            // textbCuentaBalance
            // 
            textbCuentaBalance.BackColor = Color.Transparent;
            textbCuentaBalance.BorderColor = Color.FromArgb(180, 180, 180);
            textbCuentaBalance.EdgeColor = Color.White;
            textbCuentaBalance.Enabled = false;
            textbCuentaBalance.Font = new Font("Tahoma", 12F);
            textbCuentaBalance.ForeColor = Color.Black;
            textbCuentaBalance.Location = new Point(52, 109);
            textbCuentaBalance.MaxLength = 32767;
            textbCuentaBalance.Multiline = false;
            textbCuentaBalance.Name = "textbCuentaBalance";
            textbCuentaBalance.ReadOnly = false;
            textbCuentaBalance.Size = new Size(169, 30);
            textbCuentaBalance.TabIndex = 33;
            textbCuentaBalance.TextAlignment = HorizontalAlignment.Left;
            textbCuentaBalance.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(244, 154);
            label4.Name = "label4";
            label4.Size = new Size(170, 22);
            label4.TabIndex = 40;
            label4.Text = "Titular destinatario";
            // 
            // textbDestinatario
            // 
            textbDestinatario.BackColor = Color.Transparent;
            textbDestinatario.BorderColor = Color.FromArgb(180, 180, 180);
            textbDestinatario.EdgeColor = Color.White;
            textbDestinatario.Enabled = false;
            textbDestinatario.Font = new Font("Tahoma", 12F);
            textbDestinatario.ForeColor = Color.Black;
            textbDestinatario.Location = new Point(244, 179);
            textbDestinatario.MaxLength = 32767;
            textbDestinatario.Multiline = false;
            textbDestinatario.Name = "textbDestinatario";
            textbDestinatario.ReadOnly = false;
            textbDestinatario.Size = new Size(169, 30);
            textbDestinatario.TabIndex = 39;
            textbDestinatario.TextAlignment = HorizontalAlignment.Left;
            textbDestinatario.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(52, 154);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 38;
            label5.Text = "№ cuenta";
            // 
            // textbCuentaDesino
            // 
            textbCuentaDesino.BackColor = Color.Transparent;
            textbCuentaDesino.BorderColor = Color.FromArgb(180, 180, 180);
            textbCuentaDesino.EdgeColor = Color.White;
            textbCuentaDesino.Font = new Font("Tahoma", 12F);
            textbCuentaDesino.ForeColor = Color.Black;
            textbCuentaDesino.Location = new Point(52, 179);
            textbCuentaDesino.MaxLength = 32767;
            textbCuentaDesino.Multiline = false;
            textbCuentaDesino.Name = "textbCuentaDesino";
            textbCuentaDesino.ReadOnly = false;
            textbCuentaDesino.Size = new Size(169, 30);
            textbCuentaDesino.TabIndex = 37;
            textbCuentaDesino.TextAlignment = HorizontalAlignment.Left;
            textbCuentaDesino.UseSystemPasswordChar = false;
            // 
            // rTextbConcepto
            // 
            rTextbConcepto.AutoWordSelection = false;
            rTextbConcepto.BackColor = Color.Transparent;
            rTextbConcepto.BorderColor = Color.FromArgb(180, 180, 180);
            rTextbConcepto.EdgeColor = Color.White;
            rTextbConcepto.Font = new Font("Tahoma", 10F);
            rTextbConcepto.ForeColor = Color.FromArgb(76, 76, 76);
            rTextbConcepto.Location = new Point(485, 41);
            rTextbConcepto.Name = "rTextbConcepto";
            rTextbConcepto.ReadOnly = false;
            rTextbConcepto.Size = new Size(269, 100);
            rTextbConcepto.TabIndex = 41;
            rTextbConcepto.TextBackColor = Color.White;
            rTextbConcepto.WordWrap = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(485, 16);
            label8.Name = "label8";
            label8.Size = new Size(230, 22);
            label8.TabIndex = 42;
            label8.Text = "Concepto de transferencia";
            // 
            // BuTransferir
            // 
            BuTransferir.Alpha = 20;
            BuTransferir.BackColor = Color.Transparent;
            BuTransferir.Background = true;
            BuTransferir.Background_WidthPen = 4F;
            BuTransferir.BackgroundPen = true;
            BuTransferir.ColorBackground = Color.Green;
            BuTransferir.ColorBackground_1 = Color.Green;
            BuTransferir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BuTransferir.ColorBackground_Pen = Color.DarkGray;
            BuTransferir.ColorLighting = Color.DarkGray;
            BuTransferir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BuTransferir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BuTransferir.Cursor = Cursors.Hand;
            BuTransferir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BuTransferir.Effect_1 = true;
            BuTransferir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BuTransferir.Effect_1_Transparency = 25;
            BuTransferir.Effect_2 = true;
            BuTransferir.Effect_2_ColorBackground = Color.White;
            BuTransferir.Effect_2_Transparency = 20;
            BuTransferir.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            BuTransferir.ForeColor = Color.FromArgb(245, 245, 245);
            BuTransferir.Lighting = false;
            BuTransferir.LinearGradient_Background = false;
            BuTransferir.LinearGradientPen = false;
            BuTransferir.Location = new Point(585, 166);
            BuTransferir.Name = "BuTransferir";
            BuTransferir.PenWidth = 15;
            BuTransferir.Rounding = true;
            BuTransferir.RoundingInt = 70;
            BuTransferir.Size = new Size(169, 43);
            BuTransferir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BuTransferir.TabIndex = 43;
            BuTransferir.Tag = "Cyber";
            BuTransferir.TextButton = "Transferir";
            BuTransferir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BuTransferir.Timer_Effect_1 = 5;
            BuTransferir.Timer_RGB = 300;
            BuTransferir.Click += BuTransferir_Click;
            // 
            // pgBuBuscarOrigen
            // 
            pgBuBuscarOrigen.BackColor = Color.Transparent;
            pgBuBuscarOrigen.ForeColor = Color.Gray;
            pgBuBuscarOrigen.IconChar = FontAwesome.Sharp.IconChar.Search;
            pgBuBuscarOrigen.IconColor = Color.Gray;
            pgBuBuscarOrigen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pgBuBuscarOrigen.IconSize = 39;
            pgBuBuscarOrigen.Location = new Point(422, 41);
            pgBuBuscarOrigen.Name = "pgBuBuscarOrigen";
            pgBuBuscarOrigen.Size = new Size(39, 40);
            pgBuBuscarOrigen.TabIndex = 44;
            pgBuBuscarOrigen.TabStop = false;
            pgBuBuscarOrigen.Click += pgBuBuscarOrigen_Click;
            // 
            // pgBuBuscarDestino
            // 
            pgBuBuscarDestino.BackColor = Color.Transparent;
            pgBuBuscarDestino.ForeColor = Color.Gray;
            pgBuBuscarDestino.IconChar = FontAwesome.Sharp.IconChar.Search;
            pgBuBuscarDestino.IconColor = Color.Gray;
            pgBuBuscarDestino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pgBuBuscarDestino.IconSize = 39;
            pgBuBuscarDestino.Location = new Point(422, 179);
            pgBuBuscarDestino.Name = "pgBuBuscarDestino";
            pgBuBuscarDestino.Size = new Size(39, 40);
            pgBuBuscarDestino.TabIndex = 45;
            pgBuBuscarDestino.TabStop = false;
            pgBuBuscarDestino.Click += pgBuBuscarDestino_Click;
            // 
            // ucTransferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucTransferencias";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ((System.ComponentModel.ISupportInitialize)pgBuBuscarOrigen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pgBuBuscarDestino).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private ReaLTaiizor.Controls.DungeonTextBox textbRemitente;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox textbCuentaOrigen;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox textbDestinatario;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox textbCuentaDesino;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox textbCantidad;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox textbCuentaBalance;
        private Label label8;
        private ReaLTaiizor.Controls.DungeonRichTextBox rTextbConcepto;
        private ReaLTaiizor.Controls.CyberButton BuTransferir;
        private FontAwesome.Sharp.IconPictureBox pgBuBuscarOrigen;
        private FontAwesome.Sharp.IconPictureBox pgBuBuscarDestino;
    }
}
