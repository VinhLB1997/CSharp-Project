using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Extention method là cách thêm method vào trong một class hiện có mà không cần phải thay đổi source code của class đó
    /// </summary>
    /// 
    class Origin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    static class ExtentionMethod
    {
        // Method GetFullName() sẽ trở thành method instance của class Origin
        // Không truy cập được những thành viên private trong class Origin
        // Khi trong class Origin đã có sẵn method cùng tên với extention method thì độ ưu tiên của instance method là cao hơn
        public static string GetFullName(this Origin origin)
        {
            return origin.LastName + " " + origin.FirstName;
        }

        // Extention method có thể overloading
        // Tham số `this Origin origin` là bắt buộc, các tham số đằng sau là mở rộng
        public static string GetFullName(this Origin origin, string mode)
        {
            return origin.LastName + " " + origin.FirstName + " " + mode;
        }

        //static void Main()
        //{
        //    Origin test = new Origin();
        //    test.FirstName = "vinh";
        //   Console.WriteLine(test.GetFullName());
        //}
    }

}
