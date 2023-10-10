using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

//creo la clase abstracta Figura con sus metodos
internal abstract class Figura
{
  protected Color Color { get; set; }

  public abstract double GetArea();

  public override string ToString()
  {
    return $"Color: {Color}";
  }
}

//creo las subclases de las figuras en otros archivos


