using System;
using System.ComponentModel.Design;
using SimCorp.IMS.MobileLibrary;

namespace SimCorp.IMS.Lab2 {
    class Program {
        static void Main(string[] args) {
            SimCorpMobile mobile = new SimCorpMobile();
            IOutput output = new ConsoleOutput();

            //Get playback
            IPlayback playback = ChoosePlayback(output);
            if (playback != null) {
                output.WriteLine($"{playback.GetType().Name} playback selected");
                output.WriteLine("Set playback to mobile...");
                mobile.PlaybackComponent = playback;
                output.WriteLine("Play sound in mobile:");
                object data = new object();
                mobile.Play(data);
            }

            Console.WriteLine("\n");

            //Get charger
            ICharger charger = ChooseCharger(output);
            if (charger != null) {
                output.WriteLine($"{charger.GetType().Name} charger selected");
                output.WriteLine("Set charger to mobile...");
                mobile.ChargingComponent = charger;
                output.WriteLine("Charging mobile:");
                mobile.Charge();
            }

            Console.ReadKey();
        }

        public static IPlayback ChoosePlayback(IOutput output) {
            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine("1 - IPhoneHeadset");
            Console.WriteLine("2 - SamsungHeadset");
            Console.WriteLine("3 - PhoneSpeaker");

            var key = Console.ReadLine();
            var headsettype = (key != "") ? key[0] : '0';
            switch (headsettype) {
                case '1':
                return new IPhoneHeadset(output, "2569:1256");
                case '2':
                var plug = new AudioPlug(102, 100, 3.5f);
                return new SamsungHeadset(output, plug);
                default:
                output.WriteLine("Headset type was not recognised. Using default headset");
                return new PhoneSpeaker(output,24.0f);
            }
        }

        public static ICharger ChooseCharger(IOutput output) {
            Console.WriteLine("Select charger component (specify index):");
            Console.WriteLine("1 - ExternalCharger");
            Console.WriteLine("2 - USBCharger");

            var key = Console.ReadLine();
            var chargertype = (key != "") ? key[0] : '0';
            switch (chargertype) {
                case '2':
                return new USBCharger(output);
                default:
                output.WriteLine("Charger type was not recognised. Using default charger");
                return new ExternalCharger(output);
            }
        }
    }
}
