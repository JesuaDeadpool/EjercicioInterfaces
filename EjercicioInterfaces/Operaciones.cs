using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {

        public double DiagionalA { get; set; }

        public double DiagonalB { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }
        public double Circunferencia { get; set; }
        public double LadoA { get; set;  }
        public double LadoB { get; set; }
        public double LadoC { get; set; }


        public double AreaRombo()
        {
            return (DiagionalA * DiagonalB) / 2; 
            
        }

        public double DiametroCirculo()
        {
            return Circunferencia * Math.PI;
        }

        public double LongitudCircunferencia()
        {
            return DiametroCirculo() * Math.PI;
        }

        public double SemiPerimetroTriangulo()
        {
            return (LadoA + LadoB + LadoC) / 2;
        }

        public double VolumenCilindro()
        {
            return Math.PI * Math.Pow(Radio,2) * Altura;
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"- El Area de un Rombo con su Base {Base} y su Altura {Altura} es igual a: {AreaRombo().ToString("F2")}");
            Console.WriteLine($"- Diametro de un Circulo con su Circunferencia {Circunferencia} es igual a: {DiametroCirculo().ToString("F2")}");
            Console.WriteLine($"- La Longitud de una circunferencia con su Diametro {DiametroCirculo()} (El diametro es tomado del resultado diametro de la operación anterior ) es igual a: {LongitudCircunferencia().ToString("F2")}");
            Console.WriteLine($"- El Semi Perimetro de un triangulo con su LadoA {LadoA}, Lado B {LadoB} y su LadoC {LadoC} es igual a: {SemiPerimetroTriangulo().ToString("F2")}");
            Console.WriteLine($"- El Volumen de un cilindro con su Radio {Radio} y su Altura {Altura} es igual a: {VolumenCilindro().ToString("F2")}");
        }
    }
}
