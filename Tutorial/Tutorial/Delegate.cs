using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Delegate là một loại tham chiếu ủy quyền
    /// Mục đích là tham chiếu đến một method nào đó
    /// Delegate được khai báo như một biến trong class, trong namespace
    /// Có thể ủy quyền cho nó một hoặc nhiều method sao cho kiểu trả về và param của nó giống với method được reference tới
    /// Nó có thể đóng vai trò là param gọi là callback
    /// Khi delegate được gọi, tất cả các method được ủy quyền sẽ chạy tuần tự 
    /// </summary>

    // Delegate ref single method
    delegate void DelegateNotify(string slogan);

    // Delegate ref multil method
    // Lưu ý khi sử dụng Delegate cho mutil method thì các method được ref sẽ cùng thực hiện
    // Nên sử dụng với các method không trả về giá trị, các method cùng tham số, cùng kiểu trả về
    delegate int DelegateMath(int number1, int number2);

    class Delegate
    {
        public static void SendNotify(string notify)
        {
            Console.WriteLine(notify);
        }

        public static int Sum(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
            return 0;
        }

        public static int Minus(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
            return 0;
        }

        //static void Main() {
        //    // Delegate single method
        //    DelegateNotify notify = new DelegateNotify(SendNotify);
        //    notify("Hello");
        //    // Delegate multi-cast
        //    DelegateMath notifyMul = null;
        //    notifyMul += Sum;
        //    notifyMul += Minus;
        //    notifyMul(10,20);
        //}
    }
}
