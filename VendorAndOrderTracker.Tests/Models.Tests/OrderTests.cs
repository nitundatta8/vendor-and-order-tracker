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
      Order newOrder = new Order("Bread", "White", 2, "5-22-2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetProperty_ReturnsProperty_Property()
    {
      String title = "Bread";
      string description = "white";
      int price = 2;
      string date = "5-22-2020";
      Order order = new Order(title, description, price, date);
      string resultTitle = order.Title;
      string resultDes = order.OrderDescription;
      int resultPrice = order.Price;
      string resultDate = order.Date;
      Assert.AreEqual("title", resultTitle);
      Assert.AreEqual("description", resultDes);
      Assert.AreEqual(1, resultPrice);
      Assert.AreEqual("date", resultDate);
    }
  }
}