using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Collections;

namespace LabaN5
{
  internal class ChangingMistakes
  {
    public static void Searching(string Path)
    {
      var Words = new List<string>()
      {
        "ghbdtn", "plhfdcndeqnt", "пирвет", "превед", "привте", "драсьте", "здраствуйте", "сдравствуйте", "сдраствуйте"
      };
      var UsingWords = new List<string>(Words);

      for (int IndexOfWord = 0; IndexOfWord < UsingWords.Count; ++IndexOfWord)
      {
        if (UsingWords[IndexOfWord] == "ghbdtn" || UsingWords[IndexOfWord] == "пирвет" || UsingWords[IndexOfWord] == "превед" || UsingWords[IndexOfWord] == "привте")
        {
          string Word = UsingWords[IndexOfWord];
          string Text = string.Empty;
          using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
          {
            Text = Reader.ReadToEnd();
          }
          if (Text.Contains(Word))
          {
            string RightWord = "Привет";
            string Result = Text.Replace(Word, RightWord);
            using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
            {
              File.Write(Result);
            }
          }
        }
        else if (UsingWords[IndexOfWord] == "plhfdcndeqnt" || UsingWords[IndexOfWord] == "драсьте" || UsingWords[IndexOfWord] == "здраствуйте" || UsingWords[IndexOfWord] == "сдравствуйте" || UsingWords[IndexOfWord] == "сдраствуйте")
        {
          string Word = UsingWords[IndexOfWord];
          string Text = string.Empty;
          using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
          {
            Text = Reader.ReadToEnd();
          }
          if (Text.Contains(Word))
          {
            string RightWord = "Здравствуйте";
            string Result = Text.Replace(Word, RightWord);
            using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
            {
              File.Write(Result);
            }
          }
        }
      }
      Console.Clear();
      Console.Write("Замена прошла успешно, нажмите любую клавишу чтобы продолжить.");
      Console.ReadKey();
    }
  }
}