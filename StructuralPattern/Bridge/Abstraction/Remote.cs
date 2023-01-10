using System;
using Bridge.Realization;

namespace Bridge.Abstraction
{
    public abstract class Remote
    {
        protected IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void EnablePower()
        {
            _device.Enable();
            Console.WriteLine("Включили");
        }

        public void DisablePower()
        {
            _device.Disable();
            Console.WriteLine("Выключили");
        }

        public void ChangeVolume(int volume)
        {
            _device.SetVolume(volume);
            Console.WriteLine("Поменяли звук на " + volume);
        }

        public void ChangeChannel(int chanel)
        {
            _device.SetChanel(chanel);
            Console.WriteLine("Поменяли канал на " + chanel);
        }

        public abstract void ExtraButton();


    }
}