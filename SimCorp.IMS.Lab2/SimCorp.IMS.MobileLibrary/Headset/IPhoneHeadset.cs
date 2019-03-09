using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab2 {
    public class IPhoneHeadset : IPlayback {
        private IOutput Output { get; }

        public IPhoneHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(IPhoneHeadset)} sound");
        }
    }
}
