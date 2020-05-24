using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor>() { };
    public int Id { get; }

    public List<Order> Orders;
    public Vendor(string name, string description)
    {
      VendorName = name;
      Description = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order>();

    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }
    public static Vendor Find(int searchId)
    {
      return _vendorList[searchId - 1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}