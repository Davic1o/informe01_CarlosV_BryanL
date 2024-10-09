// ************************************************************************
// Practica 00
// Carlos David Vega Varela, Bryan Alexis Lugmania Torres
// Fecha de realización: 02/10/2024
// Fecha de entrega: 09/10/2024
// Resultados:
// * El código permita generar una tabla con potencias y una tabla con ángulos y
// sus valores de las funciones seno y coseno
// Conclusiones:

// El código implementado cumple su función de generar tablas de potencias y funciones trigonométricas, 
// demostrando un manejo adecuado de cálculos matemáticos y la presentación de resultados en consola.

//La modificación de los nombres de las funciones a una convención de nomenclatura más estándar mejora 
//la legibilidad y la coherencia del código, facilitando su mantenimiento y comprensión.

//El uso correcto de constantes matemáticas como PI garantiza la precisión en los cálculos de ángulos 
//y sus respectivas funciones trigonométricas.

//La estructura modular del programa permite una fácil expansión o modificación de las funciones, 
// lo que contribuye a la escalabilidad del código para futuras mejoras.


// Recomendaciones:

// Validación de entrada: Se sugiere implementar validaciones de los parámetros desde y hasta en las 
// funciones para evitar errores si se ingresan valores fuera de rango o no numéricos.

//Formato de salida: Es recomendable ajustar el formato de la salida en consola, alineando los 
//resultados en columnas para mejorar la legibilidad de las tablas generadas.

//Comentarios detallados: Se debe agregar más comentarios explicativos dentro del código 
//para que otros desarrolladores puedan entender mejor el propósito y funcionamiento de cada bloque.

//Optimización del bucle: Se podría optimizar el cálculo de potencias utilizando funciones matemáticas 
//predefinidas, como Math.Pow, en lugar de realizar las multiplicaciones manualmente, mejorando la claridad y eficiencia del código.


// ************************************************************************


namespace informe01_CarlosV_BryanL
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

 // se cabio la asignacion de la variable x=x+1 por x++ que ifualment suma mas 1 y es la convecion correcta 
 for (int x = desde; x <= hasta; x++)
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

 // se cambio la variable  que estaba par ala asigunacio nde  el bucle por la que permite entender mejor que se va a suar 5 a cada loop
 for (double x = desde; x <= hasta; x += 5.0)
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
