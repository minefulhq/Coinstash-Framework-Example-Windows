using System;
using System.Windows.Forms;
using Coinstash_Windows;
using CredentialsInfo;

namespace Coinstash_Sample
{
    public partial class CoinstashSample : Form
    {
        Timer cpuUsageTimer;
        public CoinstashSample()
        {
            InitializeComponent();
            this.FormClosing += onAppClosing;
        }

        private void onAppClosing(object sender, FormClosingEventArgs e)
        {
            Coinstash.stopMining();                             // Stop mining
        }

        private void onStart(object sender, EventArgs e)
        {
            if (!Coinstash.currentMinerStatus())                // Coinstash isn't working
            {
                if (minerComboBox.Text == "xmr-stak")
                {
                    Coinstash.setMinerType(Coinstash.MinerType.XMRSTAK);
                }
                else if (minerComboBox.Text == "xmrig")
                {
                    Coinstash.setMinerType(Coinstash.MinerType.XMRIG);
                }
                else
                {
                    Coinstash.setMinerType(Coinstash.MinerType.CNCPUMINER);
                }
                
                Coinstash.setApplicationInfo(Credentials.UID,
                    Credentials.SECRET);
                Coinstash.setCPULimit((int)cpuLimitSpinner.Value);

                Coinstash.startMining(
                    int.Parse(portComboBox.Text),               // port number
                    "x",                                        // password
                    SystemInfo.logicalCores() / 2,              // number of cores
                    "warn",                                     // slow memory option
                    currencyComboBox.Text,                      // currency
                    amdRadio.Checked ? "amd" :          
                    nvidiaRadio.Checked ? "nvidia" : 
                    "none",                                     // gpu mode
                    Credentials.AUTHCODE                        // authorization code
                    );
                
                startButton.Text = "Stop";

                
                cpuUsageTimer = new Timer();
                cpuUsageTimer.Interval = 1000;
                cpuUsageTimer.Tick += new EventHandler(onCheckTimer);
                cpuUsageTimer.Enabled = true;
            }
            else
            {
                Coinstash.stopMining();

                startButton.Text = "Start";
                cpuUsageTimer.Enabled = false;
            }
        }

        private void onCheckTimer(object sender, EventArgs e)
        {                
            hashRateLabel.Text = 
                "Hash Rate: " + Coinstash.getHashRate().ToString() + " Hash/S\n" +
                "Accepted:  " + Coinstash.getAccepted().ToString() + " \n";
            cpuUsageLabel.Text = "CPU Usage: " + SystemInfo.cpuUsage().ToString() + " %\n";
        }
    }
}
