using System.Drawing;
using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public class SeleccionDecorator : DataGridDecorator
    {
        public SeleccionDecorator(IDataGridDecorator decorador) : base(decorador) { }

        public override void Aplicar(DataGridView viewData)
        {
            base.Aplicar(viewData);

            viewData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0x37, 0x96, 0xA5);
            viewData.DefaultCellStyle.SelectionForeColor = Color.White;
            viewData.DefaultCellStyle.ForeColor = Color.FromArgb(0x2C, 0x2C, 0x54);
            viewData.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
        }
    }

}
