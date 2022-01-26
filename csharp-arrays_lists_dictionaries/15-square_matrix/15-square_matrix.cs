using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int number = myMatrix.Length / 3;
        int[,] newMatrix = new int[number,number];

        for (int i = 0; i < number; i++) {
            for (int j = 0; j < number; j++) {
                newMatrix[i,j] = myMatrix[i,j] * myMatrix[i,j];
            }
        }

        return newMatrix;
    }
}
