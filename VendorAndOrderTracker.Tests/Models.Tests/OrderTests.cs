using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;
namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDes);
      Assert.AreEqual(2, resultPrice);
      Assert.AreEqual(date, resultDate);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Order newOrder = new Order("Bread", "White", 2, "5-22-2020");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OredrList()
    {
      Order newOrder = new Order("Bread", "White", 2, "5-22-2020");
      Order newOrder1 = new Order("Pastry", "Croissants ", 3, "5-22-2020");
      List<Order> list = new List<Order> { newOrder, newOrder1 };
      List<Order> result = Order.GetAllOrder();
      CollectionAssert.AreEqual(list, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder = new Order("Bread", "White", 2, "5-22-2020");
      Order newOrder1 = new Order("Pastry", "Croissants ", 3, "5-22-2020");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder1, result);
    }
  }
}