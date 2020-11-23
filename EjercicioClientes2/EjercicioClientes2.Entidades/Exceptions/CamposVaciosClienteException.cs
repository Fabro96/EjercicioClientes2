using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Entidades.Exceptions
{
    public class CamposVaciosClienteException : Exception
    {
        public CamposVaciosClienteException() : base("No es posible agregar un Cliente con Campos Vacios.")
        {

        }
    }
}
