using System;

namespace Num_8_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-1번 문제

            /*int[] scores = new int[5];
            Console.WriteLine("다섯 과목의 점수를 입력하세요.");
            int index = 0;

            while (index < 5)
            {
                Console.WriteLine(index + "첫 번째 과목의 성적을 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
                index = index + 1;
            }
            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine(" 입니다.");*/

            // 8-2번 문제

            /*Console.WriteLine("수업 과목을 몇 개 들으셨나요?");
            int subjectCount = int.Parse(Console.ReadLine());

            int[] scores = new int[subjectCount];
            int index = 0;
            int total = 0;

            while (index < subjectCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
                total = total + scores[index];
                index = index + 1;
            }

            Console.Write("평균은 ");
            Console.Write(total / subjectCount);
            Console.WriteLine("점입니다.");*/

            //8-3번 문제

            /*Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int frinedCount = int.Parse(Console.ReadLine());

            int[] appleNumber = new int[frinedCount];
            int index = 0;
            double total = 0;

            while (index < frinedCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumber[index] = int.Parse(Console.ReadLine());
                total = total + appleNumber[index];
                index = index + 1;
            }

            Console.Write("친구들에게 ");
            Console.Write(total);
            Console.WriteLine("개의 사과를 나눠줬습니다.");*/

            //8-4번 문제

            /*string userInput = "";

            while (true)
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 \'끝\'을 입력하세요.");

                userInput = Console.ReadLine();

                if (userInput == "끝")
                {
                    Console.WriteLine("드디어 종료하게 되었습니다. 고생하셨습니다.");
                    break;
                }
            }*/

            //심화문제 8-1

            /*int[] passcodeNumber = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];
            int index = 0;

            while (index <= 5)
            {
                Console.Write(index);
                Console.WriteLine("번째 숫자를 입력하세요.");
                userInput[index] = int.Parse(Console.ReadLine());
                index = index + 1;

                if (passcodeNumber[0] == userInput[0] && passcodeNumber[1] == userInput[1] && passcodeNumber[2] == userInput[2] && passcodeNumber[3] == userInput[3] && passcodeNumber[4] == userInput[4] && passcodeNumber[5] == userInput[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                }
            }*/

            /*Console.WriteLine("정정할 새로운 비밀번호 자리수를 입력하세요.");
            int passcodeCount = int.Parse(Console.ReadLine());
            int[] passCodeNumber = new int[passcodeCount];
            int index = 0;


            while (passcodeCount > 6 && passcodeCount <= 0)
            {
                Console.WriteLine("정정 가능한 비밀번호 자리수는 최대 여섯자리까지 가능합니다.");
                Console.WriteLine("다시 입력해주세요.");
                passcodeCount = int.Parse(Console.ReadLine());
            }

            while (index < passcodeCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 비밀번호를 입력하세요.");
                passCodeNumber[index] = int.Parse(Console.ReadLine());;
                index = index + 1;
            }

            Console.Write("입력하신 비밀번호는 "); // 여기에 index 숫자들을 나열하고 싶은데 하는 방법을 모르겠다.
            Console.Write(passCodeNumber[index]);
            Console.Write("총 ");
            Console.Write(passcodeCount);
            Console.WriteLine("자리 입니다.");*/

            //심화문제 8-2 

            Console.WriteLine("총 학생 수를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());
            //int[] studentNumber = new int[studentCount];
            string[] names = new string[studentCount];
            int[] korean = new int[studentCount];
            int[] english = new int[studentCount];
            int[] math = new int[studentCount];
            int index = 0;
            int[] totalScore = new int[studentCount];
            double[] average = new double[studentCount];

            while (index < studentCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 학생의 이름을 입력하세요.");
                names[index] = Console.ReadLine();
                Console.WriteLine("국어 점수를 입력하세요.");
                korean[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 점수를 입력하세요.");
                english[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 점수를 입력하세요.");
                math[index] = int.Parse(Console.ReadLine());
                totalScore[index] = korean[index] + english[index] + math[index];
                average[index] = totalScore[index] / 3;
                index = index + 1;
            }

            Console.WriteLine("-----------------------------------------------");
            index = 0;

            while (index < studentCount)
            {
                Console.Write(names[index]);
                Console.Write("학생의 ");
                Console.Write("총점은 ");
                Console.Write(totalScore[index]);
                Console.WriteLine("입니다.");
                Console.Write("평균 점수는 ");
                Console.WriteLine(average[index] + " 입니다.");
                index = index + 1;
            }

        }
    }
}