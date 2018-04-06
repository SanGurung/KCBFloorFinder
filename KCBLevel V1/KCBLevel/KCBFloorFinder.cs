using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using NativeWifi;

namespace KCBLevel
{
    public partial class KCBFloorForm : Form
    {
        //routerInfo[] routerFloorInfo=new routerInfo[8];
        static routerInfo[] rF = new routerInfo[8];
        public int currentFloor = 0;
        SpeechSynthesizer assistatantAgentSpeaker = new SpeechSynthesizer();
        // Create a new SpeechRecognitionEngine instance.
        SpeechRecognitionEngine srec = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-GB"));

        public KCBFloorForm()
        {
            InitializeComponent();
            autoDetectCheck.Checked = true;
            /*  
             //Test Results
             4th Floor  0022B048DB98   99% Detection if we use both MAC    0022B04986C8(F1,S),0022B0498830 (F,S2),0022B048DB98 (F3,S),0022B048DB90(F,S3)
             *                         L4(0022B048DB98,0022B04986C8)
             3rd Floor  0022B04984B0   99% Detection if we use both MAC    0022B04984B0(F2,S2),0022B0498358(F1,S2)
             *                         L3(0022B04984B0,0022B0498358)
             2nd Floor  0022B048DBB0   99% Detection Very Good             0022B048DBB8(F,S3),0022B048DBB0(F3,S0)
             1st Floor  0022B04990B8   50%  Detection                          0022B0498B58(F1,S), 0022B0498D98(F,S1),0022B04990B8(F2,S),
                                       //Can give good result if used with     0022B04986C8(F,S1), 0022B0498838(F1,S),0022B0498808(F,S1),
                                       L1(0022B04990B8,0022B0498838)             0022B0498458(F,S1)
             * 
             Ground     0022B0498B58   50% Deection                        0022B0498B58(F2,S2),0022B0498B50(F1,S3)
             *                         LG(0022B0498B58,0022B0498B50)
             Basement   0022B0498C38   99% Accuracy if we use both MAC     0022B0498C38(F5,S),0022B0498C30(F2,S2),
             *                         LB(0022B0498C38,0022B0498C30)         0022B0498B58(F,S2),0022B0498808(F,S1)
             
             * 
             * L4(0022B048DB98,0022B04986C8)
               L3(0022B04984B0,0022B0498358)
               L2(0022B048DBB0)
               L1(0022B04990B8,0022B0498838)
               LG(0022B0498B58,0022B0498B50)
               LB(0022B0498C38,0022B0498C30)
             */

            //first attempt to detect floor using 1WIFI MAC Address
            //Floor 1 to 5
            rF[5] = new routerInfo("Neglected", -9000);
            rF[4] = new routerInfo("0022B048DB98", -9000);
            rF[3] = new routerInfo("0022B04984B0", -9000);
            rF[2] = new routerInfo("0022B048DBB0", -9000);
            rF[1] = new routerInfo("0022B04990B8", -9000);
            
            //Ground Floor
            rF[7] = new routerInfo("0022B0498B58 ", -9000);
            //Basement
            rF[6] = new routerInfo("0022B0498C38", -9000);
            setDefaultDBM();

            /*
            0022B048DB98,0022B04986C8,0022B0498358
            0022B04984B0,0022B048DBB0,0022B04990B8
            0022B0498838,0022B0498B58,0022B0498B50
            0022B0498C38,0022B0498C30 */

        }

        private void KCBFloorForm_Load(object sender, EventArgs e)
        {
            assistatantAgentSpeaker = new SpeechSynthesizer();
            hideTicks();
            speakFloorName(1);
            speechInput();
        }

