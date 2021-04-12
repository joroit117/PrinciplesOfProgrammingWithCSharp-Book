using System;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int serie = 1, tempSerie = 1;
            string element = "e";
            string[,] matrix = new string[n, m];
            string[] bestSerie = new string[n*m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    if(Check(matrix[rows, cols], matrix[rows, cols + 1]) == 1)
                    {
                        tempSerie++;
                    }
                    else
                    {
                        tempSerie = 1;
                    }
                    if(serie < tempSerie)
                    {
                        serie = tempSerie;
                        element = matrix[rows, cols];
                    }
                }
                tempSerie = 1;
            }
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                {
                    if (Check(matrix[rows, cols], matrix[rows + 1, cols]) == 1)
                    {
                        tempSerie++;
                    }
                    else
                    {
                        tempSerie = 1;
                    }
                    if (serie < tempSerie)
                    {
                        serie = tempSerie;
                        element = matrix[rows, cols];
                    }
                }
                tempSerie = 1;
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                    {
                        if (Check(matrix[rows, cols], matrix[rows + 1, cols + 1]) == 1) tempSerie++;
                        else tempSerie = 1;

                        if (serie < tempSerie)
                        {
                            serie = tempSerie;
                            element = matrix[rows, cols];
                        }
                    }
                    tempSerie = 1;
                }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (Check(matrix[rows, cols], matrix[rows + 1, cols - 1]) == 1) tempSerie++;
                        else tempSerie = 1;

                        if (serie < tempSerie)
                        {
                            serie = tempSerie;
                            element = matrix[rows, cols];
                        }
                    }
                    tempSerie = 1;
                }

            for (int i = 0; i < serie; i++) Console.Write("{0} ", element);
        }
        static int Check(string a, string b)
        {
            if(a == b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
