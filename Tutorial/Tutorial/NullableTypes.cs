using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Nullable là kiểu dữ liệu có thể bằng null
    /// Value Type mặc định không phải kiểu nullable, không hỗ trợ gán = null
    /// Reference Type mặc định là kiểu nullable, hỗ trợ gán = null
    /// </summary>
    class NullableTypes
    {
        public Nullable<int> age;
        public int? name;

        public void caculateAge()
        {
            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine($"age = null");
            }
        }

        // Using null coalescing operator: ??
        // Nếu giá trị biến bằng null nó sẽ lấy giá trị truyền vào, ngược lại lấy chính nó 
        public void getName()
        {
            Console.WriteLine(name ?? -1);
        }

        // Using Null Propagation Operator : [object]?.[field]
        // Kiểm tra xem reference type có null hay không, tránh exception NullPoinException
    }

    //class Test
    //{
    //    static void Main()
    //    {
    //        NullableTypes app = new NullableTypes();
    //        app.name = 10;
    //        app.getName();
    //    }        
    //}
}
