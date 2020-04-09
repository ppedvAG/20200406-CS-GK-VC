using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTransportConsumer;

namespace Demo_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Beschleunige_PKW_über_MaxG()
        {
            PKW pkw = new PKW("BMW", 220, 20000, 5);

            pkw.StarteMotor();
            pkw.Beschleunigen(pkw.MaximalGeschwindigkeit + 1);
            Assert.AreEqual(pkw.MaximalGeschwindigkeit, pkw.AktuelleGeschwindigkeit);
        }
    }
}
