using System;

namespace MEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("서울고등학교 3학년 A~E반까지의 성적과 반별 평균 점수를 구하는 프로그램입니다.");
            int[] classCount = new int[5];
            int[] studentCount = new int[10];
            string classNames = "";
            string[] names = { "A", "B", "C", "D", "E" };
            int totalScore = 0;
            double average = 0;
            int[] eachstudentScore = new int[10];

            while (classNames != names[0] || classNames != names[1] || classNames != names[2] || classNames != names[3] || classNames != names[4])
            {
                Console.WriteLine("조회하고자 하시는 반 이름을 입력하세요.");
                classNames = Console.ReadLine();

                if(classNames == names[0] || classNames == names[1] || classNames == names[2] || classNames == names[3] || classNames == names[4])
                {
                    Console.WriteLine(classNames + "반의 정보를 조회합니다.");
                    break;
                }
                Console.WriteLine("잘못 입력하셨습니다.");
            }

            for(int i = 0; i < 10; i++)
            {
                Console.Write(i+1);
                Console.WriteLine("번째 학생의 성적을 입력하세요.");
                eachstudentScore[i] = int.Parse(Console.ReadLine());
                totalScore = totalScore + eachstudentScore[i];

                if(i == 9)
                {
                    average = totalScore / 10;
                    Console.WriteLine("입력하신 점수를 산출합니다.");
                    Console.Write(classNames);
                    Console.Write("반의 총점은 ");
                    Console.WriteLine(totalScore + "입니다.");

                    Console.Write("평균 값은 ");
                    Console.WriteLine(average);
                    
                    break;
                }
            }
        }
    }
}
