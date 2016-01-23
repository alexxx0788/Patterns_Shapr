using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.structure;

namespace Adapter
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.2.php
    /// Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого. 
    /// Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.
    /// Для примера взят прототип плеера который играет только видео, но  у нас на машине есть и аудио которое мы тоже хотим проигрывать, для этого создаеться класс adapter что поздволяет 
    /// преобразовать формат аудио в видео (только для нашего плеера).
    /// И затем мы можем проигрывать обо формата.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var playList = new List<IVideoPlayer>();
            playList.Add(new VideoFormat("video.avi"));
            playList.Add(new AudioToVideoAdapter(new AudioFormat("audio.mp3")));
            playList.ForEach(l=>l.LoadVideo());
            Console.Read();
        }
    }
}
