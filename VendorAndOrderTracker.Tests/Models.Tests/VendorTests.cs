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
      string name1 = "France's Cafe";
      string describtion1 = "Bellevue";
      Vendor newVendor = new Vendor(name, describtion);
      Vendor newVendor1 = new Vendor(name1, describtion1);
      List<Vendor> newList = new List<Vendor>() { newVendor, newVendor1 };
      List<Vendor> result1 = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result1);

    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name = "Suzie's Cafe";
      string describtion = "Bellevue";
      string name1 = "France's Cafe";
      string describtion1 = "Bellevue";
      Vendor newVendor = new Vendor(name, describtion);
      Vendor newVendor1 = new Vendor(name1, describtion1);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor1, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("Bread", "White", 2, "5-22-2020");
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("Suzie's Cafe", "Bellevue");
      newVendor.AddOrders(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);

    }

  }
}