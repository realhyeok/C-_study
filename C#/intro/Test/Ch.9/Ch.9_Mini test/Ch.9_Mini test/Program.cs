using System;

namespace Ch._9_Mini_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9-1번 문제
            /*Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요.");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumbers = new int[friendCount];

            for(int i = 0; i < friendCount; i++)
            {
                Console.Write(i);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < friendCount; i++)
            {
                Console.Write(i);
                Console.Write("번째 친구가 가져간 사과의 개수는 ");
                Console.Write(appleNumbers[i]);
                Console.WriteLine("개 입니다.");
            }*/

            //9-2번 문제

            /*int[] scores = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write(i);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점 입니다.");*/

            // 9-3번 문제

            /*for (int i = 2; i <= 8; i=i+2)
            {
                Console.Write(i);
                Console.WriteLine("단");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i);
                    Console.Write("x");
                    Console.Write(j);
                    Console.Write(" = ");
                    Console.Write(i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/


            // 심화문제 9-1

            /*Console.WriteLine("비밀번호 다섯자리를 입력하세요.");
            Console.WriteLine();

            int[] password = { 6, 2, 1, 9, 4, 7 };

            string[] passwordMessage = { "첫 번째 비밀번호를 입력하세요.", "두 번째 비밀번호를 입력하세요.", "세 번째 비밀번호를 입력하세요.", "네 번째 비밀번호를 입력하세요.", "다섯 번째 비밀번호를 입력하세요.", "여섯 번째 비밀번호를 입력하세요." };
            int[] passwordCode = new int[6];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(passwordMessage[j]);
                    passwordCode[j] = int.Parse(Console.ReadLine());
                }

                bool isCorrect = true;

                for (int j = 0; j < 6; j++)
                {
                    if (passwordCode[j] != password[j])
                    {
                        isCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }
                if (isCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }*/

            //심화문제 9-2
            int classCount = 5;
            int studentCount = 10;
            double[] classScores = new double[classCount];
            for(int i = 0; i < classCount; i++)
            {
                Console.Write("3학년");
                Console.Write(i + 1);
                Console.WriteLine("반의 성적을 입력하세요.");

                for(int j =0; j < studentCount; j++)
                {
                    Console.Write(j + 1);
                    Console.WriteLine("번째 학생의 점수를 입력하세요.");
                    classScores[i] = classScores[i] + double.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < classCount; i++)
            {
                Console.Write("3학년");
                Console.Write(i + 1);
                Console.Write("반 평균은 ");
                Console.WriteLine(classScores[i] / studentCount);
            }
        }
    }
}