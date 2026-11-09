using Negocio.Servicios;
using System;
using System.IO;

namespace GeneradorHash
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashService = new Sha512HashService();
            string hash = hashService.GenerarHash("123456");

            Console.WriteLine("Hash generado para '123456':");
            Console.WriteLine(hash);

            // Escribimos el resultado también en un archivo, por si la consola se cierra
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hash_resultado.txt");
            File.WriteAllText(rutaArchivo, hash);

            Console.WriteLine();
            Console.WriteLine("También guardado en: " + rutaArchivo);

            // Pausa simple sin depender de teclado interactivo
            System.Threading.Thread.Sleep(5000);
        }
    }
}
