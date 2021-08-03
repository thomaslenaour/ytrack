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
        public void CheckInherance()
        {
            Assert.IsTrue(typeof(Car).IsSubclassOf(typeof(Vehicule)), "Car is not inheriting from Vehicule");
        }

        [TestMethod]
        public void CheckConstructors()
        {
            List<List<Type>> Constructors = new List<List<Type>>();
            Constructors.Add(new List<Type>());
            List<Type> ctr2 = new List<Type>();
            ctr2.Add(typeof(string));
            ctr2.Add(typeof(string));
            ctr2.Add(typeof(string));
            ctr2.Add(typeof(int));
            Constructors.Add(ctr2);


            Assert.AreEqual(TestUtils.ConvertToString(Constructors), TestUtils.ConvertToString(TestUtils.ConstructorsList<Car>()));
        }

        [TestMethod]
        public void CheckNoParamConstructor()
        {
            try
            {
                ConstructorInfo ctor = typeof(Car).GetConstructor(Type.EmptyTypes);
                instance = ctor.Invoke(new object[] { });
            }
            catch (System.Exception)
            {
                Assert.Fail("Cannot call the constructor with no parameter");
                throw;
            }

            Assert.AreEqual("Unknown", TestUtils.GetValueFromInstance(instance, "Model"), "Values are not affected correctly !");
            Assert.AreEqual("Unknown", TestUtils.GetValueFromInstance(instance, "Brand"), "Values are not affected correctly !");
            Assert.AreEqual("Unknown", TestUtils.GetValueFromInstance(instance, "Color"), "Values are not affected correctly !");
            Assert.AreEqual(0, TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Values are not affected correctly !");
        }

        [TestMethod]
        public void CheckConstructor()
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


        }

        [TestMethod]
        public void CheckMethodsExist()
        {
            Assert.IsTrue(TestUtils.HasMethod<Car>("Accelerate", typeof(void)), "Accelerate not found");
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

            Assert.AreEqual(150, TestUtils.CallMethod(instance, "Accelerate", new object[] { System.Int32 }));
            // Assert.AreEqual(180, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Accelerate"), "Value is not equal to 180 Km/h or you are going too fast !");
            // Assert.AreEqual(20, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Brake"), "Value is not equal to 20 Km/h !");
            // Assert.AreEqual(0, TestUtils.CallMethod(TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Brake"), "Value is not equal to 0 Km/h or you are going at a negative speed !");
        }
    }
}