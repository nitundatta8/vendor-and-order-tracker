using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;
namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread", "White", "5-22-2020");
      Assert.AreEqual(typeof(Vendor), newOrder.GetType());
    }
  }
}