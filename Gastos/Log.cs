using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gastos {
    public class Log {
        public void LogGasto(object gasto) {
            if (!File.Exists("Logs.csv")) {
                FileStream fileStream = File.Create("Logs.csv");
                fileStream.Close();
            }
            if (gasto is Gasto) {
                Gasto g = (Gasto)gasto;
                File.AppendAllText("Logs.csv", "Fecha registro,Tipo transaccion,Informacion Gasto\n");
                File.AppendAllText("Logs.csv", $"{DateTime.Now},Agregado,Monto:{g.Monto};Fecha:{g.Fecha}\n");
            }
        }
    }
}
