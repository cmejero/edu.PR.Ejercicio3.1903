namespace edu.PR.Ejercicio3._1903
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string rutaArchivo = "C:\\Users\\Carlos\\Desktop\\Cs1\\PROGRAMACION\\ficheroParaActividades\\archivoEjercicio.txt";

            using(StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine("Un libro (del latín liber, libri) es una obra impresa, manuscrita o pintada en una serie de hojas de papel, pergamino,");
                sw.WriteLine("vitela u otro material, unidas por un lado (es decir, encuadernadas) y protegidas con tapas, también llamadas cubiertas.");
                sw.WriteLine("Un libro puede tratar sobre cualquier tema. Según la definición de la Unesco,1​2​ un libro debe poseer veinticinco hojas");
                sw.WriteLine("mínimo (49 páginas), pues de veinticuatro hojas o menos sería un folleto; y de una hasta cuatro páginas se consideran");
                sw.WriteLine("hojas sueltas (en una o dos hojas).");

            }
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("Contenido del archivo:\n" + contenido);
            }


            Console.WriteLine("-----------------------------------------------------------------------");



            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int linea = Convert.ToInt32(Console.ReadLine());

            try
            {
                string[] contenidoOriginal = File.ReadAllLines(rutaArchivo);

                if (linea >= 1 && linea <= contenidoOriginal.Length)
                {
                    contenidoOriginal[linea - 1] = textoUsuario;
                    File.WriteAllLines(rutaArchivo, contenidoOriginal);

                    Console.WriteLine("El texto ha sido introducido correctamente");
                }
                else
                {
                    Console.WriteLine("La línea introducida no corresponde con el texto");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }



        }

    }
}
