using System;
using System.Collections.Generic;
using System.Text;

namespace Gastos {
    public class Gasto {
        private string lugar;
        private decimal monto;
        private DateTime fecha;
        private Ingreso ingreso = null;

        public string Lugar {
            get {
                return lugar;
            }
            set {
                lugar = value;
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
        public Ingreso Ingreso {
            get {
                return ingreso;
            }
            set {
                if (ingreso == null && value.Monto >= Monto) {
                    ingreso = value;
                }
            }
        }
    }
}
