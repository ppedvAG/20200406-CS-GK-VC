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
            PKW pKW = new PKW("BMW", 220, 20000, 5);

            pKW.StarteMotor();
            pKW.Beschleunigen(pKW.MaximalGeschwindigkeit + 1);
            Assert.AreEqual(pKW.MaximalGeschwindigkeit, pKW.AktuelleGeschwindigkeit);

        }
    }
}
