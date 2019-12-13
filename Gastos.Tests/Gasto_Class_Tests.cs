using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gastos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gastos.Tests {
    [TestClass]
    public class Gasto_Class_Tests {
        [TestMethod]
        public void Test_Add_Ingreso_To_Gasto_Where_Ingreso_Greater_Than_Gasto() {
            Ingreso ingreso1 = new Ingreso() {
                Fecha = DateTime.Parse("12/10/2019"),
                Fuente = "INTEC",
                Monto = 35000
            };
            Gasto gasto1 = new Gasto() {
                Fecha = DateTime.Parse("10/13/2019"),
                Lugar = "Yokomo",
                Monto = 1500,
                Ingreso = ingreso1
            };
            Assert.IsNotNull(gasto1.Ingreso);
        }
        [TestMethod]
        public void Test_Add_Ingreso_To_Gasto_Where_Ingreso_Lesser_Than_Gasto() {
            Ingreso ingreso1 = new Ingreso() {
                Fecha = DateTime.Parse("12/10/2019"),
                Fuente = "INTEC",
                Monto = 1000
            };
            Gasto gasto1 = new Gasto() {
                Fecha = DateTime.Parse("10/13/2019"),
                Lugar = "Yokomo",
                Monto = 1500,
                Ingreso = ingreso1
            };
            Assert.IsNull(gasto1.Ingreso);
        }
        [TestMethod]
        public void Test_Add_Ingreso_To_Gasto_Where_Gasto_Already_Has_Ingreso() {
            Ingreso ingreso1 = new Ingreso() {
                Fecha = DateTime.Parse("12/10/2019"),
                Fuente = "INTEC",
                Monto = 2500
            };
            Gasto gasto1 = new Gasto() {
                Fecha = DateTime.Parse("10/13/2019"),
                Lugar = "Yokomo",
                Monto = 1500,
                Ingreso = ingreso1
            };
            Ingreso ingreso2 = new Ingreso() {
                Fecha = DateTime.Parse("10/13/2019"),
                Fuente = "McDonalds",
                Monto = 3500
            };
            gasto1.Ingreso = ingreso2;
            Assert.AreEqual(ingreso1.Monto, gasto1.Ingreso?.Monto);
        }
    }
}
