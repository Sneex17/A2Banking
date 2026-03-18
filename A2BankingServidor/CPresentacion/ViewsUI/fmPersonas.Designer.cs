namespace CPresentacion.ViewsUI
{
    partial class fmPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPersonas));
            panelInformacion = new Panel();
            labelTexto = new Label();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            panelConatiner = new Panel();
            comboOpciones = new ReaLTaiizor.Controls.AloneComboBox();
            label4 = new Label();
            textbFiltro = new ReaLTaiizor.Controls.DungeonTextBox();
            viewData = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Ocupacion = new DataGridViewTextBoxColumn();
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            panelConatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewData).BeginInit();
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
            panelInformacion.Size = new Size(784, 72);
            panelInformacion.TabIndex = 0;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Montserrat", 19F, FontStyle.Bold);
            labelTexto.ForeColor = Color.White;
            labelTexto.Location = new Point(107, 19);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(140, 36);
            labelTexto.TabIndex = 7;
            labelTexto.Text = "Personas";
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.Transparent;
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.Person;
            pbIcono.IconColor = Color.White;
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 50;
            pbIcono.Location = new Point(51, 11);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(50, 50);
            pbIcono.TabIndex = 6;
            pbIcono.TabStop = false;
            // 
            // panelConatiner
            // 
            panelConatiner.BackColor = Color.White;
            panelConatiner.Controls.Add(comboOpciones);
            panelConatiner.Controls.Add(label4);
            panelConatiner.Controls.Add(textbFiltro);
            panelConatiner.Controls.Add(viewData);
            panelConatiner.Dock = DockStyle.Fill;
            panelConatiner.Location = new Point(0, 72);
            panelConatiner.Name = "panelConatiner";
            panelConatiner.Size = new Size(784, 439);
            panelConatiner.TabIndex = 1;
            // 
            // comboOpciones
            // 
            comboOpciones.DrawMode = DrawMode.OwnerDrawFixed;
            comboOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOpciones.EnabledCalc = true;
            comboOpciones.FormattingEnabled = true;
            comboOpciones.ItemHeight = 20;
            comboOpciones.Location = new Point(566, 34);
            comboOpciones.Name = "comboOpciones";
            comboOpciones.Size = new Size(169, 26);
            comboOpciones.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(49, 31);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 14;
            label4.Text = "Buscar por";
            // 
            // textbFiltro
            // 
            textbFiltro.BackColor = Color.Transparent;
            textbFiltro.BorderColor = Color.FromArgb(180, 180, 180);
            textbFiltro.EdgeColor = Color.White;
            textbFiltro.Font = new Font("Tahoma", 12F);
            textbFiltro.ForeColor = Color.Black;
            textbFiltro.Location = new Point(161, 31);
            textbFiltro.MaxLength = 32767;
            textbFiltro.Multiline = false;
            textbFiltro.Name = "textbFiltro";
            textbFiltro.ReadOnly = false;
            textbFiltro.Size = new Size(385, 30);
            textbFiltro.TabIndex = 13;
            textbFiltro.TextAlignment = HorizontalAlignment.Left;
            textbFiltro.UseSystemPasswordChar = false;
            // 
            // viewData
            // 
            viewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewData.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Edad, Sexo, Ocupacion });
            viewData.Location = new Point(49, 75);
            viewData.Name = "viewData";
            viewData.Size = new Size(686, 326);
            viewData.TabIndex = 0;
            viewData.CellDoubleClick += viewData_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Ocupacion
            // 
            Ocupacion.HeaderText = "Ocupacion";
            Ocupacion.Name = "Ocupacion";
            // 
            // fmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(panelConatiner);
            Controls.Add(panelInformacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 Banking - Personas";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            panelConatiner.ResumeLayout(false);
            panelConatiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformacion;
        private Panel panelConatiner;
        private DataGridView viewData;
        private ReaLTaiizor.Controls.AloneComboBox comboOpciones;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox textbFiltro;
        public Label labelTexto;
        public FontAwesome.Sharp.IconPictureBox pbIcono;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Ocupacion;
    }
}