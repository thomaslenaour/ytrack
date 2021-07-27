using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public class TestUtils
    {
        public static bool HasProperty<T>(string property) where T: new() {
            return typeof(T).GetProperty(property) != null;
        }

        public static bool HasMethod<T>(string MethodName, Type ReturnType, Type[] parameters, bool IsStatic = false) where T: new() {
            MethodInfo method = typeof(T).GetMethod(MethodName, IsStatic ? BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy : BindingFlags.Public | BindingFlags.Instance, null, CallingConventions.Any, parameters, null);
            return method != null ? method.ReturnType == ReturnType : false;
        }
        public static bool HasMethod<T>(string MethodName, Type ReturnType, bool IsStatic = false) where T: new() {
            return HasMethod<T>(MethodName, ReturnType, new Type[] {}, IsStatic);
        }
        public static bool HasMethod<T>(string MethodName, Type[] parameters, bool IsStatic = false) where T: new() {
            return HasMethod<T>(MethodName, typeof(void), parameters, IsStatic);
        }


        public static bool TypeOfProperty<T>(string property, string type) where T: new() {
            return typeof(T).GetProperty(property).PropertyType.Name == type;
        }

        public static List<List<Type>> ConstructorsList<T>() where T: new() {

            List<List<Type>> AllConstructors = new List<List<Type>>();
            ConstructorInfo[] p = typeof(T).GetConstructors();

            for (int i = 0; i < p.Length; i++) {
                if (p[i].GetParameters().Length > 0) {
                    var constructor = new List<Type>();
                    for (int j = 0; j < p[i].GetParameters().Length; j++) {
                        constructor.Add(p[i].GetParameters()[j].ParameterType);
                    }
                    AllConstructors.Add(constructor);
                }   
                else {
                    AllConstructors.Add(new List<Type>());
                }
            }
            return AllConstructors;
        }

        public static object GetValueFromInstance(object instance, string property) {

            var propertyName = instance.GetType().GetProperty(property);
            return propertyName.GetValue(instance);
                
        }

        public static object CallMethod(object instance, string MethodName, object[] parameters = null) {
            var method = instance.GetType().GetMethod(MethodName, BindingFlags.Public | BindingFlags.Instance);
            return method.Invoke(instance, parameters);
        }

        public static object CallStaticMethod<T>(string MethodName, object[] parameters = null) where T: new() {
            var method = typeof(T).GetMethod(MethodName, BindingFlags.Public | BindingFlags.Static);
            return method.Invoke(null, parameters);
        }

        public static string ConvertToString(List<List<Type>> NestedList) {
            var res = "";
            for (var i = 0; i < NestedList.Count; i++) {
                res += i + ": { ";
                for (var j = 0; j < NestedList[i].Count; j++) {

                    res += NestedList[i][j].ToString() + " ";
                }
                res += "} ";
            }
            return res;
        }
    }
}