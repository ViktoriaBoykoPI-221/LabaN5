using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LabaN5
{
  internal class ChangingNumbers
  {
    public static void EditingNums(string Path)
    {
      string FirstNumber = "(012) 345-67-89";
      string Text = string.Empty;
      using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
      {
        Text = Reader.ReadToEnd();
      }

      if (Text.Contains(FirstNumber))
      {
        string Pattern = @"\D(\S{4})\D\S*";
        string Result = "+380 12 345 67 89";
        Regex regex = new Regex(Pattern);
        string ResultOfEditing = regex.Replace(FirstNumber, Result);
        string Fin = Text.Replace(FirstNumber, ResultOfEditing);
        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
        {
          File.Write(Fin);
        }
      }

      Console.Clear();
      if (!Text.Contains(FirstNumber))
      {
        Console.Write("Номера для замены не найдены");
      }
      else
      {
        Console.WriteLine("Замена прошла успешно, нажмите любую клавишу чтобы продолжить");
      }
      Console.ReadKey();
    }
  }
}