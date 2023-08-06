using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Các phím shortcut thông dụng
    /// </summary>
    class ShortcutIDE
    {
        /// <summary>
        /// Tip and trick
        /// </summary>
        /// 

        // C# Interactive tool : thực hiện một số đoạn code nhỏ
        public const string OPEN_INTERACTIVE_TOOL = "View -> Other Windows -> C# Interactive";

        /// <summary>
        /// Shortcut
        /// </summary>
        
        // Format Document
        public const string FORMAT_DOCUMENT = "Ctrl + K + D";
        // Format selection
        public const string FORMAT_DOCUMENT_SELECTION = "Ctrl + K + F";
        // Duplicate line code focusing
        public const string DUPLICATE_LINE_CODE_FORCUS = "Ctrl + D";
        // Create file .cs
        public const string CREATE_FILE = "Ctrl + Shift + A";
    }
}
