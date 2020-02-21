using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace CalendarTests
{
  [TestClass]
  public class LeapYearTests
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      
      Assert.AreEqual(true, LeapYear.IsLeapYear(2012));
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisiblebyFourHundred_True()
    {
      Assert.AreEqual(true, LeapYear.IsLeapYear(2000));
    }

    [TestMethod]
    public void IsLeapYear_NumberDivisiblebyOneHundred_False()
    {
      Assert.AreEqual(false, LeapYear.IsLeapYear(1900));
    }

  }
}