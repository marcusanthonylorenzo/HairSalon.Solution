using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

     public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client =>  client.Stylist).ToList();
      return View(model);
    }

    public ActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Add(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("SelectStylist");
    }

    public ActionResult SelectStylist()
    {
      List<Stylist> fetchStylists = _db.Stylists.ToList();
      return View(fetchStylists);
    }

  }
}
