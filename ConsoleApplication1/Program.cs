using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello work");
            //Console.WriteLine(args[0]);
            // Leer por consola un dato
            try
            {
                int var1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---"+var1);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }
            Console.WriteLine("Continuando con el programa");
            Int16 var2 = 12512;
            Console.WriteLine(var2);
            string nombre = "Juan Gonzalez";
            Console.WriteLine(nombre);
            bool mayorEdad = true;
            Console.WriteLine(mayorEdad);
            // Array
            object[] nombres = {"Juan", "Andres", "Ana"};
            Console.WriteLine(nombres[0]);
            // for each
            foreach (var nom in nombres)
            {
                Console.WriteLine(nom);
            }
            // for 
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            // if
            if (mayorEdad)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
            // if else if
            var dia = 2;
            if (dia == 1){
                Console.WriteLine("Domingo");   
            }else if (dia == 2){
                Console.WriteLine("Lunes");
            }
            // switch
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                default:
                    Console.WriteLine("Dia eroneo");
                    break;
            }

        }
    }
}