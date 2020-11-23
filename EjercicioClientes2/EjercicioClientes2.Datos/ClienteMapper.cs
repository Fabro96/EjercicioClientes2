using System;
using EjercicioClientes2.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Configuration;

namespace EjercicioClientes2.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> GetClientes()
        {
            string json2 = WebHelper.Get("/api/v1/cliente/893746");
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        public List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        public ResultadoTransaccion Insert(Cliente cliente)
        {
            NameValueCollection obj = ReserveMap(cliente);

            string resultado = WebHelper.Post("/api/v1/cliente", obj);

            ResultadoTransaccion resultadoTransaccion = MapResultado(resultado);

            return resultadoTransaccion;
        }

        public NameValueCollection ReserveMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Apellido);
            n.Add("dni", cliente.DNI.ToString());
            n.Add("direccion", cliente.Direccion);
            n.Add("email", cliente.Email);
            n.Add("telefono", cliente.Telefono.ToString());
            n.Add("fechaNacimiento", cliente.Nacimiento.ToString());
            n.Add("activo", cliente.Activo.ToString());
            n.Add("usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("id", cliente.ID.ToString());

            return n;
        }
        public ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }
    }
}
