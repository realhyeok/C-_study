using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int passcodeNumbers1 = 6;
            int passcodeNumbers2 = 2;

            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int userInput2 = int.Parse(Console.ReadLine());

            if (userInput1 == passcodeNumbers1 && userInput2 == passcodeNumbers2)
            {
                Console.WriteLine("문이 열렸습니다.");
            }

            Console.WriteLine("키가 몇인가요?");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("나이가 몇 살인가요?");
            int age = int.Parse(Console.ReadLine());

            //논리합연산자 : 왼쪽이나 오른쪽이 참이라면 참, 물론 둘 다 참일 경우도 참.
            if (height >= 130 || age >= 14)
            {
                Console.WriteLine("롤러코스터를 탈 수 있습니다.");
            }
            else if (!(height >= 130 && age >= 14)) //논리부정연산자 : (!) 안에 ()로 감싸야 한다.
            {
                Console.WriteLine("입장이 불가능합니다.");
            }
        }
    }
}
