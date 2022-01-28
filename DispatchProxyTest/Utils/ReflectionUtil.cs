using DispatchProxyTest.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DispatchProxyTest.Utils
{
    public static class ReflectionUtil
    {
        public static List<T> GetAttributes<T>(MethodInfo methodInfo, Type type, bool inherit = true)
           where T : AttributeBase
        {
            var attributeList = new List<T>();

            attributeList.AddRange(methodInfo.GetCustomAttributes(typeof(T), inherit).Cast<T>());

            attributeList.AddRange(type.GetTypeInfo().GetCustomAttributes(typeof(T), inherit).Cast<T>());

            //interface attributes
            //if (type.GetInterfaces().SelectMany(p => p.GetMethods()).Any(p => p.Name == methodName))
            //{
            //    attributeList.AddRange(type.GetInterfaces().SelectMany(p => p.GetMethod(methodName).GetCustomAttributes(typeof(T), inherit)).Cast<T>());
            //}

            return attributeList;
        }
    }
}
