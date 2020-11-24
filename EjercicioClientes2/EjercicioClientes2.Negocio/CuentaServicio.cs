using EjercicioClientes2.Datos;
using EjercicioClientes2.Entidades;
using EjercicioClientes2.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Negocio
{
    public class CuentaServicio
    {
        private CuentaMapper _cuentaMapper;

        public CuentaServicio()
        {
            this._cuentaMapper = new CuentaMapper();
        }

        public Cuenta TraerCuentas(int idCliente)
        {

            Cuenta resultado = _cuentaMapper.GetCuenta(idCliente);

            if (resultado == null)
            {
                throw new ElClienteNoTieneCuentasException();
            }
            else
            {
                return resultado;
            }
            
        }

        public Cuenta AbrirCuenta(Cuenta cuenta)
        {
            
            ResultadoTransaccion resultado = _cuentaMapper.Insert(cuenta);

            if (resultado.IsOk)
                return TraerCuentas(cuenta.IdCliente);
            else
                throw new Exception("Hubo un error en la petición al servicior. Detalle: " + resultado.Error);

        }
    }
}
