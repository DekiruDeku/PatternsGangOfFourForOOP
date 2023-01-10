using System;
using Bridge.Abstraction;
using Bridge.Realization;

namespace Bridge
{
    internal class Program
    {
        // разделяет один или несколько классов на две отдельные иерархии — абстракцию и реализацию
        // Вместо наследования мы делигируем(выдеояем один из классов и отдельную иерархию и ссылаемся на него)
        // «Абстракция» это образный слой управления чем-либо(прим. графический интерфейс программы). 
        // Хорошим примером Абстракции и реализации. Пульт и прибор, где пульт абст. ,а прибор реализация
        public static void Main(string[] args)
        {
            Remote remote = new AdvencedRemote(new TV());
            remote.EnablePower();
            remote.ChangeChannel(12);
            remote.ChangeVolume(100);
            remote.ExtraButton();
            remote.DisablePower();

            remote = new AutoRemote(new Radio());
            remote.EnablePower();
            remote.ChangeChannel(1);
            remote.ExtraButton();
            
        }
    }
}