﻿using System;

namespace StudnetList_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];

            /*Console.WriteLine("몇 번째 학생의 정보를 추가할까요.");
            int studentNumber = int.Parse(Console.ReadLine());*/

            //if (studentNumber >= 0 && studentNumber <= studentCount - 1)
            int studentNumber = 0;
            while (studentNumber < studentCount)
            {
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생의 정보를 입력할 차례입니다.");

                Console.WriteLine("나이를 입력하세요.");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentNumber] = double.Parse(Console.ReadLine());

                studentNumber = studentNumber + 1;

            }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("입력된 학생정보를 출력할 차례입니다.");

                studentNumber = 0;
                while (studentNumber < studentCount)
                {
                    Console.WriteLine(studentNumber + "번째 학생");
                    Console.WriteLine("이름: " + names[studentNumber]);
                    Console.WriteLine("나이: " + ages[studentNumber]);
                    Console.WriteLine("키: " + heights[studentNumber]);

                    studentNumber = studentNumber + 1;

                }
            }
        }
    }