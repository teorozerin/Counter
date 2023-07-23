using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Meter : Form
    {
        int day = 0, clock = 0, minute = 0, second = 0, tour = 0;
        public Meter()
        {
            #region
            #endregion

            InitializeComponent();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
            }
            if (minute == 60)
            {
                clock++;
                minute = 0;
            }
            if (clock == 24)
            {
                day++;
                clock = 0;
            }
            DegerleriYazdir();
        }
        private void DegerleriYazdir()
        {
            lblSecond.Text = second <= 9 ? "0" + second : second.ToString();
            lblMinute.Text = minute <= 9 ? "0" + minute : minute.ToString();
            lblClock.Text = clock <= 9 ? "0" + clock : clock.ToString();
            lblDay.Text = day <= 9 ? "0" + day : day.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            second = 0;
            minute = 0;
            clock = 0;
            day = 0;
            tour = 0;
            lstTour.Items.Clear();
            DegerleriYazdir();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            tour++;
            lstTour.Items.Add(string.Format("{0}. Tour: {1} Day {2}:{3}:{4}", tour, day, clock, minute, second));
        }
    }
}
