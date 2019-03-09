using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab2;

namespace MobileLibrary.Test {
    [TestClass]
    public class ExternalChargerTest {
        [TestMethod]
        public void ChargeValidOutputText() {
            FakeOutput output = new FakeOutput();
            ExternalCharger charger = new ExternalCharger(output);

            charger.Charge();

            Assert.AreEqual("Charge with ExternalCharger\n", output.OutputResult);
        }
    }
}
