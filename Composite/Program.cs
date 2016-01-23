using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using Composite.structure;

namespace Composite
{
    /// <summary>
    /// http://metanit.com/sharp/patterns/4.4.php
    /// Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру по принципу "часть-целое и позволяет клиенту одинаково работать как с отдельными объектами, 
    /// так и с группой объектов.
    /// Для примера взята файловая система где есть абстрактный класс Component и классы наследники для ФС directory и file.
    /// Сначала мы создали диск в него мы добавили папки и файлы, затем мы взяли папку и добавили туда папки и файлы.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("Файловая система");
            // определяем новый диск
            Component diskC = new Directory("Диск С");
            // новые файлы
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");
            // добавляем файлы на диск С
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // добавляем диск С в файловую систему
            fileSystem.Add(diskC);
            // выводим все данные
            fileSystem.Print();
            Console.WriteLine();
            // удаляем с диска С файл
            diskC.Remove(pngFile);
            // создаем новую папку
            Component docsFolder = new Directory("Мои Документы");
            // добавляем в нее файлы
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Print();

            Console.Read();
        }
    }
}
