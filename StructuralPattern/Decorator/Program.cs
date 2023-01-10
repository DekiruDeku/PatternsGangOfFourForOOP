using System;

namespace Decorator
{
    internal class Program
    {
        //использующий композицию и обратную вложенность
        // Позволяет обертывать класс  обертку и добалять новые свойстав
        // Лучше сего использоать когда изменение кода не допустимо, а надо переопределить функционал
        // Обязанности изменений на лету
        public static void Main(string[] args)
        {
            IProcesor trans = new Transmitter("12333");
            trans.Process();

            Console.WriteLine();

            Shell hammingcoder = new HammingCoder(trans);
            hammingcoder.Process();

            Console.WriteLine();

            Shell encryptor = new Encryptor(trans);
            encryptor.Process();
        }
    }
}