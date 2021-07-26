using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDiscovery.Quest03;
using System;
using System.Reflection;
using System.Collections.Generic;
using Utils;

namespace tests
{
    [TestClass]
    public class GetGoogleMapsUrlTests
    {
        public static List<object> Instances = new List<object>();


        [TestMethod]
        public void GenerateInstances()
        {
            try
            {
                Type type = typeof(PointOfInterest);
                ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);
                Instances.Add(ctor.Invoke(new object[] {}));

                type = typeof(PointOfInterest);
                ctor = type.GetConstructor(new[] {
                    typeof(String), typeof(Double), typeof(Double)
                });
                Instances.Add(ctor.Invoke(new object[] {"Paris Ynov Campus", 48.9016552, 2.2079985}));
                Instances.Add(ctor.Invoke(new object[] { "Random Point", 3, 2 }));
            }
            catch (System.Exception)
            {
                Assert.Fail("Error creating the instances, check your constructors");
                throw;
            }
        }

        [TestMethod]
        public void MethodExists() {
            Assert.IsTrue(TestUtils.HasMethod<PointOfInterest>("GetGoogleMapsUrl", "String"), "Error finding the method GetGoogleMapsUrl, check the name, the parameters and the return value");
        }

        [TestMethod]
        public void CallMethod() {

            Assert.AreEqual("https://www.google.com/maps/place/Bordeaux+Ynov+Campus/@44.854186,-0.5663056,15z/", TestUtils.CallMethod(Instances[0], "GetGoogleMapsUrl"));
            Assert.AreEqual("https://www.google.com/maps/place/Paris+Ynov+Campus/@48.9016552,2.2079985,15z/", TestUtils.CallMethod(Instances[1], "GetGoogleMapsUrl"));
            Assert.AreEqual("https://www.google.com/maps/place/Random+Point/@3,2,15z/", TestUtils.CallMethod(Instances[2], "GetGoogleMapsUrl"));
        }
    }
}