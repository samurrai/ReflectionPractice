using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type stringType = typeof(string);
            //foreach (var element in stringType.GetMembers())
            //{
            //    if (element is MethodInfo)
            //    {
            //        if (element.Name == "Substring")
            //        {
            //            string tmp = "Hello World";
            //            var method = element as MethodInfo;
            //            if(method.GetParameters().Length == 1)
            //            {
            //                Console.WriteLine(method.Invoke(tmp, new object[] { 6 }));
            //            }
            //            else
            //            {
            //                Console.WriteLine(method.Invoke(tmp, new object[] { 6, tmp.Length - 6 }));
            //            }
            //        }
            //    }
            //}

            Type listType = typeof(List<>);
            foreach (var element in listType.GetMembers())
            {
                if (element is ConstructorInfo)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
