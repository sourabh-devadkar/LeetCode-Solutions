public class NumMatrix {
    private readonly int[][] matrix;
    public NumMatrix(int[][] matrixObj) {
        int n = matrixObj.Length;
        if(n == 0) { matrix = new int[0][]; return;}
        int m = matrixObj[0].Length;
        matrix = new int[n][];

        for(int i = 0; i < n; i++)
        {
            matrix[i] = new int[m + 1];
            for(int j = 0; j < m; j++)
            {
                matrix[i][j+1] = matrix[i][j] + matrixObj[i][j];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
       int sum = 0;
       for(int i = row1; i <= row2; i++)
       {
            sum += matrix[i][col2 + 1] - matrix[i][col1];
       }
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */