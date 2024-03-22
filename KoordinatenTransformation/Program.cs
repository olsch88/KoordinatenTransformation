using System.IO;
using System.Runtime.InteropServices;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MatrixLibrary;

namespace KoordinatenTransformation;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        double[,] source = { { -4.6579, 5.3374, 15.3328 }, { 0.9753, 1.2799, 1.5844 } };
        double[,] target = { { 0, 10, 20 }, { 0, 0, 0 } };

        Matrix<double> sourceMatrix = CoordinateTransformation.GetSourceMatrix(source);
        Matrix<double> targetMatrix = CoordinateTransformation.GetSourceMatrix(target);

        Matrix<double> transformation = CoordinateTransformation.GetTransofmationMatrix(sourceMatrix, targetMatrix);


        Vector<double> example1 = Vector<double>.Build.Dense(3);
        example1[0] = 25.3282;
        example1[1] = 1.8889;
        example1[2] = 1;


        Vector<double> example1_target = CoordinateTransformation.applyTransformattion(transformation, example1);

        Console.WriteLine(example1_target);

        Vector<double> example2 = Vector<double>.Build.Dense(3);
        example1[0] = 35.3235;
        example1[1] = 2.1935;
        example1[2] = 1;

        Vector<double> example2_target = CoordinateTransformation.applyTransformattion(transformation, example1);

        Console.WriteLine(example2_target);

    }
}
