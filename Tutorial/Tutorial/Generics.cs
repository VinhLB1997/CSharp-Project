using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Generic
    /// </summary>
    /// 

    // Generic classes
    class GenericsCLasses<T>
    {
        public T fieldInstance;
    }

    // Generic constraints
    // Using keyword `where` để giới hạn phạm vi của kiểu
    class GenericsTypeLimit<T> where T : class { }

    // Generic Method
    class GenericUtil
    {
        public void printData<T> (T obj)
        {
            if(obj.GetType() == typeof(String))
            {
                String temp = obj as String;
                Console.WriteLine(temp);
            } else if(obj.GetType() == typeof(string[]))
            {
                string[] temp = obj as string[];
                if (temp.Length >= 0) {
                    foreach (var item in temp) {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }

    //class Test { 
    //   static void Main()
    //    {
    //        GenericUtil test = new GenericUtil();
    //        test.printData<string[]>(new string[] { "Vinh1","Vinh2","Vinh3"});
    //    }
    //}
}
