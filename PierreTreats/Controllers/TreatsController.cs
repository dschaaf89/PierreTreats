using Microsoft.AspNetCore.Mvc;
using PierreTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
namespace PierreTreats.Controllers
{
    public class TreatsController : Controller
    {
    private readonly PierreTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public TreatsController(UserManager<ApplicationUser> userManager, PierreTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }
      public ActionResult Index()
    {
      List<Treat> model = _db.Treats.OrderBy(x => x.Name).ToList();
      return View(model);
    }
       //[Authorize(Policy = "RequireAdministratorRole")]
      public ActionResult Create()
    {
      return View();
    }
    //[Authorize(Policy = "RequireAdministratorRole")]
    [HttpPost]
    public async Task<ActionResult> Create(Treat treat)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      treat.User = currentUser;
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    //[Authorize(Policy = "RequireAdministratorRole")]
    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      return View(thisTreat);
    }

    //[Authorize(Policy = "RequireAdministratorRole")]
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
      public ActionResult Details(int id)
    {
        var thisTreat = _db.Treats
        .Include(treat => treat.TreatFlavor)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id); 
        return View(thisTreat);
    }
    //[Authorize(Policy = "RequireAdministratorRole")]
    public ActionResult AddFlavor(int id)
    {
        var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
        ViewBag.AuthorId = new SelectList(_db.Flavors, "FlavorId", "FlavorType");
        return View(thisTreat);
    }

    //[Authorize(Policy = "RequireAdministratorRole")]
    [HttpPost]
    public ActionResult AddFlavor(Treat treat, int FlavorId)
    {
        if (FlavorId != 0)
        {
        _db.TreatFlavors.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    //[Authorize(Policy = "RequireAdministratorRole")]
    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.AuthorId = new SelectList(_db.Flavors, "FlavorId", "FlavorType");
      return View(thisTreat);
    }
    
    //[Authorize(Policy = "RequireAdministratorRole")]
    [HttpPost]
    public ActionResult Edit(Treat treat, int FlavorId)
    {
      if (FlavorId != 0)
      {
        _db.TreatFlavors.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
      }
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


    }
}