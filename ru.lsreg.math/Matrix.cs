using System;

public class Matrix {
    private double[,] data;

    private int m;
    public int M {get => this.m;}
    
    private int n;
    public int N {get => this.n;}
    
    public void ProcessFunctionOverData(Action<int, int> func)
    {
        for(var i = 0; i < this.M; i++)
        {
            for(var j = 0; j < this.N; j++)
            {
                func(i, j);
            }
        }
    }

    public Matrix(int m, int n) 
    {
        this.m = m;
        this.n = n;
        this.data = new double[m, n];
        this.ProcessFunctionOverData((i, j) => this.data[i, j] = 0);
    }
    
    public double this[int x, int y] 
    {
        get 
        {
            return this.data[x, y];
        }
        set {
            this.data[x, y] = value;
        }        
    }

    public static Matrix operator* (Matrix matrix, double value) 
    {
        var result = new Matrix(matrix.M, matrix.N);
        result.ProcessFunctionOverData((i, j) => result[i,j] = matrix[i,j] * value);
        return result;
    }
}