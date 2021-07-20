using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDiscovery.Quest03;
using System;
using System.Reflection;

namespace tests
{
    [TestClass]
    public class SetPropertyTests
    {
        [TestMethod]
        public void CheckProperties()
        {
            var poi = new PointOfInterest();
            Assert.IsNotNull(poi.GetType().GetProperty("Latitude"), "The latitude property does not exists");
            Assert.IsNotNull(poi.GetType().GetProperty("Longitude"), "The longitude property does not exists");
            Assert.IsNotNull(poi.GetType().GetProperty("Name"), "The name property does not exists");

            Assert.AreEqual(typeof(PointOfInterest).GetProperty("Latitude").PropertyType.Name, "Double", $"Longitude must be a Double, not a {typeof(PointOfInterest).GetProperty("Latitude").PropertyType.Name}");
            Assert.AreEqual(typeof(PointOfInterest).GetProperty("Longitude").PropertyType.Name, "Double", $"Latitude must be a Double, not a {typeof(PointOfInterest).GetProperty("Longitude").PropertyType.Name}");
            Assert.AreEqual(typeof(PointOfInterest).GetProperty("Name").PropertyType.Name, "String", $"Name must be a String, not a {typeof(PointOfInterest).GetProperty("Name").PropertyType.Name}");

            
        }
        [TestMethod]
        public void CheckGoogleMapUrl() {
            Assert.AreEqual(PointOfInterest.GoogleMapsUrlTemplate, "https://www.google.com/maps/place/{0}/@{1},{2},15z/", "The value of the property GoogleMapsUrlTemplate is incorrect");
        }
    }
}
