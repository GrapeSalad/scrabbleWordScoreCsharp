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

    public char[] ScrabbleScoring(string userInput)
    {
      string fixedUserInput = Regex.Replace(userInput, @"[^\w]", "");
      char[] arrayInput = fixedUserInput.ToCharArray();
      Console.WriteLine(arrayInput);
      return arrayInput;
    }
  }
}
