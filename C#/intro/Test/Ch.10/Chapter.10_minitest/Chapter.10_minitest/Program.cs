using System;

namespace Chapter._10_minitest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("가위바위보 게임입니다.");
            Console.WriteLine("(1.가위 / 2.바위 / 3.보) 입니다.");

            while(true)
            {
                int index = random.Next(1, 4);
                Console.WriteLine(index);

                Console.WriteLine("(1.가위 / 2.바위 / 3.보) 중 고르세요.");
                int userInput = int.Parse(Console.ReadLine());
                int result = userInput - index;

                if (userInput >= 1 && userInput <= 3)
                {
                    if (result == 2 || result == -1)
                    {
                        Console.WriteLine("꽝입니다!");
                        break;
                    }
                    else if (result == -2 || result == 1)
                    {
                        Console.WriteLine("축하드립니다! 정답입니다!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("비겨버렸네?");
                    }
                }
                else
                {
                    Console.WriteLine("올바른 입력 방식이 아닙니다.");
                }
            }
        }
    }
}
