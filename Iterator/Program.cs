using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.structure;

namespace Iterator
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/3.5.php
    /// Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа ко всем элементам составного объекта без раскрытия его внутренней структуры.
    /// 
    /// В данном примере речь пойдет о библиотеке. Учавствуют сущности:
    /// IBookNumerable - интерфейс что имеет в сеебе поле Count и указатель на текущую книгу. Также метод CreateNumerator что должен вернуть IBookIterator.
    /// IBookIterator - интерфейс что имеет в себе метод Next() и переменную HasNext.
    /// Library - это класс что содержит в себе коллекцию книг и переопределенные методы из IBookNumerable.
    /// Reader -  класс что содержит в себе один метод SeeBook. На вход он получает библиотеку из которой будет читать книги. Он создает Numerator и в цикле берет следующую книгу и читает ее.
    /// LibraryNumerator - что используеться в Libarary. Он переопределил все методы из IBookNumerable интерфейса.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }
}
