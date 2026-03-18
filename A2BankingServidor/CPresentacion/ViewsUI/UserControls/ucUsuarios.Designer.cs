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
            this.textbPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            this.textbUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            comboRoles = new ReaLTaiizor.Controls.AloneComboBox();
            panelInformacion.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(comboRoles);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(this.textbPassword);
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(this.textbUsuario);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(textbNombre);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbIdUsuario);
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
            this.textbPassword.BackColor = Color.Transparent;
            this.textbPassword.BorderColor = Color.FromArgb(180, 180, 180);
            this.textbPassword.EdgeColor = Color.White;
            this.textbPassword.Font = new Font("Tahoma", 12F);
            this.textbPassword.ForeColor = Color.Black;
            this.textbPassword.Location = new Point(244, 205);
            this.textbPassword.MaxLength = 32767;
            this.textbPassword.Multiline = false;
            this.textbPassword.Name = "textbPassword";
            this.textbPassword.ReadOnly = false;
            this.textbPassword.Size = new Size(169, 30);
            this.textbPassword.TabIndex = 10;
            this.textbPassword.TextAlignment = HorizontalAlignment.Left;
            this.textbPassword.UseSystemPasswordChar = false;
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
            this.textbUsuario.BackColor = Color.Transparent;
            this.textbUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            this.textbUsuario.EdgeColor = Color.White;
            this.textbUsuario.Font = new Font("Tahoma", 12F);
            this.textbUsuario.ForeColor = Color.Black;
            this.textbUsuario.Location = new Point(244, 130);
            this.textbUsuario.MaxLength = 32767;
            this.textbUsuario.Multiline = false;
            this.textbUsuario.Name = "textbUsuario";
            this.textbUsuario.ReadOnly = false;
            this.textbUsuario.Size = new Size(169, 30);
            this.textbUsuario.TabIndex = 8;
            this.textbUsuario.TextAlignment = HorizontalAlignment.Left;
            this.textbUsuario.UseSystemPasswordChar = false;
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
    }
}
