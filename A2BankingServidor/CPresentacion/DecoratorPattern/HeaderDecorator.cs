using System.Drawing;
using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public class HeaderDecorator : DataGridDecorator
    {
        public HeaderDecorator(IDataGridDecorator decorador) : base(decorador) { }

        public override void Aplicar(DataGridView viewData)
        {
            base.Aplicar(viewData);

            viewData.EnableHeadersVisualStyles = false;
            viewData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0x23, 0x6E, 0x7D);
            viewData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            viewData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            viewData.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            viewData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewData.ColumnHeadersHeight = 42;
            viewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }
    }

}
