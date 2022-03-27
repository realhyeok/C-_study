using System;

namespace Ch._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6-1 문제
            /*Console.Write("3 <= 5 : ");
            Console.WriteLine(3 <= 5);
            Console.Write("!(5 == 5) : ");
            Console.WriteLine(!(5 == 5));
            Console.Write("!( 3 < 2 ) : ");
            Console.WriteLine(!(3 < 2));
            Console.Write("1 > 0 : ");
            Console.WriteLine(1 > 0);*/

            //6-2문제
            /*Console.WriteLine("먹은 사과의 개수를 입력하세요.");
            int eatenAppleCount = int.Parse(Console.ReadLine());
            if (eatenAppleCount > 3)
            {
                Console.WriteLine("사과를 많이 먹었습니다.");
            }
            else if (eatenAppleCount < 3)
            {
                Console.WriteLine("사과를 조금 먹었습니다.");
            }
            else
            {
                Console.WriteLine("사과를 적절히 먹었습니다.");
            }*/

            //6-3문제

            /*Console.WriteLine("10등 미만이거나 90점을 초과하면 \'A\'입니다.");
            Console.WriteLine("등수를 입력하세요.");
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("점수를 입력하세요.");
            int score = int.Parse(Console.ReadLine());

            if (rank < 10 || score > 90)
            {
                Console.WriteLine("축하합니다. A입니다.");
            }
            else if (rank > 10 || score < 90)
            {
                Console.WriteLine("A를 받지 못하셨습니다. 다음 번에는 꼭 좋은 성적 받으시길 바랍니다. 힘내세요!");
            }*/

            // 심화문제 6-1

            /*Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            string userInput1 = Console.ReadLine();

            Console.Write(number1);
            Console.Write(userInput1);
            Console.Write(number2);
            Console.Write(" = ");

            if (userInput1 == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (userInput1 == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (userInput1 == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (userInput1 == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            else if (userInput1 == "%")
            {
                Console.WriteLine(number1 % number2);
            }*/

            //심화문제 6-2

            Console.WriteLine("숫자를 입력하세요.");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 3 == 0 && userInput > 20)
            {
                Console.WriteLine("20보다 큰 3의 배수입니다.");
            }
            else
            {
                Console.WriteLine("조건에 맞지 않는 수입니다.");
            }
        }
    }
}
