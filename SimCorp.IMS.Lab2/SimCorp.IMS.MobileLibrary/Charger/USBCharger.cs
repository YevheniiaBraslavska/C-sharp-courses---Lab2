using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab2 {
    public class USBCharger : ICharger {
        private IOutput Output { get; }

        public USBCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.WriteLine($"Charge with {nameof(USBCharger)}");
        }
    }
}
