using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Constructor
    /// </summary>
    class Constructor
    {
        private string _fullName;
        public static string name;

        // Static Constructor
        // Chạy 1 lần, khỏi tạo các biến static
        static Constructor()
        {
            name = "vinhnt";
        }

        // Object Initializer
        // Chạy sau Constructor, dùng để gán (khởi tạo) các biến instance
        public Constructor createInstance() {
            return new Constructor()  {_fullName = "test" };
        }
    }
}
