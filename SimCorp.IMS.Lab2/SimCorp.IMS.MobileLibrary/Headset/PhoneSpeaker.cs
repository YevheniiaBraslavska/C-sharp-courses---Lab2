using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab2 {
    public class PhoneSpeaker : IPlayback {
        private IOutput Output { get; }

        public PhoneSpeaker(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
