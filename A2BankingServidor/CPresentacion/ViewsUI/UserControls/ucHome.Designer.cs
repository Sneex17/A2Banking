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
            panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // labelTexto
            // 
            labelTexto.Size = new Size(96, 36);
            labelTexto.Text = "Home";
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucHome";
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
