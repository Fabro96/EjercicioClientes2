using System;
using EjercicioClientes2.Entidades;
using EjercicioClientes2.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;

        public ClienteServicio()
        {
            this._clienteMapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = _clienteMapper.GetClientes();
            return clientes;
        }

        public int AgregarCliente(Cliente cliente)
        {
            ResultadoTransaccion resultado = _clienteMapper.Insert(cliente);

            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("Hubo un error en la petición al servicior. Detalle: " + resultado.Error);

        }
    }
}
