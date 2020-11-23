using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes2.Entidades
{
    [DataContract]
    public class Cliente
    {
        //ATRIBUTOS
        private string _nombre;
        private string _apellido;
        private long _dni;
        private string _direccion;
        private string _email;
        private long _telefono;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private int _id;

        //CONSTRUCTORES
        public Cliente()
        {

        }
        public Cliente (string nombre, string apellido, long dni, string direccion, string email,
                        long telefono, DateTime nacimiento, bool activo, int id)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._direccion = direccion;
            this._email = email;
            this._telefono = telefono;
            this._fechaNacimiento = nacimiento;
            this._activo = activo;
            this._id = id;

        }
        //PROPIEDADES
        [DataMember]
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }

        [DataMember]
        public string Apellido
        {
            set { _apellido = value; }
            get { return _apellido; }
        }

        [DataMember]
        public long DNI
        {
            set { _dni = value; }
            get { return _dni;  }
        }

        [DataMember]
        public string Direccion
        {
            set { _direccion = value; }
            get { return _direccion;  }
        }

        [DataMember]
        public string Email
        {
            set { _email = value; }
            get { return _email;  }
        }

        [DataMember]
        public long Telefono
        {
            set { _telefono = value; }
            get { return _telefono;  }
        }

        [DataMember]
        public DateTime Nacimiento
        {
            set { _fechaNacimiento = value; }
            get { return _fechaNacimiento;  }
        }
        
        [DataMember]
        public int ID
        {
            set { _id = value; }
            get { return _id;  }
        }

        [DataMember]
        public bool Activo
        {
            set { _activo = value; }
            get { return _activo;  }
        }

        //MÉTODOS
        public override string ToString()
        {
            return string.Format("{0} - {1}, {2}, DNI: {3}", this.ID, this.Apellido, this.Nombre, this.DNI);
        }
    }
}
