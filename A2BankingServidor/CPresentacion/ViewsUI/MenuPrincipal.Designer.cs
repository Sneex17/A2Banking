namespace CPresentacion.ViewsUI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            controlMenuOpciones = new ReaLTaiizor.Controls.AirTabPage();
            tabpHome = new TabPage();
            tabpDepositos = new TabPage();
            tabpRetiros = new TabPage();
            tabpTranferencias = new TabPage();
            tabpCuentas = new TabPage();
            tabpClientes = new TabPage();
            tabpUsuarios = new TabPage();
            tabpReportes = new TabPage();
            controlMenuOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // controlMenuOpciones
            // 
            controlMenuOpciones.Alignment = TabAlignment.Left;
            controlMenuOpciones.BaseColor = Color.WhiteSmoke;
            controlMenuOpciones.Controls.Add(tabpHome);
            controlMenuOpciones.Controls.Add(tabpDepositos);
            controlMenuOpciones.Controls.Add(tabpRetiros);
            controlMenuOpciones.Controls.Add(tabpTranferencias);
            controlMenuOpciones.Controls.Add(tabpCuentas);
            controlMenuOpciones.Controls.Add(tabpClientes);
            controlMenuOpciones.Controls.Add(tabpUsuarios);
            controlMenuOpciones.Controls.Add(tabpReportes);
            controlMenuOpciones.Dock = DockStyle.Fill;
            controlMenuOpciones.Font = new Font("Montserrat SemiBold", 9.5F, FontStyle.Bold);
            controlMenuOpciones.ItemSize = new Size(30, 125);
            controlMenuOpciones.Location = new Point(0, 0);
            controlMenuOpciones.Multiline = true;
            controlMenuOpciones.Name = "controlMenuOpciones";
            controlMenuOpciones.NormalTextColor = Color.Black;
            controlMenuOpciones.SelectedIndex = 0;
            controlMenuOpciones.SelectedTabBackColor = Color.White;
            controlMenuOpciones.SelectedTextColor = Color.FromArgb(77, 182, 198);
            controlMenuOpciones.ShowOuterBorders = false;
            controlMenuOpciones.Size = new Size(934, 611);
            controlMenuOpciones.SizeMode = TabSizeMode.Fixed;
            controlMenuOpciones.SquareColor = Color.FromArgb(77, 182, 198);
            controlMenuOpciones.TabCursor = Cursors.Hand;
            controlMenuOpciones.TabIndex = 0;
            controlMenuOpciones.SelectedIndexChanged += controlMenuOpciones_SelectedIndexChanged;
            // 
            // tabpHome
            // 
            tabpHome.BackColor = Color.White;
            tabpHome.Location = new Point(129, 4);
            tabpHome.Name = "tabpHome";
            tabpHome.Padding = new Padding(3);
            tabpHome.Size = new Size(801, 603);
            tabpHome.TabIndex = 0;
            tabpHome.Text = "Home";
            // 
            // tabpDepositos
            // 
            tabpDepositos.BackColor = Color.White;
            tabpDepositos.Location = new Point(129, 4);
            tabpDepositos.Name = "tabpDepositos";
            tabpDepositos.Padding = new Padding(3);
            tabpDepositos.Size = new Size(801, 603);
            tabpDepositos.TabIndex = 1;
            tabpDepositos.Text = "Depósitos";
            // 
            // tabpRetiros
            // 
            tabpRetiros.BackColor = Color.White;
            tabpRetiros.Location = new Point(129, 4);
            tabpRetiros.Name = "tabpRetiros";
            tabpRetiros.Size = new Size(801, 603);
            tabpRetiros.TabIndex = 2;
            tabpRetiros.Text = "Retiros";
            // 
            // tabpTranferencias
            // 
            tabpTranferencias.BackColor = Color.White;
            tabpTranferencias.Location = new Point(129, 4);
            tabpTranferencias.Name = "tabpTranferencias";
            tabpTranferencias.Size = new Size(801, 603);
            tabpTranferencias.TabIndex = 3;
            tabpTranferencias.Text = "Tranferencias";
            // 
            // tabpCuentas
            // 
            tabpCuentas.BackColor = Color.White;
            tabpCuentas.Location = new Point(129, 4);
            tabpCuentas.Name = "tabpCuentas";
            tabpCuentas.Size = new Size(801, 603);
            tabpCuentas.TabIndex = 4;
            tabpCuentas.Text = "Cuentas";
            // 
            // tabpClientes
            // 
            tabpClientes.BackColor = Color.White;
            tabpClientes.Location = new Point(129, 4);
            tabpClientes.Name = "tabpClientes";
            tabpClientes.Size = new Size(801, 603);
            tabpClientes.TabIndex = 6;
            tabpClientes.Text = "Clientes";
            // 
            // tabpUsuarios
            // 
            tabpUsuarios.BackColor = Color.White;
            tabpUsuarios.Location = new Point(129, 4);
            tabpUsuarios.Name = "tabpUsuarios";
            tabpUsuarios.Size = new Size(801, 603);
            tabpUsuarios.TabIndex = 5;
            tabpUsuarios.Text = "Usuarios";
            // 
            // tabpReportes
            // 
            tabpReportes.BackColor = Color.White;
            tabpReportes.Location = new Point(129, 4);
            tabpReportes.Name = "tabpReportes";
            tabpReportes.Size = new Size(801, 603);
            tabpReportes.TabIndex = 7;
            tabpReportes.Text = "Reportes";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(controlMenuOpciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Menu Principal";
            controlMenuOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage controlMenuOpciones;
        private TabPage tabpHome;
        private TabPage tabpDepositos;
        private TabPage tabpRetiros;
        private TabPage tabpTranferencias;
        private TabPage tabpCuentas;
        private TabPage tabpClientes;
        private TabPage tabpUsuarios;
        private TabPage tabpReportes;
    }
}