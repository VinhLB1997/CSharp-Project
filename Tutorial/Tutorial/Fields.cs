using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Các loại biến hay gặp trong c#
    /// </summary>
    class Fields
    {
        // Instance field
        // Biến gắn với mỗi instance(object) cụ thể được tạo ra
        // Có giá trị mặc định theo từng kiểu dữ liệu: 0, null, ...
        public string fullName;
        private int _age;

        // Static field
        // Biến gắn với Class, sử dụng chung cho tất cả các instance(object) được tạo ra
        public static string StaticVariable;

        // Constant field
        // const luôn luôn là static
        // Biến hằng, phải được gán gái trị trước khi instance(object) được tạo ra
        // Không thể thay đổi giá trị khi sử dụng
        public const string ConstantVariable = "INIT_CONST";

        // ReadOnly field
        //Biến chỉ đọc, chỉ được gán giá trị một lần
        public readonly string variableReadOnly;
    }
}
