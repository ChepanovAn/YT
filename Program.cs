using System;
using System.Text;

namespace YT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Ссылка на видео
            var url = "https://www.youtube.com/watch?v=MOTyggIH4eg";
            var outPath = "video.mp4";

            // создадим отправителя 
            var sender = new Sender(); 
            // создадим команду получения описания                                                          
            var getInfo = new GetCommand(url);

            // создадим получателя 
            var receiver = new Receiver();
            //создадим команду скачивания видео
            var downloadVideo = new DownloadCommand(url, outPath);

            // инициализация команды и выполнение
            sender.SetCommand(getInfo);
            sender.Run();

            sender.SetCommand(downloadVideo);
            sender.Run();

            Console.ReadKey();
        }
    }    
}
