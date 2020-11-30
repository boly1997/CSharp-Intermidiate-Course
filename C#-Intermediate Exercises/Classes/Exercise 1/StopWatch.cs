using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class StopWatch
    {
        private DateTime _ti { get; set; }
        private DateTime _tf { get; set; }
        public TimeSpan _duration 
        {
            get
            {
                return (_tf - _ti);
            }
        }

        private bool _isStarted { get; set; }

        public StopWatch() 
        {
            _isStarted = false;

        }
        
        public DateTime Start()
        {
            if (_isStarted)
            {
                throw new InvalidOperationException("StopWatch is already started");
            }
            _ti = DateTime.Now;
            _isStarted = true;
            return _ti;
        }

        public DateTime Stop()
        {
            if (!_isStarted)
            {
                throw new InvalidOperationException("StopWatch hasn't been started yet");
            }
            _tf = DateTime.Now;
            _isStarted = false;
            return _tf;
        }


    }
}
