using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary.Test {
    [TestClass]
    public class PhoneSpeakerTest {
        [TestMethod]
        public void PlayValidOutputText() {
            FakeOutput output = new FakeOutput();
            PhoneSpeaker headset = new PhoneSpeaker(output);
            object Data = new object();

            headset.Play(Data);

            Assert.AreEqual("PhoneSpeaker sound\n", output.OutputResult);
        }
    }
}
