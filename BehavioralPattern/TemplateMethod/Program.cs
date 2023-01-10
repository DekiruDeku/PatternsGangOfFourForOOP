using System;

namespace TemplateMethod
{
  internal class Program
  {
    // dопределяет скелет алгоритма,
    // перекладывая ответственность за некоторые его шаги на подклассы
    public static void Main(string[] args)
    {
      Transmitter analogTransmitter = new AnalogTransmitter();
      analogTransmitter.ProcessStart();

      Console.WriteLine();

      Transmitter digitTransmitter = new DigitTransmitter();
      digitTransmitter.ProcessStart();
    }
  }
}