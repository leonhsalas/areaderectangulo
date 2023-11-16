//Programa que calcula el área de un rectángulo
var ladoA = 1.1;//Declaración de variables
var ladoB = 1.1 ;
var resultado = 1.1;


Console.WriteLine("Calcula el area de un rectangulo");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El resultado es 2" + resultado);