using System;

namespace minitest
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoin = 10;
            string poketCoin = "주머니 안에 있는 동전의 갯수 : ";
            Console.Write(poketCoin);
            Console.WriteLine(totalCoin);

            int A = totalCoin / 2;
            A = A - 1;
            string aram = "아람이가 가져간 동전의 갯수 : ";
            Console.Write(aram);
            Console.WriteLine(A);

            totalCoin = totalCoin - A;

            int W = totalCoin / 2;
            W = W + 2;
            string wooram = "우람이가 가져간 동전의 갯수 : ";
            Console.Write(wooram);
            Console.WriteLine(W);

            totalCoin = totalCoin - W;
            Console.Write(poketCoin);
            Console.WriteLine(totalCoin);
        }
    }
}
