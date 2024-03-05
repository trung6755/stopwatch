using System;

namespace stopwatch
{
    public class stopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime => startTime;
        public DateTime EndTime => endTime;

        public void stopwatch()
        {
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public double GetTime()
        {
            return endTime.Millisecond - startTime.Millisecond;
        }
    }   
}