        private void speechInput()
        {
            assistatantAgentSpeaker.Volume = 100;
            srec.SetInputToDefaultAudioDevice();
            Choices speechCommand = new Choices();
            speechCommand.Add(new string[] { "Help me", "Cindy" });

            GrammarBuilder gbr = new GrammarBuilder();
            gbr.Append(speechCommand);
            Grammar g = new Grammar(gbr);
            srec.LoadGrammar(g);
            // An Event handler for AudioLevelUpdated event.
            srec.AudioLevelUpdated += new EventHandler<System.Speech.Recognition.AudioLevelUpdatedEventArgs>(check_audioLevel);
            srec.SpeechRecognized += new EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs>(auto_SpeechRecognized);

            // Start recognition.
            srec.RecognizeAsync(System.Speech.Recognition.RecognizeMode.Multiple);
        }

        private void check_audioLevel(object sender, System.Speech.Recognition.AudioLevelUpdatedEventArgs e)
        {
            // This event handler occurs when the audio level is updated or every interval.
            // e.AudioLevel value ranges from 0 to 100
            audioLevelBar.Value = e.AudioLevel;
        }

        private void auto_SpeechRecognized(object sender, System.Speech.Recognition.SpeechRecognizedEventArgs e)
        {
            string recogText = "";
            // Capitalize the first letter
            recogText = (e.Result.Text.Substring(0, 1).ToUpper() + (e.Result.Text.Substring(1)));
            this.Text = "KCB Level Detection. Recognised text:"+ recogText;
            //if the user speaks "Help me" or "Help me ..something" then the program will read the floor names.
            if (recogText.Substring(0, 7).Equals("Help me") || recogText.Substring(0, 5).Equals("Cindy")) { speakFloorName(2); }
        }

        private void floor_detect_Click(object sender, EventArgs e)
        {
            speakFloorName(0);
        }


        public void speakFloorName(int x)
        {
            string msg = "";
            
            try
            {
                assistatantAgentSpeaker.Dispose();
                assistatantAgentSpeaker = new SpeechSynthesizer();
                assistatantAgentSpeaker.Volume = 100;
                msg = acknowledgeTick();
                if (x == 1) { assistatantAgentSpeaker.SpeakAsync("Auto Detection On."); }
                else if (x == 2) { assistatantAgentSpeaker.SpeakAsync("Hello, Cindy is here to help."); }

                if (msg.Equals("NWAV")) { msg = "Sorry, KCB Wireless Network is not in range."; }
                else
                {
                    assistatantAgentSpeaker.SpeakAsync("Detecting floor complete.");
                    msg = "You are in " + msg + " Floor.";
                }
                assistatantAgentSpeaker.SpeakAsync(msg);
            }
            catch (Exception ex)
            {
                assistatantAgentSpeaker.SpeakAsync("Sorry, cannot recognize your command! " + ex.Message);
            }
        }


        //Detect floor by the signal strength of each floor.
        public int detectFloor()
        {
            int floorNum = -1;
            bool kcbWIFI = false;
            kcbWIFI=scanSorroundingFloor();
            int greatestSignalStrength = rF[1].signalStrength;
            for (int i = 1; i < 7; i++)
            {
                if (rF[i].signalStrength >= greatestSignalStrength)
                {
                    floorNum = i;
                    greatestSignalStrength = rF[i].signalStrength;
                }
            }
            currentFloor = floorNum;
            if (kcbWIFI) { return floorNum; }
            else { return -1; }
        }

        public int preciseWIFIPeerDetection()
        {
            /* WIFI Mac Address               Combination
               L4(0022B048DB98,0022B04986C8)  Unique
               L3(0022B04984B0,0022B0498358)  Unique
               L2(0022B048DBB0)               Unique
               L1(0022B04990B8,0022B0498838)  Unique
               LG(0022B0498B58,0022B0498B50)  Unique
               LB(0022B0498C38,0022B0498C30)  Unique
             * 
             * 
             */
            return -1;
        }

        public void setDefaultDBM()
        {
            rF[7].signalStrength = -9000;
            rF[6].signalStrength = -9000;
            rF[5].signalStrength = -9000;
            rF[4].signalStrength = -9000;
            rF[3].signalStrength = -9000;
            rF[2].signalStrength = -9000;
            rF[1].signalStrength = -9000;
        }

