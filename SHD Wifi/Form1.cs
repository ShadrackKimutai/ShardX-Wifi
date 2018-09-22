using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHD_Wifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            showNotification();
        }

        private void bar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {


            ConnectedDevices();   
    //Dim sOutput As String
    //Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
    //    sOutput = oStreamReader.ReadToEnd()
    //End Using

    //TextBox4.Text = sOutput
        }

        private void ConnectedDevices()
        {
            String output;
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C netsh wlan show hostednetwork");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            p.StartInfo = info;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            p.WaitForExit();


           
            StreamReader streamreader = p.StandardOutput;
            output = streamreader.ReadToEnd();
            MessageBox.Show(output);
          
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog(this);
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            showNotification();
            this.Hide();
        }
        void showNotification()
        {
            shardxwifi.BalloonTipTitle = "Shardx Wifi";
            shardxwifi.BalloonTipText = "Shardx Wifi Running in Background";

            try
            {
                shardxwifi.Icon = SHD_Wifi.Properties.Resources.wifi_16;
                clearExisiting();
               setWifi();

               startWifi();
               shardxwifi.Icon = SHD_Wifi.Properties.Resources.wifi_16__1_;
               shardxwifi.ShowBalloonTip(2000);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong Somewhere.\nThis is the message we got\n" + ex.Message);
            }
        }

        private void startWifi()
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C netsh wlan start hostednetwork");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }
        void clearExisiting()
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd.exe","/C netsh wlan stop hostednetwork");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }
        void setWifi()
        {
            
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd.exe","/C netsh wlan set hostednetwork mode=allow ssid=" + SavedSettings.Default.WifiName + " key=" + SavedSettings.Default.WifiPassword);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WindowStyle=System.Diagnostics.ProcessWindowStyle.Hidden;
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }

        private void showShardXWifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void closeShardXWifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showActiveConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectedDevices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = SHD_Wifi.Properties.Resources.wifi_16__1_;
        }
    }
}
