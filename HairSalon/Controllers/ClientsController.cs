using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext dbClient)
    {
      _db = dbClient;
    }

     public ActionResult Index()
    {
      // List<Client> model = _db.Clients.Include(client =>  client.ClientId).ToList();
      // return View(model);
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Add()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Add(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Client currentClient = _db.Clients.FirstOrDefault(Client => Client.ClientId == id);
      return View(currentClient);
    }

  }
}

