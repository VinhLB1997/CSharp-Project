using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Các vấn đề liên quan đến method, paramater, argument trong c#
    /// </summary>
    class Methods
    {

        public int process = 1;

        /// <summary>
        /// Using: như các method bình thường
        /// </summary>
        // Object Reference Arguments
        // Lưu ý các thay đổi về mặt giá trị đối với các tham số là object reference (instance) sẽ ảnh hưởng trực tiếp đến các instance đó
        public void ObjectReferenceArguments(Methods methodRef)
        {
            methodRef.process = 2;
            Console.WriteLine($"Method [ process = {this.process} ]");
            Console.WriteLine($"MethodRef [ process = {methodRef.process} ]");
        }

        /// <summary>
        /// Using: [object].DefaultArguments(address: "Bac Ninh");
        /// </summary>
        // Default Arguments
        // Lưu ý các param có giá trị default phải đặt sau tất cả các param khác 
        public void DefaultArguments(string address, int age = 20, string name = "vinhnt")
        {
            Console.WriteLine($"Name = {name} , age = {age}, address = {address}");
        }

        /// <summary>
        /// Using: [object].NamedArguments(address: "Bac Ninh", age: 14, name: "vinhnt");
        /// </summary>
        // Named Arguments
        // Có thể truyền đối số cho paramater mà không cần theo đúng thứ tự
        // Lưu ý các param có giá trị default phải đặt sau tất cả các param khác 
        public void NamedArguments(int age, string address, string name = "vinhnt")
        {
            Console.WriteLine($"Name = {name} , age = {age}, address = {address}");
        }

        /// <summary>
        /// Using: [object].ParameterModifierRef(ref [variable]);
        /// </summary>
        // Prameter Modifier Ref
        // Argument khi truyền vào phải được khởi tạo trước
        // Mọi sự thay đổi trên biến ref sẽ thay đổi ở argument truyền vào
        public void ParameterModifierRef(ref int age)
        {
            age = 20;
            Console.WriteLine($"Age = {age}");
        }

        /// <summary>
        /// Using: [object].ParameterModifierOut(out [variable]);
        /// </summary>
        // Prameter Modifier Out
        // Prameter out phải được gán giá trị trong method
        public double ParameterModifierOut(out double age)
        {
            age = 10f;
            return Math.Pow(age, 3f);
        }

        /// <summary>
        /// Using: [object].ParameterModifierIn(in [variable]);
        /// </summary>
        // Prameter Modifier In
        // Argument tương ứng phải khỏi tạo trước khi truyền vào
        // Prameter in chỉ read-only, không thể gán giá trị trong method
        public double ParameterModifierIn(in double age)
        {
            return Math.Pow(age, 3f);
        }

        /// <summary>
        /// Using: [object].ParameterModifierParams(string[] arrs);
        /// Ex   : test.ParameterModifierParams("1", "2", "3");
        /// </summary>
        // Prameter Modifier `params`
        // Argument là một mảng tương ứng kiểu params
        public void ParameterModifierParams(params string[] arrName)
        {
            foreach (var name in arrName)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Using: ref [object].ReturnRefVariableProcess();
        /// Ex   : Methods test = new Methods();
        ///        ref int processRef = ref test.ReturnRefVariableProcess();
        /// </summary>
        // Return Ref Variable
        // Mọi sụ thay đổi trên biến được gán ref sẽ thay đổi thuộc tính ref của object(instance) được trả về trong method
        public ref int ReturnRefVariableProcess()
        {
            return ref this.process;
        }
    }
}
