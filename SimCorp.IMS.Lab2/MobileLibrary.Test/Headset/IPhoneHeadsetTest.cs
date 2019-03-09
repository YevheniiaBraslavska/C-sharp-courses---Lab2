using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab2;

namespace MobileLibrary.Test {
    [TestClass]
    public class IPhoneHeadsetTest {
        [TestMethod]
        public void PlayValidOutputText() {
            FakeOutput output = new FakeOutput();
            IPhoneHeadset headset = new IPhoneHeadset(output);
            object Data = new object();

            headset.Play(Data);

            Assert.AreEqual("IPhoneHeadset sound\n",output.OutputResult);
        }
    }
}
