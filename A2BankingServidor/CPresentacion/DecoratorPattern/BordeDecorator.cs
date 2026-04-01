using System.Drawing;
using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public class BordeDecorator : DataGridDecorator
    {
        public BordeDecorator(IDataGridDecorator decorador) : base(decorador) { }

        public override void Aplicar(DataGridView viewData)
        {
            base.Aplicar(viewData);

            viewData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            viewData.GridColor = Color.FromArgb(0xD0, 0xD3, 0xE8);
        }
    }

}
