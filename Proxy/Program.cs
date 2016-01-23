using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxy.structure;

namespace Proxy
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.5.php
    /// Паттерн Заместитель (Proxy) предоставляет объект-заместитель, который управляет доступом к другому объекту. То есть создается объект-суррогат,
    /// который может выступать в роли другого объекта и замещать его.
    /// 
    /// В данном примере есть интерфейс IBook который имеет один метод GetPage, у него есть 2 наследника BookStore и BookStoreProxy.
    /// Прокси в себе имеет коллекцию страниц и сам объект BookStore, ссылка на реальное хранилище.
    /// В программе мы создаем Прокси и пробуем брать страницы, если страницы нет в существующем списке тогда возвращаем из реального хранилища если есть из нашего закешированного хранилища.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (IBook book = new BookStoreProxy())
            {
                // читаем первую страницу
                Page page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
                // читаем вторую страницу
                Page page2 = book.GetPage(2);
                Console.WriteLine(page2.Text);
                // возвращаемся на первую страницу    
                page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
            }

            Console.Read();
        }
    }
}
