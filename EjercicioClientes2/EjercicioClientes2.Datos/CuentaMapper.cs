using EjercicioClientes2.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Datos
{
    public class CuentaMapper
    {
        public Cuenta GetCuenta(int idCliente)
        {
            string json2 = WebHelper.Get("/api/v1/cuenta/" + idCliente.ToString());
            Cuenta resultado = Map(json2);
            return resultado;
        }

        public Cuenta Map(string json2)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json2);
            return lst;
        }

        public ResultadoTransaccion Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReserveMap(cuenta);

            string resultado = WebHelper.Post("/api/v1/cuenta", obj);

            ResultadoTransaccion resultadoTransaccion = MapResultado(resultado);

            return resultadoTransaccion;
        }

        public NameValueCollection ReserveMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("nroCuenta", cuenta.NroCuenta.ToString());
            n.Add("descripcion", cuenta.Descripcion);
            n.Add("saldo", cuenta.Saldo.ToString());
            n.Add("fechaApertura", cuenta.FechaApertura.ToString());
            n.Add("fechaModificacion", cuenta.FechaModificatoria.ToString());
            n.Add("activo", cuenta.Activo.ToString());
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("id", cuenta.Id.ToString());

            return n;

        }

        public ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;

        }
    }
}
