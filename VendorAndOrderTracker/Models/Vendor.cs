using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor>() { };
    public int Id { get; }
    public Vendor(string name, string description)
    {
      VendorName = name;
      Description = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }
  }
}