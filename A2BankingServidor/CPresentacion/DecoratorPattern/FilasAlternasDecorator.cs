using System.Drawing;
using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public class FilasAlternasDecorator : DataGridDecorator
    {
        public FilasAlternasDecorator(IDataGridDecorator decorador) : base(decorador) { }

        public override void Aplicar(DataGridView viewData)
        {
            base.Aplicar(viewData);

            viewData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0xE8, 0xEA, 0xF6);
        }
    }

}
