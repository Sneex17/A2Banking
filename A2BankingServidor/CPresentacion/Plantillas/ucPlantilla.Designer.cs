namespace CPresentacion.Plantillas
{
    partial class ucPlantilla
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
            panelContainer = new Panel();
            label6 = new Label();
            viewDatos = new DataGridView();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewDatos).BeginInit();
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
            panelInformacion.TabIndex = 0;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(108, 24);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(72, 36);
            labelTexto.TabIndex = 5;
            labelTexto.Text = "Text";
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
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(label6);
            panelContainer.Controls.Add(viewDatos);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 72);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(801, 531);
            panelContainer.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(52, 267);
            label6.Name = "label6";
            label6.Size = new Size(50, 22);
            label6.TabIndex = 16;
            label6.Text = "Lista";
            // 
            // viewDatos
            // 
            viewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewDatos.Location = new Point(52, 307);
            viewDatos.Name = "viewDatos";
            viewDatos.Size = new Size(702, 200);
            viewDatos.TabIndex = 15;
            // 
            // ucPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Controls.Add(panelInformacion);
            MinimumSize = new Size(801, 603);
            Name = "ucPlantilla";
            Size = new Size(801, 603);
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelInformacion;
        public Panel panelContainer;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        public Label labelTexto;
        public DataGridView viewDatos;
        public Label label6;
    }
}
