using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_archivos
{
    internal class Program
    {
        static string nombreArchivo = "Listaproductos.txt";
        static void Main(string[] args)
        {
            agregarNuevoProducto();
            GenerarReporte();
            UltimoProducto();
        }
        static void agregarNuevoProducto()
        {
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo, true);

            Console.WriteLine("Ingrese el nombre del producto a registrar: ");
            string producto =Console.ReadLine();
            nuevoDocumento.WriteLine(producto);
            nuevoDocumento.Close();
        }
        static void GenerarReporte()
        {
            StreamReader Leerdocumento= new StreamReader(nombreArchivo);

            int contador = 0;
            string linea;
            while ((linea =Leerdocumento.ReadLine()) != null)
            {
                contador++;
                Console.WriteLine("producto: "+ linea); ;   
            }
            Console.WriteLine("El total de productos en el almacen  en el almacen son: "+  contador);
            Leerdocumento.Close();
        }
        static void UltimoProducto()
        {
            StreamReader Leerdocumento = new StreamReader(nombreArchivo);

            string linea;
        }
    }
}
