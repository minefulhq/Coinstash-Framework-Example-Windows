using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coinstash_Windows;

namespace DllTest
{
    public partial class Form1 : Form
    {
        bool isStarted = false;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Coinstash.stopMining();
            //Console.WriteLine("YES");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Console.WriteLine(System.Diagnostics.Process.GetCurrentProcess().Id);
            Coinstash.setParentProcessId(System.Diagnostics.Process.GetCurrentProcess().Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                Coinstash.setNvidia(!checkBox2.Checked);
                Coinstash.setAMD(!checkBox1.Checked);
                Console.WriteLine(comboBox3.Text);
                if (comboBox3.Text == "xmr-stak")
                {
                    Coinstash.setMinerType(Coinstash.MinerType.XMRSTAK);
                }
                else if (comboBox3.Text == "xmrig")
                {
                    Coinstash.setMinerType(Coinstash.MinerType.XMRIG);
                }
                else
                {
                    Coinstash.setMinerType(Coinstash.MinerType.CNCPUMINER);
                }
                Coinstash.setCPULimit((int)numericUpDown1.Value);
                Coinstash.startMining(int.Parse(comboBox2.Text), "x", SystemInfo.logicalCores() / 2, "warn", comboBox1.Text, "08b0e9578676cd5f7b8c1670d095389db786061d");
                button1.Text = "Stop";
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_tick);
                timer.Enabled = true;
                timer.Start();
            }
            else
            {
                Coinstash.stopMining();
                button1.Text = "Start";
                timer.Stop();
            }
            isStarted = !isStarted;

        }

        private void timer_tick(object sender, EventArgs e)
        {
            label1.Text = "Hash Rate: " + Coinstash.getHashRate().ToString() + " Hash/S\n" +
                "Accepted: " + Coinstash.getAccepted().ToString() + " \n";
            label2.Text = "CPU Usage: " + SystemInfo.cpuUsage().ToString() + " %\n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
