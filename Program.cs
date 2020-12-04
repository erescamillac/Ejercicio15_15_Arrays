using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15_15_Arrays
{
    class Program
    {
        public static void ShowGrades(double[] gradesArray) {
            Console.WriteLine("++Contenido del arreglo: ");
            byte index = 0;
            if (!(gradesArray is null))
            {
                foreach (var grade in gradesArray) {
                    Console.WriteLine($"Calificación [{index + 1}]: {grade}");
                    index++;
                }
            }
            else {
                Console.WriteLine("El arreglo especificado es null.");
            }
            Console.WriteLine("---------------------------------------------");
        }
        public static void ReadGrades(double[] gradesArray) {
            byte index = 0;
            double gradeTmp = 0.0;
            if (!(gradesArray is null))
            {
                Console.WriteLine("-->> Ingrese las Calificaciones de los alumnos.");
                foreach (var grade in gradesArray) {
                    Console.Write($"Ingrese la calificación del alumno {index + 1}: ");
                    double.TryParse(Console.ReadLine(), out gradeTmp);
                    gradesArray[index] = gradeTmp;
                    index++;
                }
            }
            else {
                Console.WriteLine("El arreglo especificado es null.");
            }
        } //--fin: ReadGrades
        static void Main(string[] args)
        {
            double[] grades;
            byte numAlum;
            char continueP = 'n';

            do {
                Console.Clear();
                Console.WriteLine("##--Programa Cálculo de Promedio de Grupo--##");
                Console.Write("Introduzca el número de alumnos en el Grupo: ");
                byte.TryParse(Console.ReadLine(), out numAlum);
                grades = new double[numAlum];

                ReadGrades(grades);
                ShowGrades(grades);
                Console.WriteLine("string".ElementAt(0));
                Console.WriteLine("string".ElementAt(1));
                Console.WriteLine("string".ElementAt(2));

                double acumulador = 0.0, promedio;

                foreach (double grade in grades) {
                    acumulador += grade;
                }

                promedio = acumulador / grades.Length;

                Console.Write("\n\t¿Desea calcular el promedio de OTRO GRUPO? [y/n]: ");
                continueP = Console.ReadKey().KeyChar;
            } while (Char.ToLower(continueP).Equals('y'));


        }
    }
}
