using System;

namespace numeros
{
    class Program_principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola usuario, este programa fue creado para identificar el número mayor y  menor entre 3 opciones\n");
            Console.WriteLine("INGRESA EL PRIMER NUMERO:\n");
            int primer_numero, segundo_numero, tercer_numero;
            primer_numero = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL SEGUNDO NUMERO:\n");
            segundo_numero = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL TERCER NUMERO:\n");
            tercer_numero = int.Parse(Console.ReadLine());

            int mayor = primer_numero;
            int menor = primer_numero;

            if (segundo_numero > mayor)
            {
                mayor = segundo_numero;
            }
            if (tercer_numero > mayor)
            {
                mayor = tercer_numero;
            }
            if (segundo_numero < menor)
            {
                menor = segundo_numero;
            }
            if (tercer_numero < menor)
            {
                menor = tercer_numero;
            }
            Console.WriteLine("el numero mayor es:" + mayor + "\n");
            Console.WriteLine("el numero menor es:" + menor + "\n");
        }
    }
}
