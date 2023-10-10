using P2_2_Figuras;
using System.Drawing;

internal class TrianguloEquilatero : Figura
{
    public double Lado { get; set; }

    public TrianguloEquilatero(Color color, double ladoTriangulo)
    {
        Color = color;
        Lado = ladoTriangulo;
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(Lado, 2);
    }

    public override string ToString()
    {
        return $"FIGURA TRIÁNGULO EQUILÁTERO\nLado: {Lado}\n{base.ToString()}";
    }
}