using CEntidades.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.StrategyPattern
{
    public interface IOperacionStrategy
    {
        void Operacion(Cuenta cuenta, int ClienteId, string Nombre);
    }

}
