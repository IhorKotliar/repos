using System;
using System.Windows.Forms;

namespace _03022017
{
    public partial class TimerWindow : Form
    {
        private readonly Timer timer = new Timer();
        private DateTime fastTimerStartTime;
        private string labelTimerValue = null;
        private TimeSpan timeClickPause;
        public TimerWindow()
        {
            InitializeComponent();

            buttonTimerPause.Enabled = false;

            SetCurrentDate(); 
            timer.Tick += OnTimerTick;
            timer.Interval = 1000;
            timer.Start();
            
           
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            SetCurrentDate();
        }
        
        private void SetCurrentDate()
        {
            labelCurrentDate.Text = DateTime.Now.ToString();
        }

        private void OnButtonTimerStartClick(object sender, EventArgs e)
        {
            fastTimer.Start();
            fastTimerStartTime = DateTime.Now;
            buttonTimerPause.Enabled = true;
            buttonTimerStart.Enabled = false;
        }

        private void SetFastTimer()
        {
            TimeSpan dif = DateTime.Now.Subtract(fastTimerStartTime);
            if (labelTimerValue != null)
            {
                dif += timeClickPause ; 
            }
            
            labelTimer.Text = string.Format("{0}", dif.ToString(@"h\:mm\:ss\:ffff"));
        }
        private void OnFastTimerTick(object sender, EventArgs e)
        {
            SetFastTimer();
        }

        private void OnButtonTimerPauseClick(object sender, EventArgs e)
        {
            labelTimerValue = labelTimer.Text;
            long ticks = ParserLong(labelTimer.Text)*1000;
            timeClickPause = new TimeSpan(ticks);
            buttonTimerPause.Enabled = false;
            buttonTimerStart.Enabled = true;
            fastTimer.Stop();
        }

        private void OnButtonTimerResetClick(object sender, EventArgs e)
        {
            fastTimer.Stop();
            labelTimer.Text = "0:00:00:0000";
            buttonTimerPause.Enabled = false;
            buttonTimerStart.Enabled = true;
        }

        private void OnDateTimePickerValueChanged(object sender, EventArgs e)
        {
            TimeSpan dateDif = Convert.ToDateTime(dateTimePickerDif.Text) - DateTime.Now;
            if (dateDif.TotalMilliseconds<0)
            {
                labelLeft.Text = "Прошло :";
                dateDif = dateDif.Negate();
            }
            else
            {
                labelLeft.Text = "Осталось :";
            }


            labelLeftDays.Text = ParserString(labelLeftDays.Text) + dateDif.Days.ToString();
            labelLeftHours.Text = ParserString(labelLeftHours.Text) + dateDif.Hours.ToString();
            labelLeftMinutes.Text = ParserString(labelLeftMinutes.Text) + dateDif.Minutes.ToString();
            labelLeftSeconds.Text = ParserString(labelLeftSeconds.Text) + dateDif.Seconds.ToString();
        }
        private string ParserString(string str)
        {
            string temp = null;
            foreach (char item in str)
            {
                if(!Char.IsDigit(item))
                {
                    temp += item;
                }
            }
            return temp;
        }
        private long ParserLong(string str)
        {
            string temp = null;
            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    temp += item;
                }
            }
            return Convert.ToInt64(temp);
        }
    }
}
