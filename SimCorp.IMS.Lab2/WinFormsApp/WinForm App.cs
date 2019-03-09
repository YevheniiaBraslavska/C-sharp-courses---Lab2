using System;
using System.Windows.Forms;
using SimCorp.IMS.Lab2;

namespace WinFormsApp {
    public partial class WinFormApp : Form, IWinAppLog {
        public WinFormApp() {
            InitializeComponent();
            Mobile = new SimCorpMobile();
            Output = new WinLogOutput(this);
        }

        public string LogText {
            get {
                return TextBox.Text;
            }
            set {
                TextBox.Text = value;
            }
        }

        private SimCorpMobile Mobile {
            get;
        }

        private IOutput Output {
            get;
        }

        private void SetPlayback(IPlayback playback) {
            Output.WriteLine($"{playback.GetType().Name} playback selected");
            Output.WriteLine("Set playback to mobile...");
            Mobile.PlaybackComponent = playback;
            Output.WriteLine("Play sound in mobile:");
            object Data = new object();
            Mobile.Play(Data);
            Output.WriteLine("");
        }

        private void SetCharger(ICharger charger) {
            Output.WriteLine($"{charger.GetType().Name} charger selected");
            Output.WriteLine("Set charger to mobile...");
            Mobile.ChargingComponent = charger;
            Output.WriteLine("Charging mobile:");
            Mobile.Charge();
            Output.WriteLine("");
        }

        private void ApplyButton_Click(object sender, EventArgs e) {
            //Playback
            if (IPhoneHeadsetButton.Checked == true) {
                SetPlayback(new IPhoneHeadset(Output));
            }
            else if (SamsungHeadsetButton.Checked == true) {
                SetPlayback(new SamsungHeadset(Output));
            }
            else if (UnofficialIPhoneHeadsetButton.Checked == true) {
                SetPlayback(new UnofficialIPhoneHeadset(Output));
            }
            else if (PhoneSpeakerButton.Checked == true) {
                SetPlayback(new PhoneSpeaker(Output));
            }

            //Charger
            if (ExternalChargerButton.Checked == true) {
                SetCharger(new ExternalCharger(Output));
            }
            else if (USBChargerButton.Checked == true) {
                SetCharger(new USBCharger(Output));
            }
        }
    }
}
