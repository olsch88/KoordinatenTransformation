using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace MatrixLibrary;

public class CoordinateTransformation
{
    public static Matrix<double> GetSourceMatrix(double[,] numbers)
    {
        Matrix<double> A = DenseMatrix.OfArray(new double[,] {
        {numbers[0,0],numbers[0,1],numbers[0,2]},
        {numbers[1,0],numbers[1,1],numbers[1,2]},
        {1,1,1}});



        return A;
    }

    public static Matrix<double> GetTargetMatrix(double[,] numbers)
    {
        Matrix<double> A = DenseMatrix.OfArray(new double[,] {
        {numbers[0,0],numbers[0,1],numbers[0,2]},
        {numbers[1,0],numbers[1,1],numbers[1,2]},
        {1,1,1}});



        return A;
    }

    public static Matrix<double> GetTransofmationMatrix(Matrix<double> matrixSource, Matrix<double> matrixTarget)
    {
        Matrix<double> matrixTransformation = matrixTarget.Multiply( matrixSource.Inverse());

        return matrixTransformation;

    }

    public static  Vector<double> applyTransformattion(Matrix<double> matrixTransformation, Vector<double> sourceVector)
    {
        Vector<double> result = matrixTransformation.Multiply(sourceVector);
        return result;
    }
}