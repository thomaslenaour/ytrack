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

        public static bool HasMethod<T>(string MethodName, string returnType = "void", string parameters = "No params") where T: new() {

            MethodInfo method = typeof(T).GetMethod(MethodName);
            List<string> methodParameters = new List<string>();


            if (method != null) {
                if (method.GetParameters().Length > 0) {
                    for (int j = 0; j < method.GetParameters().Length; j++) {
                        methodParameters.Add(RemoveNamespaceFromType(method.GetParameters()[j].ParameterType.ToString()));
                    }
                    
                    return parameters == String.Join(" ", methodParameters.ToArray());
                }   
                else {
                    return parameters == "No params";
                }
            } else {
                return false;
            }
        }

        public static bool TypeOfProperty<T>(string property, string type) where T: new() {
            return typeof(T).GetProperty(property).PropertyType.Name == type;
        }

        public static string ConstructorsList<T>() where T: new() {

            var res = "";

            ConstructorInfo[] p = typeof(T).GetConstructors();

            for (int i = 0; i < p.Length; i++) {
                if (p[i].GetParameters().Length > 0) {
                    var construct = "";
                    for (int j = 0; j < p[i].GetParameters().Length; j++) {
                        construct += " " + RemoveNamespaceFromType(p[i].GetParameters()[j].ParameterType.ToString());
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

        public static object CallMethod(object instance, string MethodName, object[] parameters = null) {
            var method = instance.GetType().GetMethod(MethodName);
            return method.Invoke(instance, parameters);
        }

        public static string RemoveNamespaceFromType(string type) {
            return type.Split(".")[type.Split(".").Length - 1];
        }
    }
}