using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageClient.Models;

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

    public IActionResult Details(int id)
    {
      var message = BMessage.GetDetails(id);
      return View(message);
    }

    public IActionResult Edit(int id)
    {
      var message = BMessage.GetDetails(id);
      return View(message);
    }

    [HttpPost]
    public IActionResult Details(int id, BMessage message)
    {
      message.BMessageId = id;
      BMessage.Put(message);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      BMessage.Delete(id);
      return RedirectToAction("Index");
    }
  }
}