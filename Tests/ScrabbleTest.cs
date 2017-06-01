using Xunit;
using System;

namespace ScrabbleProject.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void IsScrabbleScore_true()
    {
      string thaWords = "pants";
      Scrabble testWord = new Scrabble();
      Assert.Equal(true, testWord.ScrabbleScoring(thaWords));
    }
  }
}
