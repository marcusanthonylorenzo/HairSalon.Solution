using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Add()
    {
      return View();
    }

    //instantiate new stylist, auto increments Id, adds to _db
    [HttpPost]
    public ActionResult Add(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Stylist currentStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(currentStylist);
    }

    public ActionResult AddClient()
    {
      return RedirectToAction("Add", "Clients");
    }
  }
}