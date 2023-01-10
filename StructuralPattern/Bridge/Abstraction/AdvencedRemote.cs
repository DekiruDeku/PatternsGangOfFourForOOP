using System;
using Bridge.Realization;

namespace Bridge.Abstraction
{
    public class AdvencedRemote : Remote
    {
        public AdvencedRemote(IDevice device) : base(device)
        {
        }

        public override void ExtraButton()
        {
            _device.SetVolume(0);
            Console.WriteLine("Звук замутен");
        }
    }
}