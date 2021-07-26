using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDiscovery.Quest03;
using System;
using System.Reflection;
using Utils;

namespace tests
{
    [TestClass]
    public class SetPropertyTests
    {
        [TestMethod]
        public void CheckProperties()
        {
            Assert.IsTrue(TestUtils.HasProperty<PointOfInterest>("Latitude"), "The latitude property does not exists");
            Assert.IsTrue(TestUtils.HasProperty<PointOfInterest>("Longitude"), "The longitude property does not exists");
            Assert.IsTrue(TestUtils.HasProperty<PointOfInterest>("Name"), "The name property does not exists");

            Assert.IsTrue(TestUtils.TypeOfProperty<PointOfInterest>("Latitude", "Double"),$"Latitude must be a Double, not a {typeof(PointOfInterest).GetProperty("Latitude").PropertyType.Name}");
            Assert.IsTrue(TestUtils.TypeOfProperty<PointOfInterest>("Longitude", "Double"),$"Longitude must be a Double, not a {typeof(PointOfInterest).GetProperty("Latitude").PropertyType.Name}");
            Assert.IsTrue(TestUtils.TypeOfProperty<PointOfInterest>("Name", "String"),$"Name must be a String, not a {typeof(PointOfInterest).GetProperty("Latitude").PropertyType.Name}");
        }
        [TestMethod]
        public void CheckGoogleMapUrl() {
            Assert.AreEqual(PointOfInterest.GoogleMapsUrlTemplate, "https://www.google.com/maps/place/{0}/@{1},{2},15z/", "The value of the property GoogleMapsUrlTemplate is incorrect");
        }
    }
}
