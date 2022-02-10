using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuerrillaNtp;
namespace NTPClock
{
    public partial class Form1 : Form
    {
        Timer timer;
        NtpClient ntpClient;
        TimeSpan difference;
        int times=0;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            try
            {
                ntpClient = new NtpClient(Dns.GetHostAddresses("pool.ntp.org")[0]);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            

        }
        void UpdateTimes()
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            times++;
            SystemTime.Text = DateTime.UtcNow.ToString();
            if (times % 2000==0)
            {
                try
                {
                    difference = ntpClient.GetCorrectionOffset();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            DifferenceText.Text = difference.TotalMilliseconds.ToString();
            NTPTime.Text = (DateTime.UtcNow + difference).ToString();
            
        }
    }
}
