using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Structure gần giống class
    /// Nó thường dùng lưu trữ dữ liệu gồm 1 -> 2 field
    /// Nó lưu trong stack memory nên nhanh hơn class
    /// Không thể kế thừa,... có nhiều điểm hạn chế hơn class
    /// Tất cả các primitive type đều là structures
    /// </summary>
    struct Structure
    {
        // Field of struct
        private string _name;

        // Property of struct
        public string Name { get; set; }

        // Method of struct
        public void printName() {
            Console.WriteLine(this._name);
        }

    }
}
