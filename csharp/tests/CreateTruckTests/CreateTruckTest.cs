using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDiscovery.Quest04;
using System;
using System.Reflection;
using System.Collections.Generic;
using Utils;

namespace tests
{
    [TestClass]
    public class CreateTruckTests
    {

        public static object instance;

        [TestMethod]
        public void CheckInherance()
        {
            Assert.IsTrue(typeof(Truck).IsSubclassOf(typeof(Vehicule)), "Truck is not inheriting from Truck");
        }

        [TestMethod]
        public void CheckConstructors()
        {
            List<List<Type>> Constructors = new List<List<Type>>();
            Constructors.Add(new List<Type>());
            List<Type> ctr2 = new List<Type>();
            ctr2.Add(typeof(int));
            ctr2.Add(typeof(string));
            ctr2.Add(typeof(string));
            ctr2.Add(typeof(int));
            Constructors.Add(ctr2);


            Assert.AreEqual(TestUtils.ConvertToString(Constructors), TestUtils.ConvertToString(TestUtils.ConstructorsList<Truck>()));
        }

        [TestMethod]
        public void CheckNoParamConstructor()
        {
            try
            {
                ConstructorInfo ctor = typeof(Truck).GetConstructor(Type.EmptyTypes);
                instance = ctor.Invoke(new object[] { });
            }
            catch (System.Exception)
            {
                Assert.Fail("Cannot call the constructor with no parameter");
                throw;
            }

            Assert.AreEqual(0, TestUtils.GetValueFromInstance(instance, "Tonnage"), "Values are not affected correctly !");
            Assert.AreEqual("Unknown", TestUtils.GetValueFromInstance(instance, "Brand"), "Values are not affected correctly !");
            Assert.AreEqual("Unknown", TestUtils.GetValueFromInstance(instance, "Color"), "Values are not affected correctly !");
            Assert.AreEqual(0, TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Values are not affected correctly !");
        }

        [TestMethod]
        public void CheckToString1()
        {
            Assert.AreEqual("Unknown Unknown 0T Truck", TestUtils.CallMethod(instance, "ToString"));
        }

        [TestMethod]
        public void Check4ParamsConstructor1()
        {

            try
            {
                ConstructorInfo ctor = typeof(Truck).GetConstructor(new[] {
                    typeof(Int32), typeof(String), typeof(String), typeof(Int32)
            });
                instance = ctor.Invoke(new object[] { 2, "MAC", "White", 80 });
            }
            catch (System.Exception)
            {
                Assert.Fail("Cannot call the constructor with 4 parameters");
                throw;
            }

            Assert.AreEqual(2, TestUtils.GetValueFromInstance(instance, "Tonnage"), "Values are not affected correctly !");
            Assert.AreEqual("MAC", TestUtils.GetValueFromInstance(instance, "Brand"), "Values are not affected correctly !");
            Assert.AreEqual("White", TestUtils.GetValueFromInstance(instance, "Color"), "Values are not affected correctly !");
            Assert.AreEqual(80, TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Values are not affected correctly !");
        }

        [TestMethod]
        public void CheckToString2()
        {
            Assert.AreEqual("White MAC 2T Truck", TestUtils.CallMethod(instance, "ToString"));
        }
        [TestMethod]
        public void Check4ParamsConstructor2()
        {

            try
            {
                ConstructorInfo ctor = typeof(Truck).GetConstructor(new[] {
                    typeof(Int32), typeof(String), typeof(String), typeof(Int32)
            });
                instance = ctor.Invoke(new object[] { 3, "Renault", "Black", 20 });
            }
            catch (System.Exception)
            {
                Assert.Fail("Cannot call the constructor with 4 parameters");
                throw;
            }

            Assert.AreEqual(3, TestUtils.GetValueFromInstance(instance, "Tonnage"), "Values are not affected correctly !");
            Assert.AreEqual("Renault", TestUtils.GetValueFromInstance(instance, "Brand"), "Values are not affected correctly !");
            Assert.AreEqual("Black", TestUtils.GetValueFromInstance(instance, "Color"), "Values are not affected correctly !");
            Assert.AreEqual(20, TestUtils.GetValueFromInstance(instance, "CurrentSpeed"), "Values are not affected correctly !");
        }

        public void CheckToString3()
        {
            Assert.AreEqual("Black Renault 3T Truck", TestUtils.CallMethod(instance, "ToString"));
        }
    }
}