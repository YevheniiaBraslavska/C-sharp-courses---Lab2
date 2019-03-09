using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab2 {
    public class SamsungHeadset : IPlayback {
        private IOutput Output { get; }

        public SamsungHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
