using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

      [TestMethod]
      public void Sphere_DetereminesSphereVolume_SphereVolume()
      {
          Sphere mySphere = new Sphere(2);
          double result2 = mySphere.getVolume(2);
          Assert.AreEqual(result2, 33.5);
      }

  }
}