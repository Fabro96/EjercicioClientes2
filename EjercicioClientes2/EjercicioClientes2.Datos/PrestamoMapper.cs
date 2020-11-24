using EjercicioClientes2.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Datos
{
    public class PrestamoMapper
    {
        public List<Prestamo> GetPrestamos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamo/893746");
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }

        public ResultadoTransaccion Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReserveMap(prestamo);

            string resultado = WebHelper.Post("/api/v1/prestamo/", obj);

            ResultadoTransaccion resultadoTransaccion = MapResultado(resultado);

            return resultadoTransaccion;
        }

        private NameValueCollection ReserveMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("id", prestamo.Id.ToString());
            n.Add("tna", prestamo.TNA.ToString());
            n.Add("linea", prestamo.Linea.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            //n.Add("idCliente")
            //n.Add("idTipo")
            n.Add("monto", prestamo.Monto.ToString());
            //n.Add("cuota", prestamo.CuotaTotal.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

            return n;
        }

        private ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }

    }
}
