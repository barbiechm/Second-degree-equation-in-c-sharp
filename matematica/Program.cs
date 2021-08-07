using System;

namespace matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double a, b = 0, c, m = Math.Pow(b,2);
           
            int opcion;
           
            do
            {  
                       //Limpiar consola
                       Console.Clear();

                       //Pedir y guardar los datos en las variables
                Console.WriteLine("RESOLVER ECUACIONES DE SEGUNDO GRADO. Ingrese los valores: ");

                Console.WriteLine("INGRESE EL NUMERO DE A = ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("INGRESE EL NUMERO DE B = ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("INGRESE EL NUMERO DE C = ");
                c = Convert.ToDouble(Console.ReadLine());
               
                //Se define la formula universal en las variables, y comienza el proceso de operaciones

                double x1 = (-b + Math.Sqrt(m - (4 * a * c))) / (2 * a);

                double x2 = (-b - Math.Sqrt(m - (4 * a * c))) / (2 * a);


                Console.WriteLine("El valor de x1 es = " + Math.Round(x1));

                Console.WriteLine("El valor de x2 es = " + Math.Round(x2));

                Console.WriteLine(" ");

                //La opcion que toma el usuario, referente a terminar o continuar
                Console.WriteLine("Qué desea?: ");

                Console.WriteLine("1. Salir");

                Console.WriteLine("2. Continuar");

                opcion = Convert.ToInt32(Console.ReadLine());

            }
            while (opcion != 1);

            if (opcion == 1) Console.WriteLine("Hasta Luego :D");

            Console.ReadKey();

        }

    }
}
