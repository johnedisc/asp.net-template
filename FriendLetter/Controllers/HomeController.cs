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
    public string Letter() { return "la carta ahorita le pongo aca"; }
  }
}
