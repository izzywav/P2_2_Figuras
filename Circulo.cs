using P2_2_Figuras;
using System.Drawing;

internal class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(Color color, double radioCirculo)
    {
        Color = color;
        Radio = radioCirculo;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public override string ToString()
    {
        return $"FIGURA CÍRCULO\nRadio: {Radio}\n{base.ToString()}";
    }
}