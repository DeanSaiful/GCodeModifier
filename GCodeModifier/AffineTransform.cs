using System;

public class AffineTransform
{
    private double[,] matrix = new double[2, 3];

    public void SolveTransformation((double x, double y)[] src, (double x, double y)[] dst)
    {
        if (src.Length != 4 || dst.Length != 4)
            throw new ArgumentException("Exactly 4 points are required.");

        var A = new double[8, 6];
        var B = new double[8];

        for (int i = 0; i < 4; i++)
        {
            double x = src[i].x, y = src[i].y;
            double x2 = dst[i].x, y2 = dst[i].y;

            A[2 * i, 0] = x; A[2 * i, 1] = y; A[2 * i, 2] = 1;
            A[2 * i, 3] = 0; A[2 * i, 4] = 0; A[2 * i, 5] = 0;
            B[2 * i] = x2;

            A[2 * i + 1, 0] = 0; A[2 * i + 1, 1] = 0; A[2 * i + 1, 2] = 0;
            A[2 * i + 1, 3] = x; A[2 * i + 1, 4] = y; A[2 * i + 1, 5] = 1;
            B[2 * i + 1] = y2;
        }

        var AT = MatrixTranspose(A);
        var ATA = MatrixMultiply(AT, A);
        var ATB = MatrixMultiply(AT, B);
        var X = SolveLinear(ATA, ATB);

        matrix[0, 0] = X[0]; matrix[0, 1] = X[1]; matrix[0, 2] = X[2];
        matrix[1, 0] = X[3]; matrix[1, 1] = X[4]; matrix[1, 2] = X[5];
    }

    public (double x, double y) Transform(double x, double y)
    {
        double newX = matrix[0, 0] * x + matrix[0, 1] * y + matrix[0, 2];
        double newY = matrix[1, 0] * x + matrix[1, 1] * y + matrix[1, 2];
        return (newX, newY);
    }

    private double[,] MatrixTranspose(double[,] A)
    {
        int rows = A.GetLength(0), cols = A.GetLength(1);
        var T = new double[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                T[j, i] = A[i, j];
        return T;
    }

    private double[,] MatrixMultiply(double[,] A, double[,] B)
    {
        int aRows = A.GetLength(0), aCols = A.GetLength(1),
            bCols = B.GetLength(1);
        var result = new double[aRows, bCols];
        for (int i = 0; i < aRows; i++)
            for (int j = 0; j < bCols; j++)
                for (int k = 0; k < aCols; k++)
                    result[i, j] += A[i, k] * B[k, j];
        return result;
    }

    private double[] MatrixMultiply(double[,] A, double[] B)
    {
        int rows = A.GetLength(0), cols = A.GetLength(1);
        var result = new double[rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i] += A[i, j] * B[j];
        return result;
    }

    private double[] SolveLinear(double[,] A, double[] B)
    {
        int n = B.Length;
        var M = new double[n, n + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                M[i, j] = A[i, j];
            M[i, n] = B[i];
        }

        for (int i = 0; i < n; i++)
        {
            int maxRow = i;
            for (int k = i + 1; k < n; k++)
                if (Math.Abs(M[k, i]) > Math.Abs(M[maxRow, i]))
                    maxRow = k;

            for (int k = i; k <= n; k++)
            {
                var tmp = M[maxRow, k];
                M[maxRow, k] = M[i, k];
                M[i, k] = tmp;
            }

            for (int k = i + 1; k < n; k++)
            {
                double f = M[k, i] / M[i, i];
                for (int j = i; j <= n; j++)
                    M[k, j] -= f * M[i, j];
            }
        }

        var x = new double[n];
        for (int i = n - 1; i >= 0; i--)
        {
            x[i] = M[i, n] / M[i, i];
            for (int k = i - 1; k >= 0; k--)
                M[k, n] -= M[k, i] * x[i];
        }

        return x;
    }
}
