using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Exercises
    {
        static void Main(string[]args)
        {

            //// 1.- Empleando arreglos mostrar los nombres de 4 alumnos, las notas del examen parcial,
            ////oral y final, si el promedio es mayor o igual a 7 se debe mostrar un mensaje de
            ////APROBADOS, caso contrario NO APROBADO, en una escala de 0 - 10.


            //string[] nombres = { "Alumno 1", "Alumno 2", "Alumno 3", "Alumno 4", };
            //double[] examaneParcial = { 9.0, 5.6, 3.2, 4.0 };
            //double[] examenOral = { 5.0, 4.2, 10.0, 4.1 };
            //double[] examenFinal = { 2.4, 4.5, 5.0, 4.2 };

            //Console.WriteLine("ALUMNOS");
            //Console.WriteLine("");

            //for (int i = 0; i < nombres.Length; i++)
            //{
            //    Console.WriteLine("-----------------");
            //    Console.WriteLine(nombres[i]);

            //    double total = (examaneParcial[i] + examenOral[i] + examenFinal[i]);
            //    double promedio = (total / 2);

            //    Console.WriteLine("Examen Parcial: " + (examaneParcial[i]));
            //    Console.WriteLine("Examen Oral: " + (examenOral[i]));
            //    Console.WriteLine("Examen Final: " + (examenFinal[i]));

            //    Console.WriteLine("Promedio: " + promedio);
            //    if (promedio >= 7)
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Resultado: APROBADO");
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Resultado: NO APROBADO");
            //        Console.WriteLine("-----------------");
            //    }

            //}





            //// 2.- Ingresar por pantalla los nombres, apellidos, edad y sexo de cinco clientes, emplee los
            ////tipos de datos arreglos.

            //int numeroClientes = 1;
            //string[] clientes;
            //string[] nombres;
            //string[] apellidos;
            //int[] edad;
            //string[] genero;

            //clientes = new string[5];
            //for (int c = 0; c < clientes.Length; c++)  
            //{
            //    Console.WriteLine("Cliente número: " + numeroClientes);
            //    numeroClientes++;
            //    Console.WriteLine("");

            //    nombres = new string[1];
            //    for (int n = 0; n < nombres.Length; n++)
            //    {
            //        Console.WriteLine("Ingrese el nombre del cliente");
            //        nombres[n] = Console.ReadLine();
            //        Console.WriteLine("");

            //    }

            //    apellidos = new string[1];
            //    for (int a = 0; a < apellidos.Length; a++)
            //    {
            //        Console.WriteLine("Ingese el apellido del cliente");
            //        apellidos[a] = Console.ReadLine();
            //        Console.WriteLine("");
            //    }

            //    edad = new int[1];
            //    for (int e = 0; e < edad.Length; e++)
            //    {
            //        Console.WriteLine("Ingese la edad del cliente");
            //        edad[e] = int.Parse(Console.ReadLine());
            //        Console.WriteLine("");
            //    }

            //    genero = new string[1];
            //    for (int e = 0; e < genero.Length; e++)
            //    {
            //        Console.WriteLine("Ingese el genero del cliente");
            //        Console.WriteLine("");
            //        genero[e] = Console.ReadLine();

            //    }
            //    Console.WriteLine("");
            //}





            ////3.- Mostrar la suma de n cantidades de los precios de los productos ingresados por
            ////teclado.

            //int producto = 1;
            //int cantidad;
            //double contador = 0.0;

            //Console.WriteLine("Ingrese la cantidad de productos deseados");
            //cantidad = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //string[] nombredelProducto = new string[cantidad];
            //double[] preciodelProducto = new double[cantidad];

            //for (int l = 0; l < nombredelProducto.Length; l++)
            //{
            //    Console.WriteLine("Producto número: " + producto);
            //    producto++;
            //    Console.WriteLine("");

            //    Console.WriteLine("Ingresa el nombre del producto");
            //    nombredelProducto[l] = Console.ReadLine();
            //    Console.WriteLine("");

            //    Console.WriteLine("Ingresa el precio del producto elegido");
            //    preciodelProducto[l] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("");

            //    contador = preciodelProducto[l] + contador;

            //}
            //    if (cantidad <= 1)
            //    {
            //        Console.WriteLine("El total del producto es: " + contador);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El total de los " + cantidad + " productos es: " + contador);
            //    }
            
    



        } 
    }
}
