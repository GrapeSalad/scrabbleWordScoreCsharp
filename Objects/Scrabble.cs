using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ScrabbleProject.Objects
{
  public class Scrabble
  {
    public int ScrabbleScoring(string userInput)
    {
      string fixedUserInput = Regex.Replace(userInput, @"[^\w]", "");
      char[] arrayInput = fixedUserInput.ToCharArray();
      Console.WriteLine(arrayInput);
      List<int> newList = new List<int> {};
      for(int i = 0; i < arrayInput.Length; i++)
      {
        if((arrayInput[i] == 'q') || (arrayInput[i] == 'z'))
        {
          newList.Add(9);
        }
        else if((arrayInput[i] == 'd') || (arrayInput[i] == 'g'))
        {
         newList.Add(2);
        }
        else if((arrayInput[i] == 'b') || (arrayInput[i] == 'c') || (arrayInput[i] == 'm') || (arrayInput[i] == 'p'))
        {
         newList.Add(3);
        }
        else if((arrayInput[i] == 'f') || (arrayInput[i] == 'h') || (arrayInput[i] == 'v') || (arrayInput[i] == 'w') || (arrayInput[i] == 'y'))
        {
        newList.Add(4);
        }
        else if(arrayInput[i] == 'k')
        {
         newList.Add(5);
        }
        else if((arrayInput[i] == 'j') || (arrayInput[i] == 'x'))
        {
         newList.Add(8);
        }
        else
        {
          newList.Add(1);
        }
      }
      int sum = 0;
      for(int i = 0; i < newList.Count; i++)
      {
        sum += newList[i];
      }
      return sum;
    }


    // public void LoadJson(List<string> words)
    // {
    //   using (StreamReader r = new StreamReader("words.json"))
    //   {
    //     string json = r.ReadToEnd();
    //     words = JsonConvert.DeserializeObject<List<string>>(json);
    //   }
    // }
    //
    // public bool SearchForWord(string userInput)
    // {
    //   List<string> words = new List<string>{};
    //   this.LoadJson(words);
    //   Console.WriteLine(words);
    //   string wordToTest = userInput;
    //   Console.WriteLine(wordToTest);
    //   bool isRealWord = words.Contains(wordToTest);
    //
    //   Console.WriteLine(isRealWord);
    //   return isRealWord;
    // }

  }
}
