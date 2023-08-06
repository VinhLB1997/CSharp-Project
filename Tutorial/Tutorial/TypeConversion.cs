using System;

namespace Tutorial
{
    /// <summary>
    /// Các kiểu chuyển đổi loại
    /// string -> int,...
    /// </summary>
    class TypeConversion
    {
        // Implicit Casting: Chuyển đổi kiểu ngầm định
        // Chuyển đổi tù kiểu có phạm vi hẹp sang kiểu có phạm vi rộng hơn
        // Không làm mất dữ liệu
        public void ImplicitCasting()
        {
            int source = 10;
            double target = source;
        }

        // Explicit Casting: Chuyển đổi kiểu tường minh
        // Chuyển đổi tù kiểu có phạm vi rộng sang kiểu có phạm vi hẹp hơn
        // Có thể làm mất dữ liệu
        public void ExplicitCasting()
        {
            double source = 10;
            int target = (int)source;
        }

        // Using method Parse
        // Chuyển đổi tù string -> int, float, double
        // Ném ra Exception nếu string không có format number hợp lệ
        public void ParseMethodCasting()
        {
            string source = "123";
            try
            {
                float target = float.Parse(source);
            }
            catch (FormatException)
            {
                Console.WriteLine("Number invalid fomat!");
            }
        }

        // Using method TryParse
        // Chuyển đổi tù string -> int, float, double
        // Không ném Exception nếu string format number không hợp lệ mà trả lại giá trị bool đồng thời gán 0 vào biến out
        public void TryParseMethodCasting()
        {
            string source = "123";
            bool target = float.TryParse(source, out float result);
        }

        // Conversion Method
        // Chuyển đổi từ string -> int, float, double
        public void ConversionMethodCasting()
        {
            // Convert int -> string
            System.Convert.ToString(1);
            // Convert date time
            System.Convert.ToDateTime(DateTime.Now);
            // Convert string -> int
            System.Convert.ToInt32("123");
            // Convert byte[] to base64
            System.Convert.ToBase64String(new byte[] { });
        }
    }
}
