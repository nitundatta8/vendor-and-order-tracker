using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;
namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTest
  {
    ls
     [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newCategory = new Vendor("Suzie's Cafe");
      Assert.AreEqual(typeof(Vendor), newCategory.GetType());
    }
  }
}