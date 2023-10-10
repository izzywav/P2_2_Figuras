//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    var rectangulo = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3.0, 3.9);
    var circulo = new Circulo(Color.FromArgb(255, 0, 300, 35), 4.0);
    var triangulo = new TrianguloEquilatero(Color.FromArgb(26, 0, 112, 40), 3.0);

    // muestro las caracteristicas en la consola 
    Console.WriteLine(rectangulo.ToString());
    Console.WriteLine($"Área: {rectangulo.GetArea()}");

    Console.WriteLine(circulo.ToString());
    Console.WriteLine($"Área: {circulo.GetArea()}");

    Console.WriteLine(triangulo.ToString());
    Console.WriteLine($"Área: {triangulo.GetArea()}");

    List<Figura> lista_figuras = new List<Figura>();

    // agregp las instancias en la lista
    lista_figuras.Add(rectangulo);
    lista_figuras.Add(circulo);
    lista_figuras.Add(triangulo);

    foreach (var Figura in lista_figuras)
    {
      Figura.Color = Color.FromArgb(200, 40, 145, 245);
    }

    double sumaAreas = 0.0;
    foreach (var Figura in lista_figuras)
    {
      sumaAreas += Figura.GetArea();
    }

    // Mostrar la suma de las áreas por pantalla
    Console.WriteLine($"Suma de áreas de todas las figuras: {sumaAreas}");
  }

}