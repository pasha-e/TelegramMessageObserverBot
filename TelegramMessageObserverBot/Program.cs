using System;
using TelegramMessageObserverBot.Diagnostics;
using TelegramMessageObserverBot.Telegram;

namespace TelegramMessageObserverBot
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            FileLogger _logger = new FileLogger();

            TelegramMessageController _telegramMessageController = new TelegramMessageController(_logger);

            _logger.AddLoggingModule(_telegramMessageController);

            Console.WriteLine("Start");
            
            _telegramMessageController.Start();

            Console.ReadLine();

            _telegramMessageController.Stop();


        }
    }
}