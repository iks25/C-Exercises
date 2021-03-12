using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.classes
{
    class StopWatch
    {

        private DateTime StartTime;
        private TimeSpan Duration;

        private bool IsStarted = false;
        private bool IsDurationAvailable = false;

        public void Start()
        {
            if (!IsStarted)
            {
                StartTime = DateTime.Now;
                IsStarted = true;
            }
            else
                throw new InvalidOperationException
                    ("you need stop stopWatch before you start it again");
        }

        public void Stop()
        {
            if (IsStarted)
            {
                var EndTime = DateTime.Now;

                Duration = EndTime - StartTime;
                IsStarted = false;
                IsDurationAvailable = true;
            }
            else
                throw new InvalidOperationException
                    ("you can not stop StopWatch before you start it");
        }

        public TimeSpan getDuration()
        {
            if (IsDurationAvailable)
                return Duration;
            else
                throw new InvalidCastException
                    ("Duration is not availabe");
        }



    }
}
