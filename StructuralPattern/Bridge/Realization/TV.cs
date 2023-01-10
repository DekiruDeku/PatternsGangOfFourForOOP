using System;

namespace Bridge.Realization
{
    public class TV : IDevice
    {
        private bool _enable = false;
        private int _channel = 1;
        private int _volume = 0;

        public int Channel
        {
            get
            {
                return _channel;
            }
            private set
            {
                _channel = value;
            }
        }
        
        public int Volume
        {
            get
            {
                return _volume;
            }
            private set
            {
                _volume = value;
            }
        }
        public void Enable()
        {
            _enable = true;
        }

        public void Disable()
        {
            _enable = false;
        }

        public void SetChanel(int chanel)
        {
            _channel = chanel;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }
    }
}