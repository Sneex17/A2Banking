using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public class DataGridBase : IDataGridDecorator
    {
        public void Aplicar(DataGridView viewData)
        {
            viewData.ReadOnly = true;
            viewData.BackgroundColor = Color.FromArgb(0xF4, 0xF6, 0xFB);
            viewData.BorderStyle = BorderStyle.None;
            viewData.RowHeadersVisible = false;
            viewData.AllowUserToAddRows = false;
            viewData.AllowUserToResizeRows = false;
            viewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewData.Font = new Font("Segoe UI", 9.5f);
            viewData.RowTemplate.Height = 38;
            viewData.ScrollBars = ScrollBars.Vertical;
        }
    }
}
