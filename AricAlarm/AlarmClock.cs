using System;
using System.Threading.Tasks;

namespace AricPackage
{
    public class AlarmClock
    {
        private DateTime startTime;
        private int alarmID = 0;
        private int dseconds = 0;
        private string alarmName = "null";
        bool isShowLog = false;

        System.Timers.Timer timer;
        private Func<string, int, int> timeoutFunc; // = (alarmName, alarmID) => 0;
        private Action<string, int> timeoutAction; // = (alarmName, alarmID) => 0;

        public AlarmClock(Func<string, int, int> timeoutFunc, string alarmName, int alarmID, bool isShowLog = true)
        {
            this.timeoutFunc = timeoutFunc;
            this.alarmName = alarmName;
            this.alarmID = alarmID;
            this.isShowLog = isShowLog;
            
            if(this.isShowLog)
                Console.WriteLine("Alarm [{0}] timeoutFunc register...", this.alarmName);

            //set timer property
            timer = new System.Timers.Timer();
            timer.Interval = 900;
            timer.Elapsed += Timer_Elapsed;
        }

        public AlarmClock(Action<string, int> timeoutAction, string alarmName, int alarmID, bool isShowLog = true)
        {
            this.timeoutAction = timeoutAction;
            this.alarmName = alarmName;
            this.alarmID = alarmID;
            this.isShowLog = isShowLog;

            if (this.isShowLog)
                Console.WriteLine("Alarm [{0}] timeoutAction register...", this.alarmName);

            //set timer property
            timer = new System.Timers.Timer();
            timer.Interval = 900;
            timer.Elapsed += Timer_Elapsed;
        }

        public void setShowLog(bool IsShow)
        {
            isShowLog = IsShow;
        }

        public bool stopAlarm()
        {
            if (this.timeoutFunc == null && this.timeoutAction == null)
            {
                return false;
            }

            if (timer == null)
            {
                return false;
            }
            else
            {
                if (isShowLog)
                    Console.WriteLine("AlarmClock [{0}] stop", this.alarmName);
                timer.Stop();
                return true;
            }
        }

        public bool startAlarmClock(int seconds)
        {
            if (this.timeoutFunc == null && timeoutAction == null)
            {
                if (isShowLog)
                    Console.WriteLine("[Error] it does not register this alarm");
                return false;
            }

            startTime = DateTime.Now;
            this.dseconds = seconds;
            if (isShowLog)
                Console.WriteLine("AlarmClock {0} [{1}] duration: {2} seconds start ", DateTime.Now, this.alarmName, this.dseconds);
            timer.Start();
            return true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var timeDiff = DateTime.Now.Subtract(startTime).TotalSeconds;
            if (timeDiff > dseconds)
            {
                if (isShowLog)
                    Console.WriteLine("AlarmClock {0} [{1}] trigger", DateTime.Now, this.alarmName);
                timer.Stop();

                if (timeoutFunc != null)
                {
                    if (isShowLog)
                        Console.WriteLine("AlarmClock [{0}] Callback", this.alarmName);
                    timeoutFunc.Invoke(this.alarmName, this.alarmID);
                }

                if (timeoutAction != null)
                {
                    if (isShowLog)
                        Console.WriteLine("AlarmClock [{0}] Callback", this.alarmName);
                    timeoutAction.Invoke(this.alarmName, this.alarmID);
                }
            }
        }

        ~AlarmClock()
        {
            if (isShowLog)
                Console.WriteLine("AlarmClock {0} release...", this.alarmName);

            timeoutFunc = null;
            timeoutAction = null;

            timer.Elapsed -= Timer_Elapsed;
        }

        public void recount()
        {
            startTime = DateTime.Now;
        }
    }
}
