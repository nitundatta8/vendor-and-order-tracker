using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendor = Vendor.GetAll();
      return View(allVendor);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}