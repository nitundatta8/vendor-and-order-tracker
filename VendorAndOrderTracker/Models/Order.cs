using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string OrderDescription { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      OrderDescription = description;
      Price = price;
      Date = date;
    }
  }


}