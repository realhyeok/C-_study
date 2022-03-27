using System;

namespace ch5minitest
{
    class Program
    {
        static void Main(string[] args)
        {
            //5-1번 문제
            /*Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            int number2 = int.Parse(userInput2);
            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2)*/

            //5-2번 문제 : 버그를 찾아 고치세요
            /*Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            int number2 = userInput2; // 오른쪽 입력하고자 하는 변수의 값이 1번과 같아야 한다.

            Console.WriteLine(number1 - number2);*/

            //5-3번 문제 : userInput을 없애보아라. userinput을 없애고 바로 readline을 parse 괄호에 넣어 입력한 문자열이 출력되게 할 수 있다.

            /*Console.WriteLine("첫 번째 숫자를 입력하세요.");
            double number = double.Parse(Console.ReadLine());
            Console.Write("입력한 숫자는  ");
            Console.WriteLine(number);*/


            //심화문제 1번

            /*Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            double number2 = double.Parse(userInput2);
            Console.Write(number1);
            Console.Write(" / ");
            Console.Write(number2);
            Console.Write(" = ");
            //Console.WriteLine(double.Parse(Console.ReadLine())); // 사칙연산의 문자를 입력하지 않고도 알아서 계산하는 출력법은 없을까?
            Console.WriteLine(number1 / number2);*/

            /*Console.WriteLine("이 프로그램은 두 개의 실수을 입력으로 받아 덧셈/뺄셈/곱셈/나눗셈의 결과를 보여줍니다.");
            Console.WriteLine("첫 번째 숫자를 입력해주세요.");
            double userInput1 = double.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력해주세요.");
            double userInput2 = double.Parse(Console.ReadLine());

            double number1 = userInput1;
            double number2 = userInput2;

            Console.WriteLine();
            Console.WriteLine("   연산|결과 ");
            Console.WriteLine("   ----+----");
            Console.Write("   덧셈| ");
            Console.WriteLine(number1 + number2);
            Console.Write("   뺄셈| ");
            Console.WriteLine(number1 - number2);
            Console.Write("   곱셈| ");
            Console.WriteLine(number1 * number2);
            Console.Write("  나눗셈| ");
            Console.Write(number1 / number2);
            Console.Write("...");
            Console.WriteLine(number1 % number2);*/

            //심화문제 2번 : 모르겠음

            //심화문제 3번
            int poketCoin = 10;
            Console.Write("주머니에는 동전이 ");
            Console.Write(poketCoin);
            Console.WriteLine("개 있습니다.");

            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            int number1 = int.Parse(Console.ReadLine());
            //poketCoin = poketCoin + number1; // 일일이 쓸 필요가 없다.
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            int number2 = int.Parse(Console.ReadLine());
            //poketCoin = poketCoin - number2;
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            int number3 = int.Parse(Console.ReadLine());
            //poketCoin = poketCoin - number3;
            poketCoin = poketCoin + number1 - number2 - number3;

            Console.Write("주머니에 남아 있는 동전의 개수는 ");
            Console.WriteLine(poketCoin + "개 입니다");
        }
    }
}
