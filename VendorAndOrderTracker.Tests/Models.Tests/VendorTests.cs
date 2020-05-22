using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;
namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newCategory = new Vendor("Suzie's Cafe", "Bellevue");
      Assert.AreEqual(typeof(Vendor), newCategory.GetType());
    }
    [TestMethod]
    public void GetNameDescribtion_ReturnsNameDescribtion_String()
    {
      string name = "Suzie's Cafe";
      string describtion = "Bellevue";
      Vendor newVendor = new Vendor(name, describtion);
      string result = newVendor.VendorName;
      string result1 = newVendor.Description;
      Assert.AreEqual(name, result);
      Assert.AreEqual(describtion, result1);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Suzie's Cafe";
      string describtion = "Bellevue";
      Vendor newVendor = new Vendor(name, describtion);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name = "Suzie's Cafe";
      string describtion = "Bellevue";
      Vendor newVendor = new Vendor(name, describtion);
      string name1 = "France's Cafe";
      string describtion1 = "Bellevue";
      Vendor newVendor1 = new Vendor(name1, describtion1);
      List<Vendor> list = new List<Vendor>() { newVendor, newVendor1 };
      List<Vendor> result = Vendor.GetAll();
      Assert.AreEqual(list, result);

    }

  }
}