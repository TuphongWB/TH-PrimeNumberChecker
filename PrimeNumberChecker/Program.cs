using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool exit = false;

            while (!exit)
            {
                // Nhập số từ người dùng
                Console.Write("Nhập một số nguyên dương (nhập 'exit' để thoát): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    exit = true;
                }
                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        // Kiểm tra số nguyên tố và hiển thị kết quả
                        bool isPrime = CheckPrimeNumber(number);
                        Console.WriteLine("Số {0} {1} số nguyên tố.", number, isPrime ? "là" : "không là");
                    }
                    else
                    {
                        Console.WriteLine("Số không hợp lệ. Vui lòng nhập lại.");
                    }
                }
    }
            Console.ReadLine();

}
        static bool CheckPrimeNumber(int number)
        {
            if (number < 2)
                return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
