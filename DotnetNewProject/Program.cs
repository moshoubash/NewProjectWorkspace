using System;
namespace MyApplication
{
    public class Program {
        static void Main(string[] args) {
            C obj = new C();
            obj.fn();
        }
    }

    public class C {
        public void fn() {
            int[] arr = {1, 2, 3, 4};
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}