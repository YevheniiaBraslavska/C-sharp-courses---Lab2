using System;

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
            Console.WriteLine("3 - UnofficialIPhoneHeadset");
            Console.WriteLine("4 - PhoneSpeaker");

            string key = Console.ReadLine();
            switch (key.ToCharArray()[0]) {
                case '1':
                    return new IPhoneHeadset(output);
                case '2':
                    return new SamsungHeadset(output);
                case '3':
                    return new UnofficialIPhoneHeadset(output);
                case '4':
                    return new PhoneSpeaker(output);
                default:
                    return null;
            }
        }

        public static ICharger ChooseCharger(IOutput output) {
            Console.WriteLine("Select charger component (specify index):");
            Console.WriteLine("1 - ExternalCharger");
            Console.WriteLine("2 - USBCharger");

            string key = Console.ReadLine();
            switch (key.ToCharArray()[0]) {
                case '1':
                    return new ExternalCharger(output);
                case '2':
                    return new USBCharger(output);
                default:
                    return null;
            }
        }
    }
}
