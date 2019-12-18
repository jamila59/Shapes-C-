using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

      [TestMethod]
      public void Cicle_GetDiameter_DiameterOfCicle()
      {
          Circle myCicle = new Circle(2,4,12.56);
          double result = myCicle.getDiameter(2);
          Assert.AreEqual(result, 4);
      }

    //   [TestMethod]
    //   public void Cicle_GetDiameter_DiameterOfCicle()
    //   {
    //       Circle myCicle = new Circle(2,4,12.56);
    //       double result = myCicle.getDiameter(2);
    //       Assert.AreEqual(result, 4);
    //   }
  }
}