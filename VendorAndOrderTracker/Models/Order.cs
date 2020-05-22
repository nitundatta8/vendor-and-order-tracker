using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string OrderDescription { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _orderList = new List<Order>() { };

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      OrderDescription = description;
      Price = price;
      Date = date;
      _orderList.Add(this);
      Id = _orderList.Count;
    }
    public static void ClearAll()
    {
      _orderList.Clear();
    }
    public static List<Order> GetAllOrder()
    {
      return _orderList;
    }
    public static Order Find(int searchId)
    {
      return _orderList[searchId - 1];
    }

  }


}