using System;
using System.Collections.Generic;
using System.Text;

namespace Gastos {
    public class Ingreso {
        private string fuente;
        private decimal monto;
        private DateTime fecha;

        public string Fuente {
            get {
                return fuente;
            }
            set {
                fuente = value;
            }
        }
        public decimal Monto {
            get {
                return monto;
            }
            set {
                monto = value;
            }
        }
        public DateTime Fecha {
            get {
                return fecha;
            }
            set {
                fecha = value;
            }
        }
    }
}
