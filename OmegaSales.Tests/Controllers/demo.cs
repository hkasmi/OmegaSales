using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSales;
using OmegaSales.Controllers;

namespace OmegaSales.Tests.Controllers
{
    public class Calculator : ICalculator<double>
    {
        private IOperation<double> Operation;

        public Calculator(IOperation<double> Operation)
        {
            this.Operation = Operation;
        }

        public double Execute(double a, double b)
        {
            return Operation.Execute(a,b);
        }
    }

    public class PlusReel : IOperation<double>
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
    public class CalculeSurfaceCarre : IOperation<double>
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
    }

    public interface IOperation<T>
    {
        T Execute(T a, T b);
    }

    public interface ICalculator<T> //: Operation
    {
        T Execute(T a, T b);
    }

    [TestClass]
    public class DemoInjection
    {
        [TestMethod]
        public void UtilizationClasse()
        {
            var calc = new Calculator(new CalculeSurfaceCarre());

            var Result = calc.Execute(2, 3);


            Assert.AreEqual(5, Result);

        }
    }
}
