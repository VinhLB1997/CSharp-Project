using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Enumeration là tập hợp các constants
    /// Gần giống enum trong java
    /// </summary>
    

    // Mặc định, mỗi 1 constant sẽ được gán index như array bắt đầu từ 0
    // Có th khởi tạo lại giá trị như biến
    enum Enumeration
    {
       Child,
       Teenager = 10,
       Adult
    }
}
