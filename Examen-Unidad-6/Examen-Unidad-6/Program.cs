using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Unidad_6
{
   internal class InventarioAmazon
    {

        string Nombre, Descripcion;
        float Precio;
        int CantidadStock;
 
        public void CrearRegistro()
        {
            StreamWriter sw = new StreamWriter("Productos.txt",true);
      
            Console.Write("Nombre del Producto: ");
            Nombre = Console.ReadLine();
            Console.Write("Descripcion del Producto: ");
            Descripcion = Console.ReadLine();
            Console.Write("Precio del producto: ");
            Precio = Single.Parse(Console.ReadLine());
            Console.Write("Cantidad en stock del producto: ");
            CantidadStock = Int32.Parse(Console.ReadLine());

            // Escribe los datos del archivo          
            sw.Write("\r\n"  + "Nombre del producto: "+ Nombre + "\r\n");
            sw.Write("Descripcion del prodcuto: " + Descripcion + "\r\n\n");
            sw.Write("Precio del producto: {0:C}" , Precio);
            sw.Write("\r\n" +"Cantidad en stock: " + CantidadStock + "\r\n");

            Console.WriteLine("Escribiendo en el archivo...");
            sw.Close();
            Console.ReadKey();
        }

        public void LeerRegistro()
        {
            StreamReader sr = new StreamReader("Productos.txt");//busca en el archivo .txt       
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            Console.ReadKey();
        }
       
        static void Main(string[] args)
        {
            int opcion;

            // creacion del objeto
            InventarioAmazon IA = new InventarioAmazon();
            do
            {
                // Menu de Opciones
                Console.Clear();
                Console.WriteLine("\n ♣♦♥ MENU DE OPCIONES ♥♦♣");
                Console.WriteLine("1.- Ingresar un nuevo producto al archivo.");
                Console.WriteLine("2.- Leer los productos del archivo.");
                Console.WriteLine("3.- Salida del programa.");
                Console.Write("\nQue opcion deseas: ");
                opcion = Int16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    
                     IA.CrearRegistro();
                        
                        break;

                    case 2:
                        // Bloque de lectura
                        IA.LeerRegistro();

                        break;
                    case 3:
                        Console.Write("\nPresione <enter> para salir del programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("\nEsa opcion no existe!!, Presione <enter> para continuar...");
                        Console.ReadKey();
                        break;

                }
            } while (opcion != 3);        
        }
    }
}
