using System;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;
using Mineful_Windows;
using CredentialsInfo;

namespace Mineful_Sample
{
    public partial class MinefulSample : Form
    {
        Timer cpuUsageTimer;
        public MinefulSample()
        {
            InitializeComponent();
            this.FormClosing += onAppClosing;
        }

        private void onAppClosing(object sender, FormClosingEventArgs e)
        {
            Mineful.stopMining();                             // Stop mining
        }

        private void onStart(object sender, EventArgs e)
        {
            if (!Mineful.currentMinerStatus())                // Mineful isn't working
            {
                if (minerComboBox.Text == "xmr-stak")
                {
                    Mineful.setMinerType(Mineful.MinerType.XMRSTAK);
                }
                else
                {
                    Mineful.setMinerType(Mineful.MinerType.CNCPUMINER);
                }

                Mineful.setApplicationInfo(Credentials.UID,
                    Credentials.SECRET);
                Mineful.setCPULimit((int)cpuLimitSpinner.Value);

                Mineful.startMining(
                    int.Parse(portComboBox.Text),               // port number
                    "x",                                        // password
                    SystemInfo.logicalCores() / 2,              // number of cores
                    "warn",                                     // slow memory option
                    currencyComboBox.Text,                      // currency
                    amdRadio.Checked ? "amd" :          
                    nvidiaRadio.Checked ? "nvidia" : 
                    detectRadio.Checked ? "detect" :
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
                Mineful.stopMining();

                startButton.Text = "Start";
                cpuUsageTimer.Enabled = false;
            }
        }

        private void onCheckTimer(object sender, EventArgs e)
        {                
            hashRateLabel.Text = 
                "Hash Rate: " + Mineful.getHashRate().ToString() + " Hash/S\n" +
                "Accepted:  " + Mineful.getAccepted().ToString() + " \n";
            cpuUsageLabel.Text = "CPU Usage: " + SystemInfo.cpuUsage().ToString() + " %\n";
        }
    }
}
