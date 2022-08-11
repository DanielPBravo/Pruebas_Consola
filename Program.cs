using System;

namespace Pruebas_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Decimal porcentaje;
            Decimal nota;
            Decimal acomuladorPorcentaje = 0;
            Decimal acomuladorNota = 0;
            Decimal promedio;
            //Decimal promedioTotal = 0;

            Console.Write("Promedio de notas\n");
            Console.Write("**------------------------**\n");

            do
            {   
                if(contador >= 1) Console.Write("Ingrese la siguiente nota del estudiante: \n"); else Console.Write("Ingrese la nota del estudiante: \n");

                nota = Convert.ToDecimal(Console.ReadLine());
                if (nota > 5)
                {
                    Console.Write("No debe ser superior a 5 :V\n");
                    nota = Convert.ToDecimal(Console.ReadLine());
                    contador++;
                }
                else 
                {
                    contador++;
                }
                Console.Write("Ingrese el porcentaje de la nota ingresada: \n");
                porcentaje = Convert.ToDecimal(Console.ReadLine());
                if (porcentaje > 100 || acomuladorPorcentaje + porcentaje > 100)
                {
                    Console.Write($"El porcentaje de la nota ingresada es muy alto, no debe ser mayor a \n" + (100 - acomuladorPorcentaje));
                    porcentaje = Convert.ToDecimal(Console.ReadLine());
                    acomuladorPorcentaje += porcentaje;
                    porcentaje = porcentaje / 100;
                    nota = nota * porcentaje;
                    acomuladorNota += nota;
                    promedio = acomuladorNota;
                    //promedioTotal += promedio;
                }
                else 
                {
                    acomuladorPorcentaje += porcentaje;
                    porcentaje = porcentaje / 100;
                    nota = nota * porcentaje;
                    acomuladorNota += nota;
                    promedio = acomuladorNota;
                    //promedioTotal += promedio;

                }
            }
            while (acomuladorPorcentaje < 100);

            Console.Write($"La cantidad de notas ingresadas fueron: {contador} el promedio del estudiante es: {promedio} \n");

            if(promedio > 3) Console.Write($"Estudiante Aprobado\n"); else Console.Write($"Estudiante Reprobado\n");

            Console.Write("\tPresione cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
