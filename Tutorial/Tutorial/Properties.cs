using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Properties
    /// </summary>

    // Theory
    // Properties là composite member của class, có 2 accessor là set, get
    // Mục đích chính là để validate value trước khi gán cho instance variable, tạo ra để bảo vệ dữ liệu các field instance
    // Có thể thêm logic xác thực dữ liệu gán cho instance field thông qua set accessor
    // Sử dụng cho các private instance variable như getter, setter trong java
    // Là một phần của lớp giống method, không được phân bổ bộ nhớ
    // Nên tạo Properties cho tất cả các field instance trong class
    class Properties
    {
        // instance Field
        private string _name;

        //instance Property
        public string Name
        {
            set
            {
                // Thêm Logic xác thực dữ liệu trước khi gán giá trị
                // Nếu giá trị được gán không thỏa mãn, field sẽ không thay đổi
                if (!string.IsNullOrEmpty(_name))
                    _name = value;
            }

            get
            {
                return _name;
            }
        }

        // Auto implement Property
        public string AutoProperty { get; set; } = "default";

        // static field
        private static string _nameStatic;

        //static Property
        public static string NameStatic
        {
            set
            {
                // Thêm Logic xác thực dữ liệu trước khi gán giá trị
                // Nếu giá trị được gán không thỏa mãn, field sẽ không thay đổi
                if (!string.IsNullOrEmpty(_nameStatic))
                    _nameStatic = value;
            }

            get
            {
                return _nameStatic;
            }
        }
    }
}
