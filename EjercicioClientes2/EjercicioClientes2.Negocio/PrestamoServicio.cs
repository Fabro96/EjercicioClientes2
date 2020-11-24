using EjercicioClientes2.Datos;
using EjercicioClientes2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Negocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper _prestamoMapper;

        public PrestamoServicio()
        {
            this._prestamoMapper = new PrestamoMapper();
        }

        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> prestamos = this._prestamoMapper.GetPrestamos();
            return prestamos;
        }

        public int AgregarPrestamo(Prestamo prestamo)
        {
            ResultadoTransaccion resultante = _prestamoMapper.Insert(prestamo);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
        }
    }
}
