using Xunit;
using System;

namespace ScrabbleProject.Objects
{
  public class ScrabbleTest
  {
    // [Fact]
    // public void ScrabbleScoring_IsScrabbleScore_true()
    // {
    //   string thaWords = "pants";
    //   Scrabble testWord = new Scrabble();
    //   Assert.Equal(true, testWord.ScrabbleScoring(thaWords));
    // }

    [Fact]
    public void ScrabbleScoring_Separate_true()
    {
      string thaWords = "pants";
      char[] thaWordsAsArray = { 'p', 'a', 'n', 't', 's' };
      Scrabble testWord = new Scrabble();
      Assert.Equal(thaWordsAsArray, testWord.ScrabbleScoring(thaWords));
    }

    [Fact]
    public void ScrabbleScoring_RemoveSpaces_true()
    {
      string thaWords = "pants pants";
      char[] thaWordsAsArray = { 'p', 'a', 'n', 't', 's','p', 'a', 'n', 't', 's' };
      Scrabble testWord = new Scrabble();
      Assert.Equal(thaWordsAsArray, testWord.ScrabbleScoring(thaWords));
    }
  }
}
