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
      Assert.AreEqual("Equilateral", testTriangle.TriangleType(3, 3, 3));
    }
    
    [TestMethod]
    public void TriangleType_TwoSidesEqual_Isosceles()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles", testTriangle.TriangleType(2, 2, 3));
    }

    [TestMethod]
    public void TriangleType_NoSidesEqual_Scalene()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.TriangleType(1, 2, 3));
    }
    
    [TestMethod]
    public void TriangleType_SumOfTwoSidesLessThanThirdSide_Invalid()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Invalid triangle!", testTriangle.TriangleType(2, 3, 12));
    }
  }
}