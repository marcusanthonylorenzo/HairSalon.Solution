using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db1;

    public ClientsController(HairSalonContext dbClient)
    {
      _db1 = dbClient;
    }

     public ActionResult Index()
    {
      List<Client> model = _db1.Clients.Include(client =>  client.Stylist).ToList();
      return View(model);
    }

    public ActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Add(Client client)
    {
      _db1.Clients.Add(client);
      _db1.SaveChanges();
      return RedirectToAction("SelectStylist", "Stylists");
    }
  }
}

