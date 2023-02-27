using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string presentarle() { return "que bola"; }
    [Route("/goodbye")]
    public string decirleAdios() { return "que le cuide"; }
    [Route("/")]
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable); 
    }
  }
}
