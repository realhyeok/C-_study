using System;

namespace Ch._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7-1번 문제
            /*double[] weight = new double[3];
            weight[0] = double.Parse(Console.ReadLine());
            weight[1] = double.Parse(Console.ReadLine());
            weight[2] = double.Parse(Console.ReadLine());*/

            // 7-2번 문제
            /*string[] studentName = { "홍길동", "김철수", "이영희" };
            //studentName[0] = "홍길동";
            //studentName[1] = "김철수";
            //studentName[2] = "이영희";

            Console.WriteLine(studentName[0]);
            Console.WriteLine(studentName[1]);
            Console.WriteLine(studentName[2]);*/

            // 7-3번 문제
            /*int[] scores = { 90, 85, 73, 100 };
            //int scores = { 90, 85, 73, 100 };
            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);*/

            // 7-4번 문제 교과서 참고

            // 심화문제 7-1

            /*double[] weights = new double[studentCount];

                Console.WriteLine("몸무게를 입력하세요.");
                weights[studentNumber] = double.Parse(Console.ReadLine());
            
                Console.WriteLine("몸무게: " + weights[studentNumber]);*/

            // 심화문제 7-2

            /*int courseCount = 5;
            double[] score = new double[courseCount];

            //Console.Write(objects[0]);
            Console.WriteLine("국어의 점수를 입력하세요.");
            score[0] = double.Parse(Console.ReadLine());
            //double Korean = int.Parse(Console.ReadLine());
            //Console.Write(objects[1]);
            Console.WriteLine("영어의 점수를 입력하세요.");
            score[1] = double.Parse(Console.ReadLine());
            //double English = int.Parse(Console.ReadLine());
            //Console.Write(objects[2]);
            Console.WriteLine("수학의 점수를 입력하세요.");
            score[2] = double.Parse(Console.ReadLine());
            //double Math = int.Parse(Console.ReadLine());
            //Console.Write(objects[3]);
            Console.WriteLine("과학의 점수를 입력하세요.");
            score[3] = double.Parse(Console.ReadLine());
            //double Science = int.Parse(Console.ReadLine());
            //Console.Write(objects[4]);
            Console.WriteLine("사회의 점수를 입력하세요.");
            score[4] = double.Parse(Console.ReadLine());
            //double Society = int.Parse(Console.ReadLine());
            double totalScore = score[0] + score[1] + score[2] + score[3] + score[4];
            double average = totalScore / courseCount;
            Console.WriteLine("총 점수는 " + totalScore + "입니다.");
            Console.WriteLine("총 평균 점수는 " + average + "입니다.");*/ //에 관한건 영상 풀이 후 수정

            //뼈대

            /*int courseCount = 5;
            double[] score = new double[courseCount];
            score[0] = double.Parse(Console.ReadLine());
            score[1] = double.Parse(Console.ReadLine());
            score[2] = double.Parse(Console.ReadLine());
            score[3] = double.Parse(Console.ReadLine());
            score[4] = double.Parse(Console.ReadLine());

            double totalScore = score[0] + score[1] + score[2] + score[3] + score[4];
            double Value = totalScore / courseCount;
            Console.WriteLine(totalScore);
            Console.WriteLine(Value);*/
        }
    }
}
