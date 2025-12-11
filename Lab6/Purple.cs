using System;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab6
{
    public class Purple
    {
        public void Task1(int[,] A, int[,] B)
        {

            // code here

            // end

        }

        public int FindDiagonalMaxIndex(int[,] matrix)
        {
            int max = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0);)
            {
                for (int j = 0; j < matrix.GetLength(1); i++, j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        public void SwapRowColumn(int[,] matrix, int rowIndex, int[,] B, int columnIndex)
        {

        }

        public void Task2(ref int[,] A, int[,] B)
        {

            // code here

            // end

        }

        public int CountPositiveElementsInRow(int[,] matrix, int row)
        {
            return 0;
        }

        public int CountPositiveElementsInColumn(int[,] matrix, int col)
        {
            return 0;
        }

        public void Task3(int[,] matrix)
        {

            // code here

            // end

        }

        public void ChangeMatrixValues(int[,] matrix)
        {

        }

        public void Task4(int[,] A, int[,] B)
        {

            // code here

            // end

        }

        public int[] CountNegativesPerRow(int[,] matrix)
        {
            return null;
        }

        public void Task5(int[] matrix, Sorting sort)
        {

            // code here

            // end

        }

        public int FindMaxIndex(int[] array)
        {
            return 0;
        }

        public void Task6(int[,] matrix, SortRowsByMax sort)
        {

            // code here

            // end

        }

        public void SortRowsByMaxAscending(int[,] matrix)
        {

        }

        public void SortRowsByMaxDescending(int[,] matrix)
        {

        }

        public int GetRowMax(int[,] matrix, int row)
        {
            return 0;
        }

        public int[] Task7(int[,] matrix, FindNegatives find)
        {
            int[] negatives = null;

            // code here

            // end

            return negatives;
        }

        public int[] FindNegativeCountPerRow(int[,] matrix)
        {
            return null;
        }

        public int[] FindMaxNegativePerColumn(int[,] matrix)
        {
            return null;
        }

        public int[,] Task8(int[,] matrix, MathInfo info)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }

        public int[,] DefineSeq(int[,] matrix)
        {
            return null;
        }

        public int[,] FindAllSeq(int[,] matrix)
        {
            return null;
        }

        public int[,] FindLongestSeq(int[,] matrix)
        {
            return null;
        }

        public int Task9(double a, double b, double h, Func<double, double> func)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }

        public int CountSignFlips(double a, double b, double h, Func<double, double> func)
        {
            return 0;
        }

        public double FuncA(double x)
        {
            return 0.0;
        }

        public double FuncB(double x)
        {
            return 0.0;
        }

        public void Task10(int[][] array, Action<int[][]> func)
        {

            // code here

            // end

        }

        public void SortInCheckersOrder(int[][] array)
        {

        }

        public void SortBySumDesc(int[][] array)
        {

        }

        public void TotalReverse(int[][] array)
        {

        }
    }
}
