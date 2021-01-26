using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G3E1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se definen las variables base
            double km = 0;
            double result1 = 0;
            double result2 = 0;
            double result3 = 0;

            //Pantalla de Bienvenida
            Console.WriteLine("Hola, este es un conversor de medidas de kilometros a metros, yardas y/o varas");

            //Seleccion de operacion
            Console.WriteLine("Para empezar, seleccione cualquiera de las siguientes acciones:");
            Console.WriteLine("Convertir de Kilometros a...");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Yardas");
            Console.WriteLine("3. Varas");
            Console.WriteLine("4. Metros y Yardas");
            Console.WriteLine("5. Metros y Varas");
            Console.WriteLine("6. Yardas y Varas");
            Console.WriteLine("7. Metros, Yardas y Varas");
            Console.WriteLine("NOTA. Por favor ingrese el numero con la opcion que necesitas");
            int opcion = Convert.ToInt32(Console.ReadLine());
            
            //CASOS PARA CADA OPERACION
            switch (opcion)
            {
                case 1:
                    //Caso 1: KM A M
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a metros'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1000;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " metros.");
                    break;
                case 2:
                    //Caso 2: KM A YD
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a yardas'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1093.61;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " yardas.");
                    break;
                case 3:
                    //Caso 3: KM A VAR
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a varas'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1196.30;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " varas.");
                    break;
                case 4:
                    //Caso 4: KM - M Y Y 
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a metros y yardas'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1000;
                    result2 = km * 1093.61;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " metros y " + result2 + " yardas.");
                    break;
                case 5:
                    //Caso 5: KM - M Y V 
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a metros y varas'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1000;
                    result2 = km * 1196.30;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " metros y " + result2 + " varas.");
                    break;
                case 6:
                    //Caso 6: KM - Y Y V 
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a yardas y varas'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1093.61;
                    result2 = km * 1196.30;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " yardas y " + result2 + " varas.");
                    break;
                case 7:
                    //Caso 7: KM - M, Y Y V 
                    Console.WriteLine("Has seleccionado 'Convertir de Kilometros a metros, yardas y varas'.");
                    Console.WriteLine("Ahora bien, por favor ingresa el numero de km a convertir");
                    km = Convert.ToDouble(Console.ReadLine());
                    result1 = km * 1000;
                    result2 = km * 1093.61;
                    result3 = km * 1196.30;
                    Console.WriteLine(km + " kilometros son equivalentes a " + result1 + " metros, " + result2 + " yardas y " + result3 + " varas.");
                    break;
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
