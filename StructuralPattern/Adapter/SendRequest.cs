using System;
using System.Net;

namespace Adapter
{
    // Допустим этот класс который несете необходимый функционал, но не доступен для модернизации
    // и не несет необходимый интерфейс
    public class SendRequest
    {
        public void SendRequests(string message)
        {
            Console.WriteLine("Маааагия...");
        }
    }
}