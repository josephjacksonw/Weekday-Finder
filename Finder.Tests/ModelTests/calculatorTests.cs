using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculator.Models;

namespace Calculator.Models.Tests
{
  [TestClass]
  public class VoodooTest
  {
    [TestMethod]
    public void findDay_FindDayOfWeek_True()
    {
			Voodoo testVar = new Voodoo();
			Assert.AreEqual("Tuesday", testVar.findDay(1, 1, 3033));
    }
  }
}
