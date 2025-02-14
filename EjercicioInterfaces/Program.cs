

using EjercicioInterfaces;

///<summary>
///autor: Jeua Pavon 
///commit: Crear Repositorio
///</summary>
Operaciones operaciones = new Operaciones();

Console.WriteLine("-------------OPERACIONES-----------");
Console.WriteLine();
Console.WriteLine("Area de un Rombo ");
Console.WriteLine("Ingrese Diagonal 1 del Rombo : ");
operaciones.DiagonalA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese Diagonal 2 del Rombo : ");
operaciones.DiagonalB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Diametro Circulo");
Console.WriteLine("Ingrese la Circunferencia del circulo : ");
operaciones.Circunferencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Longitud de una Circunferencia ");
Console.WriteLine("El Diametro para calcular la longitud de la circunferencia es tomado del resultado de la anterior Operacion ");

Console.WriteLine();
Console.WriteLine("SemiPerimetro de un Triangulo ");
Console.WriteLine("Ingresa El Primer Lado del Triangulo : ");
operaciones.LadoA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el Segundo Lado del triangulo :  ");
operaciones.LadoB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el Tercer Lado del triangulo :  ");
operaciones.LadoC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Volumen de un Cilindro ");
Console.WriteLine("Ingresa el Radio : ");
operaciones.Radio = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa la Altura: ");
operaciones.Altura = Convert.ToInt32(Console.ReadLine());

operaciones.Imprimir(); 