using P2_2_Figuras;
using System.Drawing;

internal class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(Color color, double baseRectangulo, double alturaRectangulo)
    {
        Color = color;
        Base = baseRectangulo;
        Altura = alturaRectangulo;
    }

    public override double GetArea()
    {
        return Base * Altura;
    }

    public override string ToString()
    {
        return $"FIGURA RECTANGULO\nBase: {Base}\nAltura: {Altura}\n{base.ToString()}";
    }
}