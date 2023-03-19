using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace LabaN5
{
  class File
  {
    static void Main(string[] args)
    {
      Console.Write("Введите путь к файлу: ");
      string Path = Console.ReadLine();
      FileInfo fileInfo = new FileInfo(Path);
      if (!fileInfo.Exists)
      {
        Console.WriteLine("Файл не найден.");
      }
      int UserChoice = 0;
      while (UserChoice != 3)
      {
        Console.WriteLine("Выберите действие:\n1.Исправить ошибки в словах.\n2.Исправить номера телефонов.\n3.Выход.");
        while (UserChoice < 1 || UserChoice > 3)
        {
          if (int.TryParse(Convert.ToString(Console.ReadLine()), out UserChoice) == false)
          {
            Console.WriteLine("Некорректная команда");
          }
        }
        Console.Clear();

        switch (UserChoice)
        {
          case 1:
            Console.Clear();
            ChangingMistakes.Searching(Path);
            UserChoice = 0;
            break;
          case 2:
            Console.Clear();
            ChangingNumbers.EditingNums(Path);
            UserChoice = 0;
            break;
        }
      }
      Console.ReadKey();
    }
  }
}

