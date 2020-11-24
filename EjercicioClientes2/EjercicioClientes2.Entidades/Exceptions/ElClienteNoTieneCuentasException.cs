using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Entidades.Exceptions
{
    public class ElClienteNoTieneCuentasException : Exception
    {
        public ElClienteNoTieneCuentasException() : base("El Cliente seleccionado no tiene Cuentas.")
        {

        }
    }
}
