using System;
using System.Windows.Forms;

namespace Pruebas_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int contador = 0;
                Decimal porcentaje;
                Decimal nota;
                Decimal acomuladorPorcentaje = 0;
                Decimal acomuladorNota = 0;
                Decimal promedio;

                Console.Write("Promedio de notas\n");
                Console.Write("**------------------------**\n");

                do
                {

                    if (contador >= 1) Console.Write("Ingrese la siguiente nota del estudiante: \n"); else Console.Write("Ingrese la nota del estudiante: \n");

                    nota = Convert.ToDecimal(Console.ReadLine());
                    while (nota < 0 || nota > 5)
                    {
                        Console.Write("La nota no debe ser superior a 5 ni inferior a 0: \n");
                        nota = Convert.ToDecimal(Console.ReadLine());
                    }
                    contador++;
                    Console.Write("Ingrese el porcentaje de la nota ingresada: \n");
                    porcentaje = Convert.ToDecimal(Console.ReadLine());
                    while (porcentaje > 100 || acomuladorPorcentaje + porcentaje > 100 || porcentaje < 0)
                    {
                        Console.Write($"El porcentaje no debe ser mayor a 100 ni menor que 0, el porcentaje disponible es: \n" + (100 - acomuladorPorcentaje) + ":");
                        porcentaje = Convert.ToDecimal(Console.ReadLine());
                    }
                    acomuladorPorcentaje += porcentaje;
                    porcentaje = porcentaje / 100;
                    nota = nota * porcentaje;
                    acomuladorNota += nota;
                    promedio = acomuladorNota;
                   

                }
                while (acomuladorPorcentaje < 100);

                Console.Write($"La cantidad de notas ingresadas fueron: {contador} el promedio del estudiante es: {promedio} \n");

                if (promedio > 3) Console.Write($"Estudiante Aprobado\n"); else Console.Write($"Estudiante Reprobado\n");

                Console.Write("\tPresione cualquier tecla para cerrar la consola...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: el dato de entrada no tiene el formato correcto", "Generador de notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
//if (nota > 5 || nota < 0)
//{
//    Console.Write("No debe ser superior a 5 ni inferior a 0:V\n");
//    nota = Convert.ToDecimal(Console.ReadLine());
//    contador++;
//}
//else
//{
//    contador++;
//}
//if (porcentaje > 100 || acomuladorPorcentaje + porcentaje > 100)
//{
//    Console.Write($"El porcentaje de la nota ingresada es muy alto, no debe ser mayor a \n" + (100 - acomuladorPorcentaje));
//    porcentaje = Convert.ToDecimal(Console.ReadLine());
//    acomuladorPorcentaje += porcentaje;
//    porcentaje = porcentaje / 100;
//    nota = nota * porcentaje;
//    acomuladorNota += nota;
//    promedio = acomuladorNota;
//    //promedioTotal += promedio;
//}
//else
//{
//    acomuladorPorcentaje += porcentaje;
//    porcentaje = porcentaje / 100;
//    nota = nota * porcentaje;
//    acomuladorNota += nota;
//    promedio = acomuladorNota;
//    //promedioTotal += promedio;

//}