using System;
using System.Text;
namespace Bai_Tap_ChuyenDe_Csharp
{
    class BaiTapCsharp
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[10];
            int i;
            Console.WriteLine("Đọc và in các phần tử của mảng trong C#");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Nhập 10 phần tử của mảng:");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Phần tử thứ - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("In ra các phần tử của mảng:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

    }


}