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
            Assert.IsTrue(TestUtils.HasMethod<Car>("Accelerate", new Type[] { typeof(int) }), "Method Accelerate not found");
            Assert.IsTrue(TestUtils.HasMethod<Car>("Brake", new Type[] { typeof(int) }), "Method Brake not found");
        }

        [TestMethod]
        public void CheckForSpeed()
        {
            try
            {
                ConstructorInfo ctor = typeof(Car).GetConstructor(new[] {
                    typeof(String), typeof(String), typeof(String), typeof(Int32)
            });
                instance = ctor.Invoke(new object[] { "Mégane", "Renault", "Yellow", 50 });
            }
            catch (System.Exception)
            {
                Assert.Fail("Cannot call the constructor with 4 parameters");
                throw;
            }

            TestUtils.CallMethod(instance, "Accelerate", new object[] { instance[0] = 50 });
            Assert.AreEqual(150, TestUtils.GetValueFromInstance(instance, "CurrentSpeed"));
            // Assert.AreEqual(180, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Accelerate"), "Value is not equal to 180 Km/h or you are going too fast !");
            // Assert.AreEqual(20, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Brake"), "Value is not equal to 20 Km/h !");
            // Assert.AreEqual(0, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Brake"), "Value is not equal to 0 Km/h or you are going at a negative speed !");
        }
    }
}