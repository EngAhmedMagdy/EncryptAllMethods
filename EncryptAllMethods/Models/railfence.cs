using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptAllMethods.Models
{
    public class railfence
    {
        private static char[][] BuildCleanMatrix(int rows, int cols)
        {
            char[][] result = new char[rows][];

            for (int row = 0; row < result.Length; row++)
            {
                result[row] = new char[cols];
            }

            return result;
        }

        private static string BuildStringFromMatrix(char[][] matrix)
        {
            string result = string.Empty;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] != '\0')
                    {
                        result += matrix[row][col];
                    }
                }
            }

            return result;
        }

        private static char[][] Transpose(char[][] matrix)
        {
            char[][] result =
                BuildCleanMatrix(matrix[0].Length, matrix.Length);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    result[col][row] = matrix[row][col];
                }
            }

            return result;
        }

        public string Cipher(string clearText, int key)
        {
            string result = string.Empty;

            char[][] matrix = BuildCleanMatrix(key, clearText.Length);

            int rowIncrement = 1;
            for (int row = 0, col = 0; col < matrix[row].Length; col++)
            {
                if (
                    row + rowIncrement == matrix.Length ||
                    row + rowIncrement == -1
                    )
                {
                    rowIncrement *= -1;
                }

                matrix[row][col] = clearText[col];

                row += rowIncrement;
            }

            result = BuildStringFromMatrix(matrix);

            return result;
        }
    }
}
