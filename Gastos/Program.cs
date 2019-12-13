using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Gastos {
    public class Program {
        private static List<Gasto> gastos = new List<Gasto>();
        public static void Main(string[] argumentos) {
            Stopwatch contador = new Stopwatch();
            contador.Start();
            if (argumentos.Length > 0) {
                if (Directory.Exists(argumentos[0])) {
                    string[] files = Directory.GetFiles(argumentos[0]);
                    Console.WriteLine($"Cantidad de archivos: {files.Length}");
                    if (files.Length > 0) {
                        for (int i = 0; i < files.Length; i++) {
                            FileInfo file = new FileInfo(files[i]);
                            if (file.Extension.ToLower() == ".txt") {
                                Console.WriteLine($"Archivo: {file.Name} -----");
                                Console.WriteLine($"{File.ReadAllText(file.FullName)}");
                            }
                        }
                    }
                }
            }
            contador.Stop();
            Console.WriteLine($"Tiempo transcurrido: {contador.ElapsedMilliseconds}");
            //Console.WriteLine("## Sistema de gastos ##");
            //int cantidadGastos;
            //Console.Write("Ingrese la cantidad de gastos que desea digitar: ");
            //int.TryParse(Console.ReadLine(), out cantidadGastos);
            //for (int i = 1; i <= cantidadGastos; i++) {
            //    Console.Write("Digite la fuente del ingreso: ");
            //    Ingreso ingreso1 = new Ingreso();
            //    ingreso1.Fuente = Console.ReadLine();
            //    Console.Write("Digite el monto del ingreso: ");
            //    decimal monto;
            //    decimal.TryParse(Console.ReadLine(), out monto);
            //    ingreso1.Monto = monto;
            //    Console.Write("Digite la fecha del ingreso: ");
            //    DateTime fecha;
            //    DateTime.TryParse(Console.ReadLine(), out fecha);
            //    ingreso1.Fecha = fecha;

            //    Console.Write("Digite el lugar del gasto: ");
            //    Gasto gasto1 = new Gasto();
            //    gasto1.Lugar = Console.ReadLine();
            //    Console.Write("Digite el monto del gasto: ");
            //    decimal.TryParse(Console.ReadLine(), out monto);
            //    gasto1.Monto = monto;
            //    Console.Write("Digite la fecha del gasto: ");
            //    DateTime.TryParse(Console.ReadLine(), out fecha);
            //    gasto1.Fecha = fecha;
            //    gasto1.Ingreso = ingreso1;

            //    gastos.Add(gasto1);

            //    Log log = new Log();
            //    ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(log.LogGasto);
            //    Thread thread1 = new Thread(parameterizedThreadStart);
            //    thread1.Start(gasto1);
            //}
            //SaveGastos(gastos);
        }

        public static void SaveGastos(List<Gasto> gastos) {
            if (!File.Exists("Gastos.csv")) {
                FileStream fileStream = File.Create("Gastos.csv");
                fileStream.Close();
            }
            File.AppendAllText("Gastos.csv", "Gasto.Lugar,Gasto.Monto,Gasto.Fecha,Ingreso.Fuente,Ingreso.Monto,Ingreso.Fecha\n");
            foreach (Gasto gastoItem in gastos) {
                File.AppendAllText("Gastos.csv", $"{gastoItem.Lugar},{gastoItem.Monto},{gastoItem.Fecha},{gastoItem.Ingreso.Fuente},{gastoItem.Ingreso.Monto},{gastoItem.Ingreso.Fecha}");
            }
        }
    }
}
