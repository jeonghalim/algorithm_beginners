using System;

namespace Application
{
    /*행렬회전 : 이미지를 표현하는 N * N 행렬이 있다. 이미지의 각 픽셀은 4바이트로 표현된다. 이때, 이미지를 90도 회전시키는 메서드를 작성하라. 행렬을 추가로 사용하지 않고서도 할 수 있겠는가?*/
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("N값 입력: ");
            int n = int.Parse(Console.ReadLine());

            int[,] exam = new int[n, n];
            int[,] rotate = new int[n, n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int ran = random.Next(0, 9);
                    exam[i, j] = ran;
                    Console.Write(exam[i, j].ToString());
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //-----------------------------------회~~~전-------------------------------
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotate[j,n-1-i] = exam[i,j];
                }
            }
            //------------------------------------------------------------------------

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(rotate[i, j].ToString());

                }
                Console.Write("\n");
            }

        }
    }
}
