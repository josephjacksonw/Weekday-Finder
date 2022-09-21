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
			Assert.AreEqual("Friday", testVar.findDay(11, 22, 1963));
    }
  }
}
