using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab2;

namespace MobileLibrary.Test {
    [TestClass]
    public class USBChargerTest {
        [TestMethod]
        public void ChargeValidOutputText() {
            FakeOutput output = new FakeOutput();
            USBCharger charger = new USBCharger(output);

            charger.Charge();

            Assert.AreEqual("Charge with USBCharger\n", output.OutputResult);
        }
    }
}
