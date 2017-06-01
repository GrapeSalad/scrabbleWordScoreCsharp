using Nancy;
using ScrabbleProject.Objects;
using System.Collections.Generic;

namespace ScrabbleProject.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml"];
      };
      Post["/"] = _ => {
      Scrabble newScrabble = new Scrabble();
      int output = newScrabble.ScrabbleScoring(Request.Form["word"]);
      return View["index.cshtml", output];
      };
    }
  }
}
