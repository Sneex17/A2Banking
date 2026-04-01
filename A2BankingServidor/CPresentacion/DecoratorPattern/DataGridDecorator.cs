using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public abstract class DataGridDecorator : IDataGridDecorator
    {
        protected readonly IDataGridDecorator _decorador;

        protected DataGridDecorator(IDataGridDecorator decorador)
        {
            _decorador = decorador;
        }

        public virtual void Aplicar(DataGridView dgv)
        {
            _decorador.Aplicar(dgv);
        }
    }

}
