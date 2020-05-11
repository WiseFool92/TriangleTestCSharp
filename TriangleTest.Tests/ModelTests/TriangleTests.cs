using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTest;

namespace TriangleTest.TestTools
{
  [TestClass]
  public class TriangleTypeTest
  {
    [TestMethod]
    public void TriangleType_ThreeSidesEqual_Equilateral()
    {
      Triangle testTriangle = new Triangle();
      // logic to prep for the test : instantiante a new class
      Assert.AreEqual("Equilateral", testTriangle.TriangleType(3, 3, 3));
    }
  }
}