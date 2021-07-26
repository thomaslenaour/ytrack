using System;
using System.Reflection;
using System.Collections.Generic;

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

        public static string ConstructorsList<T>() where T: new() {

            var res = "";

            ConstructorInfo[] p = typeof(T).GetConstructors();

            for (int i = 0; i < p.Length; i++) {
                if (p[i].GetParameters().Length > 0) {
                    var construct = "";
                    for (int j = 0; j < p[i].GetParameters().Length; j++) {
                        construct += " " + p[i].GetParameters()[j].ParameterType.ToString().Split(".")[1];
                    }
                    res += construct;
                }   
                else {
                    res += " No params";
                }

                if (i < p.Length - 1) {
                    res += " |";
                }

            }

            return res;
        }

        public static object GetValueFromInstance(object instance, string property) {

            var propertyName = instance.GetType().GetProperty(property);
            return propertyName.GetValue(instance);
                
        }


    }
}