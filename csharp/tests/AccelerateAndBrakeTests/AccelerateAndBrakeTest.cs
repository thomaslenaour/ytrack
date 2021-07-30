using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDiscovery.Quest04;
using System;
using System.Reflection;
using System.Collections.Generic;
using Utils;

namespace tests
{
    [TestClass]
    public class AccelerateAndBrakeTests
    {
        public static object instance;

        [TestMethod]
        public void CheckMethodsExist()
        {
            Assert.IsTrue(TestUtils.HasMethod<Car>("Accelerate", typeof(void)), "Error finding the method Accelerate");
            Assert.IsTrue(TestUtils.HasMethod<Car>("Brake", typeof(void)), "Error finding the method Brake");
        }

        [TestMethod]
        public void CheckForSpeed()
        {

            Assert.AreEqual(150, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Accelerate"), "Value is not equal to 150 Km/h !");
            Assert.AreEqual(180, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Accelerate"), "Value is not equal to 180 Km/h or you are going too fast !");
            Assert.AreEqual(20, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Brake"), "Value is not equal to 20 Km/h !");
            Assert.AreEqual(0, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Brake"), "Value is not equal to 0 Km/h or you are going at a negative speed !");
        }
    }
}