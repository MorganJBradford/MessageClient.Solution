using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessiageClient.Models;

namespace MessageClient.Controllers
{
  public class BMessagesController : Controller
  {
    public IActionResult Index()
    {
      var allBMessages = BMessage.GetBMessage();
      return View(allBMessages);
    }

    [HttpPost]
    public IActionResult Index(BMessage message)
    {
      BMessage.Post(message);
      return RedirectToAction("Index");
    }

    public IActionResult Detail(int id)
    {
      var message = BMessage.GetDetails(id)
    }
  }
}