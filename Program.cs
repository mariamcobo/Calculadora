using System;

namespace Calculadora
{
    class Program  //Clase principal de nuestro proyecto
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black; //Fondo 
            Console.ForegroundColor = ConsoleColor.Cyan; //Texto

            //Declarar Variables
            decimal num1 = 0, num2 = 0, resultado = 0; 
            int n = 1;
            char operacion = '0';
            string valor = "";
            //Cuando son el mismo tipo de dato se pueden poner seguidos con ,
            //No es necesario inicializarlo (= 0) pero es mejor

    try
    {
    //Bucle for para que no se termine después de un cálculo
    for (int i = 0; i < n; i++)
    {
    //Interactuamos con el usuario
    Console.WriteLine("~~~ Bienvenido a la Calculadora ~~~" + "\n" + "¿Desea realizar alguna operación? <S/N>");
    valor = Console.ReadLine();

    if (valor.ToUpper() == "S")
    {
        Console.WriteLine("Introduce el primer número");//Pedir el número
        num1 = Convert.ToDecimal(Console.ReadLine()); //Leer el número (Lo convertimos a un entero)

        Console.WriteLine("Introduce el segundo número");
        num2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Elije la operación: +, -, *, /");//Pedir la operación
        operacion = Convert.ToChar(Console.ReadLine());

        //Condicionales

        // SWITCH:
        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine("El resultado de la suma es: " + resultado);
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                break;

            case '/':
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la división es: " + resultado);
                if (num2 == 0)
                {
                throw new ArgumentException("No se puede dividir un número por 0");
                }
                break;

            default:
                Console.WriteLine("La opción elegida no es válida");
                break;
        }

            /* IF ELSE:

            if (operacion == '+')
            {
                resultado = num1 + num2;
                Console.WriteLine("El resultado de la suma es:" + resultado);
            }
            else if (operacion == '-')
            { 
                resultado = num1 - num2;
                Console.WriteLine("El resultado de la resta es:" + resultado);
            }
            else if (operacion == '*')
            { 
                resultado = num1 * num2;
                Console.WriteLine("El resultado de la multiplicación es:" + resultado);
            }
            else if (operacion == '/')
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la división es:" + resultado);
            }
            else
            {
                Console.WriteLine("La opción elegida no es válida");
            }
            */
    n++;
            }
            else if (valor.ToUpper() == "N")
            {
                Console.WriteLine("Pulse cualquier tecla para salir de la calculadora");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La opción elegida no es válida");
                n++;
            }

            Console.WriteLine("\n" + "Calculadora utilizada " + (i+1) + " veces" + "\n");
            }

            Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error, contacte con el soporte." + ex);
                throw;
            }
        }
    }
}
