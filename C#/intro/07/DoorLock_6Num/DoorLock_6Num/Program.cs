using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int passcodeNumbers1 = 6;
            int passcodeNumbers2 = 2;
            int passcodeNumbers3 = 1;
            int passcodeNumbers4 = 9;
            int passcodeNumbers5 = 4;
            int passcodeNumbers6 = 7;*/ //아래로 배열을 이용하여 정리할 수 있다.

            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            userInput[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            userInput[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 숫자를 입력하세요.");
            userInput[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("네 번째 숫자를 입력하세요.");
            userInput[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("다섯 번째 숫자를 입력하세요.");
            userInput[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("여섯 번째 숫자를 입력하세요.");
            userInput[5] = int.Parse(Console.ReadLine());


            //if (userInput1 == passcodeNumbers1 && userInput2 == passcodeNumbers2 && userInput3 == passcodeNumbers3 && userInput4 == passcodeNumbers4 && userInput5 == passcodeNumbers5 && userInput6 == passcodeNumbers6)
            if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1] && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3] && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else
            {
                Console.WriteLine("비밀번호가 틀렸습니다.");
            }

            //논리합연산자 : 왼쪽이나 오른쪽이 참이라면 참, 물론 둘 다 참일 경우도 참.

            /*Console.WriteLine("키가 몇인가요?");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("나이가 몇 살인가요?");
            int age = int.Parse(Console.ReadLine());
            if (height >= 130 || age >= 14)
            {
                Console.WriteLine("롤러코스터를 탈 수 있습니다.");
            }
            else if (!(height >= 130 && age >= 14)) //논리부정연산자 : (!) 안에 ()로 감싸야 한다.
            {
                Console.WriteLine("입장이 불가능합니다.");
            }*/
        }
    }
}
