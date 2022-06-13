using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Examen_Regu
{
    class Program
    {
        // Creación de la clase
        class Producto
        {
            // Campos de la clase 
            public string nombre_producto;

            public int cantidad_producto;
            public float precio;

            // Constructor de la clase
            public Producto(string nombre_producto, int cantidad_Producto, float precio)
            {
                this.nombre_producto = nombre_producto;
                this.cantidad_producto = cantidad_Producto;
                this.precio = precio;

            }
            public void desplegar()
            {
                if (File.Exists("Producto.txt"))
                {
                    // leer ARCHIVO y imprimir en pantalla
                    TextReader Leer = new StreamReader("Producto.txt");
                    Console.WriteLine("Impresión del archivo: ");
                    Console.WriteLine("\n" + Leer.ReadToEnd());

                    Leer.Close();
                }


            }

        }
        static void Main(string[] args)
        {
            // Declaración de variables
            string nom_p;
            int cantidad;
            float precio;


            try
            {
                // Escribir Archivo
                StreamWriter escribir = new StreamWriter(new FileStream("Producto.txt", FileMode.Append, FileAccess.Write));
                Console.Write(" Ingresa el nombre del producto: ");
                nom_p = Console.ReadLine();
                Console.Write(" Ingresa la cantidad del producto: ");
                cantidad = int.Parse(Console.ReadLine());
                Console.Write(" Ingresa el precio del producto: ");
                precio = float.Parse(Console.ReadLine());
                // despliegue en el archivo
                escribir.Write(nom_p + "\n" + cantidad + "\n" + precio + "\n");

                escribir.Close();




                // Creación del objeto: 
                Producto a = new Producto(nom_p, cantidad, precio);

                // ejecusión del metodo desplegar 
                a.desplegar();

                Console.Write("Para salir del programa presione enter: ");
            }
            catch (IOException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (FormatException b)
            {
                Console.WriteLine(b.Message);
            }
            Console.ReadKey();
        }
    }
}
