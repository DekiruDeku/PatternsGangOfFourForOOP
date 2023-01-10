using System;
using Bridge.Realization;

namespace Bridge.Abstraction
{
    public class AutoRemote : Remote
    {
        public AutoRemote(IDevice device) : base(device)
        {
        }

        public override void ExtraButton()
        {
            _device.SetVolume(100);
            Console.WriteLine("Добавили бассов");
        }
    }
}