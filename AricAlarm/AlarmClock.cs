using System;

namespace AricPackage
{
    public class AlarmClock
    {
        private DateTime startTime;
        private int alarmID = 0;
        private int dseconds = 0;
        private string alarmName = "null";

        System.Timers.Timer timer;
        // private Func<string, int, int> alarmTimeoutFun = (alarmName, alarmID) => 0;
        private Func<string, int, int> alarmTimeoutFun; // = (alarmName, alarmID) => 0;

        public AlarmClock(Func<string, int, int> alarmTimeoutFun, string alarmName, int alarmID)
        {
            this.alarmTimeoutFun = alarmTimeoutFun;
            this.alarmName = alarmName;
            this.alarmID = alarmID;
            Console.WriteLine("Alarm [{0}] register...", this.alarmName);

            //set timer property
            timer = new System.Timers.Timer();
            timer.Interval = 900;
            timer.Elapsed += Timer_Elapsed;
        }

        public bool stopAlarm()
        {
            if (this.alarmTimeoutFun == null)
            {
                return false;
            }

            if (timer == null)
            {
                return false;
            }
            else
            {
                Console.WriteLine("AlarmClock [{0}] stop", this.alarmName);
                timer.Stop();
                return true;
            }
        }

        public bool startAlarmClock(int seconds)
        {
            if (this.alarmTimeoutFun == null)
            {
                Console.WriteLine("[Error] it does not register this alarm");
                return false;
            }

            startTime = DateTime.Now;
            this.dseconds = seconds;
            Console.WriteLine("AlarmClock {0} [{1}] duration: {2} seconds start ", DateTime.Now, this.alarmName, this.dseconds);
            timer.Start();
            return true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var timeDiff = DateTime.Now.Subtract(startTime).TotalSeconds;
            if (timeDiff > dseconds)
            {
                Console.WriteLine("AlarmClock {0} [{1}] trigger", DateTime.Now, this.alarmName);
                timer.Stop();

                if (alarmTimeoutFun != null)
                {
                    Console.WriteLine("AlarmClock [{0}] Callback", this.alarmName);
                    alarmTimeoutFun.Invoke(this.alarmName, this.alarmID);
                }
            }
        }

        ~AlarmClock()
        {
            Console.WriteLine("AlarmClock {0} release...", this.alarmName);
            timer.Elapsed -= Timer_Elapsed;
        }

        public void recount()
        {
            startTime = DateTime.Now;
        }
    }
}
