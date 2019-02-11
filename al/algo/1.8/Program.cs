using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.Write("M 입력 : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("N 입력 : ");
            int y = int.Parse(Console.ReadLine());

            int[,] exam = new int[x, y];
            int[,] b = new int[x, y];
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < y; j++)
                {
                    int ran = random.Next(0, 9);
                    exam[i, j] = ran;
                    b[i, j] = ran;
                }
            }

            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < y; j++)
                {
                    Console.Write(exam[i, j].ToString());

                }
                Console.Write("\n");
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (exam[i, j] == 0)
                    {
                        for (int k = 0; k < x; k++)
                            b[k, j] = 0;
                        for (int k = 0; k < y; k++)
                            b[i, k] = 0;
                    }
                }
            }

            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < y; j++)
                {
                    Console.Write(b[i, j].ToString());
                                    
                }
                Console.Write("\n");
            }

        }
    }
}
