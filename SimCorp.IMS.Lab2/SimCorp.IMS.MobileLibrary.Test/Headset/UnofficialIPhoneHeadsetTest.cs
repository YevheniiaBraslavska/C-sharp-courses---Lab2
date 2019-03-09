using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary.Test {
    [TestClass]
    public class UnofficialIPhoneHeadsetTest {
        [TestMethod]
        public void PlayValidOutputText() {
            FakeOutput output = new FakeOutput();
            UnofficialIPhoneHeadset headset = new UnofficialIPhoneHeadset(output);
            object Data = new object();

            headset.Play(Data);

            Assert.AreEqual("UnofficialIPhoneHeadset sound\n", output.OutputResult);
        }
    }
}
