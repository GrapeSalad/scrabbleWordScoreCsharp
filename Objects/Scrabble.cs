using System;
using System.Collections.Generic;

namespace ScrabbleProject.Objects
{
  public class Scrabble
  {
    private string _userInput;

    // public Scrabble(string userInput)
    // {
    //   _userInput = userInput;
    // }

    public char[] ScrabbleScoring(string userInput)
    {
      char[] arrayInput = userInput.Replace(" ", "").ToCharArray();
      Console.WriteLine(arrayInput);
      return arrayInput;
    }
  }
}
