using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Indexers dùng để truy cập nhanh vào phần tử mảng của field instance type array có trong class
    /// Ít được sử dụng
    /// </summary>


    // Luôn luôn tạo Indexer với từ khóa this
    // Nó không thể là static
    // Có thể Overload bằng các Indexer khác tham số
    class Indexers
    {
        // Field instance type arrays
        private string[] _nameArray = new string[] { "Name 1", "Name 2", "Name 3" };
        private string[] _ageArray = new string[] { "20", "21", "22" };

        // Indexer
        public string this[int nameArrayIndex]
        {
            set
            {
                this._nameArray[nameArrayIndex] = value;
            }

            get
            {
                return _nameArray[nameArrayIndex];
            }
        }

        // Overloading Indexer
        public string this[string nameArrayIndex]
        {
            set
            {
                this._ageArray[Array.IndexOf(_nameArray, nameArrayIndex)] = value;
            }

            get
            {
                return _ageArray[Array.IndexOf(_nameArray, nameArrayIndex)];
            }
        }
    }
}
