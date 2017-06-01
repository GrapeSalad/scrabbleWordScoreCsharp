using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrabbleProject.Objects
{
  public class Scrabble
  {
    // private string _userInput;

    // public Scrabble(string userInput)
    // {
    //   _userInput = userInput;
    // }

    public List<char> ScrabbleScoring(string userInput)
    {
      string fixedUserInput = Regex.Replace(userInput, @"[^\w]", "");
      char[] arrayInput = fixedUserInput.ToCharArray();
      Console.WriteLine(arrayInput);
      List<char> newList = new List<char> {};
      for(int i = 0; i < arrayInput.Length; i++)
      {
        if((arrayInput[i] == 'q') || (arrayInput[i] == 'z'))
        {
          newList.Add('9');
        }
        else if((arrayInput[i] == 'd') || (arrayInput[i] == 'g'))
        {
         newList.Add('2');
        }
        else if((arrayInput[i] == 'b') || (arrayInput[i] == 'c') || (arrayInput[i] == 'm') || (arrayInput[i] == 'p'))
        {
         newList.Add('3');
        }
        else if((arrayInput[i] == 'f') || (arrayInput[i] == 'h') || (arrayInput[i] == 'v') || (arrayInput[i] == 'w') || (arrayInput[i] == 'y'))
        {
        newList.Add('4');
        }
        else if(arrayInput[i] == 'k')
        {
         newList.Add('5');
        }
        else if((arrayInput[i] == 'j') || (arrayInput[i] == 'x'))
        {
         newList.Add('8');
        }
        else
        {
          newList.Add('1');
        }
      }
      return newList;
    }
  }
}
