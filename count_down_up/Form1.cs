using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Speech.Synthesis;


namespace count_down_up
{
    public partial class Form1 : Form
    {

		countdown_timer ct = new countdown_timer();

		public Form1()
        {
            InitializeComponent();
			ct.NewTimer(this);
		}


        private void button1_Click(object sender, EventArgs e)
        {
			this.hh.Enabled = false;
            this.mm.Enabled = false;
            this.ss.Enabled = false;
			this.start.Enabled = false;
			this.stop.Enabled = true;
            this.set_time.Text = "" + this.hh.Value.ToString().PadLeft(2, '0') + ":" + this.mm.Value.ToString().PadLeft(2, '0') + ":" + this.ss.Value.ToString().PadLeft(2, '0') + "";

			int ref_time = ((int)this.hh.Value)*24*60+ ((int)this.mm.Value)*60+((int)this.ss.Value);

			ct.StartTimer(ref_time);
        }

        private void stop_Click(object sender, EventArgs e)
        {
			this.hh.Enabled = true;
			this.mm.Enabled = true;
			this.ss.Enabled = true;
			this.start.Enabled = true;
			this.stop.Enabled = false;
			ct.StopTimer();
		}
    }

	//タイマー
	public class countdown_timer
	{
		private Form1 f1;
		private System.Timers.Timer timer;
		private int ref_time;

		private SpeechSynthesizer synth = new SpeechSynthesizer();

		public void NewTimer(Form1 form1)
		{
			timer = new System.Timers.Timer();
			timer.Enabled = false;
			timer.AutoReset = true;
			timer.Interval = 100;
			timer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
			f1 = form1;


			synth.SetOutputToDefaultAudioDevice();
			synth.Rate = +3;
		}

		public void OnTimerEvent(object source, ElapsedEventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			int x_time = dateTime.Hour * 24 * 60 + dateTime.Minute * 60 + dateTime.Second - ref_time;
			int milli = dateTime.Millisecond /100;

			f1.now_time.BeginInvoke((MethodInvoker)delegate () {
				f1.now_time.Text = "" + dateTime.Hour.ToString().PadLeft(2, '0') + ":" + dateTime.Minute.ToString().PadLeft(2, '0') + ":" + dateTime.Second.ToString().PadLeft(2, '0') + "." + milli + "";
			});

			f1.count.BeginInvoke((MethodInvoker)delegate () {
				if (x_time > 0)
				{
					f1.count.Text = "X+" + x_time.ToString().PadLeft(3, '0') + "";
				}
				else
				{
					f1.count.Text = "X-" + (-1*x_time).ToString().PadLeft(3, '0') + "";
				}
			});

			if (milli == 9)
			{
				int t = x_time +1;
				string str = t >= 0 ? t.ToString() : (-t).ToString();

				if (
					 (System.Math.Abs(t) < 20 )||
					 (System.Math.Abs(t) < 180 && t % 5 == 0) ||
					 (t % 10 == 0)
					)
				{
					synth.SpeakAsync(str);
				}
			}
		}

		public void StartTimer(int x)
		{
			ref_time = x;
			timer.Start();
		}

		public void StopTimer()
		{
			timer.Stop();
		}
	}
}
