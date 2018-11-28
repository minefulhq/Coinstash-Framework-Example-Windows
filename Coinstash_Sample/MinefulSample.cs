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

            cpuUsageTimer = new Timer();
            cpuUsageTimer.Interval = 1000;
            cpuUsageTimer.Tick += new EventHandler(onCheckTimer);
            cpuUsageTimer.Enabled = true;
        }

        private void onAppClosing(object sender, FormClosingEventArgs e)
        {
            Mineful.stopMining();                             // Stop mining
        }

        private void onStart(object sender, EventArgs e)
        {
            if (!Mineful.currentMinerStatus())                // Mineful isn't working
            {

                Mineful.setApplicationInfo(Credentials.UID,
                    Credentials.SECRET);
                Mineful.setCPULimit((int)cpuLimitSpinner.Value);

                if (portComboBox.Text == "Detect")
                {
                    startButton.Enabled = false;
                    startButton.Text = "Detecting Port...";
                    Mineful.startTestingWithOrders(Credentials.AUTHCODE, new OnFinishedTesting((port) =>
                    {
                        
                        startButton.Invoke(new Action(() => {
                            startButton.Text = "Stop";
                            startButton.Enabled = true;
                            }));
                        Mineful.startMiningWithOrders(
                            port,                                       // port number
                            "x",                                        // password
                            SystemInfo.logicalCores() / 2,              // number of cores
                            "warn",                                     // slow memory option
                            amdRadio.Checked ? "amd" :
                            nvidiaRadio.Checked ? "nvidia" :
                            detectRadio.Checked ? "detect" :
                            "none",                                     // gpu mode
                            Credentials.AUTHCODE                        // authorization code
                       );
                    }));
                }
                else
                {
                    Mineful.startMiningWithOrders(
                        Int32.Parse(portComboBox.Text),                 // port number
                        "x",                                            // password
                        SystemInfo.logicalCores() / 2,                  // number of cores
                        "warn",                                         // slow memory option
                        amdRadio.Checked ? "amd" :
                        nvidiaRadio.Checked ? "nvidia" :
                        detectRadio.Checked ? "detect" :
                        "none",                                         // gpu mode
                        Credentials.AUTHCODE                            // authorization code
                    );
                    startButton.Text = "Stop";
                }

            }
            else
            {
                Mineful.stopMining();

                startButton.Text = "Start";
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
