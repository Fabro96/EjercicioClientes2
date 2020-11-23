using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Entidades
{
    [DataContract]
    public class Cuenta
    {
        //ATRIBUTOS
        private long _nroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        //CONSTRUCTORES
        public Cuenta()
        {

        }
        public Cuenta(long nroCuenta, string descripcion, double saldo, DateTime fechaApertura, DateTime fechaModificacion,
                      bool activo, int idCliente, int id)
        {
            this._nroCuenta = nroCuenta;
            this._descripcion = descripcion;
            this._saldo = saldo;
            this._fechaApertura = fechaApertura;
            this._fechaModificacion = fechaModificacion;
            this._activo = activo;
            this._idCliente = idCliente;
            this._id = id;

        }

        //PROPIEDADES
        [DataMember]
        public long NroCuenta
        {
            set { _nroCuenta = value; }
            get { return _nroCuenta;  }
        }
        [DataMember]
        public string Descripcion
        {
            set { _descripcion = value; }
            get { return _descripcion;  }
        }
        [DataMember]
        public double Saldo
        {
            set { _saldo = value; }
            get { return _saldo;  }
        }
        [DataMember]
        public DateTime FechaApertura
        {
            set { _fechaApertura = value; }
            get { return _fechaApertura;  }
        }
        [DataMember]
        public DateTime FechaModificatoria
        {
            set { _fechaModificacion = value; }
            get { return _fechaModificacion;  }
        }
        [DataMember]
        public bool Activo
        {
            set { _activo = value; }
            get { return _activo;  }
        }
        public int IdCliente
        {
            set { _idCliente = value; }
            get { return _idCliente;  }
        }
        public int Id
        {
            set { _id = value; }
            get { return _id;  }
        }

        //MÉTODOS
        public override string ToString()
        {
            return string.Format("{0} - ID Cliente: {1} - {2} - {3}", this.NroCuenta, this.IdCliente,
                                 this.Descripcion, this.Saldo);
        }
    }
}
