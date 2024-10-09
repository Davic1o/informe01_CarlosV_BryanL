// ************************************************************************
// Practica 00
// Carlos David Vega Varela, Bryan Alexis Lugmania Torres
// Fecha de realización: 02/10/2024
// Fecha de entrega: 09/10/2024
// Resultados:
// * El código permita generar una tabla con potencias y una tabla con ángulos y
// sus valores de las funciones seno y coseno
// Conclusiones:
// *
// Recomendaciones:
// *
// ************************************************************************

using System;
namespace Parte01
{
 class Program
 {
 /// <summary>
 /// Método que permite generar una tabla con las potencias de un numero
 /// </summary>
 /// <param name="desde"> Número inicial para el cálculo </param>
 /// <param name="hasta"> Número final para el cálculo </param>
 /// 
 
 // se cambio esta parte ya que por convencion las funciones comienza por mayuscula la primera letra
 static void MostrarPotencias(int desde, int hasta)
 {
 // Cabecera de la tabla
 Console.WriteLine("x << xˆ2 << xˆ3");
 // Realización de cálculos para obtención de ponencias y presentación
 // de resultados
 for (int x = desde; x <= hasta; x = x + 1)
 {
 Console.WriteLine("{0} << {1} << {2}", x, x * x, x * x * x);
 }
 }
 /// <summary>
 /// Método que permite generar una tabla con un conjunto de ángulos y
 /// sus valores sin y cos
 /// </summary>
 /// <param name="desde"> Angulo inicial para el calculo </param>
 /// <param name="hasta"> Angulo final para el calculo </param>
 /// 
 // se cambi oesta parte ya que por convencion las funciones comienza por mayuscula la primera letra
 static void MostrarAngulos(int desde, int hasta)
 {
 const double PI = 3.141592653589793;
 // Cabecera de la tabla
 Console.WriteLine("grados << radianes << seno << coseno");
 // Cálculos para obtención de ángulo en radianes, y sus valores de sin
 // y cos
 for (double x = desde; x <= hasta; x = x + 5.0)
 {
    // se corrigio la declaracion de la variable "radianes" ya que staba iniciada pero no el tipo y no podia funcionar de esa maenra 
 double radianes;
 radianes = x * PI / 180.0;
 Console.WriteLine(x + " << " + radianes + " << " +
 Math.Sin(radianes) + " << " + Math.Cos(radianes));
 }
 }
 static int Main(string[] args)
 {
 // Presenta una tabla de potencias de los enteros comprendidos entre
 // 5 y 10
 MostrarPotencias(5, 10);
 Console.WriteLine();
 // Presenta una tabla con los angulos comprendidos entre 0 y 180
 // grados
 MostrarAngulos(0, 180);
 Console.WriteLine("Presione ENTER para terminar");
 Console.ReadLine();
 return 0;
 }
 }
}
