using System;
using System.Reflection;

namespace Utils
{
    public class TestUtils
    {
        public static bool HasProperty<T>(string property) where T: new() {
            var instance = new T();
            return instance.GetType().GetProperty(property) != null;
        }

        public static bool TypeOfProperty<T>(string property, string type) where T: new() {
            var instance = new T();
            return typeof(T).GetProperty(property).PropertyType.Name == type;
        }

        public static void IsStatic<T>(string property) where T: new() {
            Console.WriteLine(typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Length);
        }
    }
}