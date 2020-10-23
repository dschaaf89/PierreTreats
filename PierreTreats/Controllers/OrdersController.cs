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
using System;
namespace PierreTreats.Controllers
{
   
        [Authorize]
  public class OrdersController : Controller
  {
    private readonly PierreTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public OrdersController(UserManager<ApplicationUser> userManager, PierreTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    
    public async Task<ActionResult> Index() 
    {
      // System.Console.WriteLine("test"); 
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userOrders = _db.Orders.Where(entry => entry.User.Id == currentUser.Id)
        .Include(x => x.Stock)
        .ThenInclude(x => x.Treat)
        .ToList();
      
      return View(userOrders);
    }
    // public async Task<ActionResult> CheckOutBooks() 
    // {
    //   // System.Console.WriteLine("test"); 
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   var userCheckouts = _db.Checkouts.Where(entry => entry.PatronId == currentUser.Id).ToList();
      
    //   return View(userCheckouts);
    // }
    
    public async Task<ActionResult> Order(int id) //id book
    {
      // System.Console.WriteLine("test"); 
      
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      // var userCheckouts = _db.Checkouts.Where(entry => entry.PatronId == currentUser.Id).ToList();
      var treatsInStock = _db.Stock.Where(x => x.TreatId == id).Where(x => x.InStock == true).ToList();
      if(treatsInStock.Count != 0)
      {
        Order newOrder = new Order(){StockId = treatsInStock[0].StockId};
        treatsInStock[0].InStock = false;
        newOrder.User = currentUser;
        _db.Orders.Add(newOrder);
        _db.SaveChanges();
      }
      
      
      return RedirectToAction("Index");
    }
    }
}
