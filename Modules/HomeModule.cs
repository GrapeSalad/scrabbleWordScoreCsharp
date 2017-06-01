using Nanyc;
using ScrabbleProject.Objects;
using System.Collections.Generic;

namespace ScrabbleProject.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      return View["index.cshtml"];
    };
  }
}