        //Method to scan the 
        public bool scanSorroundingFloor()
        {
            WlanClient client = new WlanClient();
            string SSID = "";
            string RoMAC = "";
            //uint SignalStrength = 0;
            bool foundKCBWIFI = false;
            try
            {
                    foreach (WlanClient.WlanInterface wlanIface in client.Interfaces) {
                        Wlan.WlanBssEntry[] wlanBssEntries = wlanIface.GetNetworkBssList();
                        foreach (Wlan.WlanBssEntry network in wlanBssEntries){
                            SSID = SSIDName(network.dot11Ssid);
                            //SignalStrength = network.linkQuality;
                            int SignalStrengths = network.rssi;
                            byte[] macAddress = network.dot11Bssid;

                            RoMAC = "";
                            //Get Mac Address of the SSID
                            for (int i = 0; i < macAddress.Length; i++) {
                                RoMAC += macAddress[i].ToString("x2").PadLeft(2, '0').ToUpper();
                            }
                            for (int i = 1; i <= 7; i++) {
                                if (RoMAC.Equals(rF[i].MACAddress)) {
                                    rF[i] = new routerInfo(rF[i].MACAddress, SignalStrengths);
                                    foundKCBWIFI = true;
                                    //Console.WriteLine("SSID :{0} \nSignal Strength :{1}%", SSID, SignalStrength);
                                    //Console.WriteLine("Mac: {0}", RoMAC);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return foundKCBWIFI;
            }

            static string SSIDName(Wlan.Dot11Ssid ssid)
            {
                return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
            }

            public string acknowledgeTick()
            {
                int fL = detectFloor();
                string msg = "";
                hideTicks();
                if (fL == 1){
                    msg = "1st";
                    this.Tick1.Visible = true;
                }
                else if (fL == 2){
                    msg = "2nd";
                    this.Tick2.Visible = true;
                }
                else if (fL == 3){
                    msg = "3rd";
                    this.Tick3.Visible = true;
                }
                else if (fL == 4){
                    msg = "4th";
                    this.Tick4.Visible = true;
                }
                else if (fL == 5){
                    msg = "5th";
                    this.Tick5.Visible = true;
                }
                else if (fL == 6){
                    msg = "Basement";
                    this.TickB.Visible = true;
                }
                else if (fL == 7){
                    msg = "Ground";
                    this.TickG.Visible = true;
                }
                else{
                    msg = "NWAV";
                    hideTicks();
                }
                return msg;
            }

            //Set all the tick images visible false
            public void hideTicks()
            {
                this.Tick1.Visible = false;
                this.Tick2.Visible = false;
                this.Tick3.Visible = false;
                this.Tick4.Visible = false;
                this.Tick5.Visible = false;
                this.TickG.Visible = false;
                this.TickB.Visible = false;
            }

            private void autoDetectFloorTimer_Tick(object sender, EventArgs e)
            {
                int fL = -1;
                int cF = currentFloor;
                if (autoDetectCheck.Checked){
                    fL = detectFloor();
                    if (fL != cF && fL !=-1) 
                    {
                        hideTicks();
                        speakFloorName(0);
                    }
                }
            }

            private void KCBFloorForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                srec.RecognizeAsyncStop();
                srec.Dispose();
            }

            private void showRSSI_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Level: 4  " + rF[4].signalStrength + "DBM" +
                    "\nLevel: 3 " + rF[3].signalStrength + "DBM" +
                    "\nLevel: 2 " + rF[2].signalStrength + "DBM" +
                    "\nLevel: 3 " + rF[1].signalStrength + "DBM" +
                    "\nLevel: Ground " + rF[7].signalStrength + "DBM" +
                    "\nLevel: Basement " + rF[6].signalStrength + "DBM"
                    );

            }  
     }
}   
