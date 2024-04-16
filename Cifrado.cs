using System;

class Program
{
    static void Main()
    {
        string mensajeOriginal = "HELLO"; // Mensaje a cifrar
        int desplazamiento = 3; // Desplazamiento para el cifrado César

        string mensajeCifrado = CifrarCesar(mensajeOriginal, desplazamiento);
        Console.WriteLine("Mensaje cifrado: " + mensajeCifrado);

        string mensajeDescifrado = DescifrarCesar(mensajeCifrado, desplazamiento);
        Console.WriteLine("Mensaje descifrado: " + mensajeDescifrado);
    }

    static string CifrarCesar(string mensaje, int desplazamiento)
    {
        string mensajeCifrado = "";

        foreach (char caracter in mensaje)
        {
            if (char.IsLetter(caracter))
            {
                char letraCifrada = (char)((((caracter - 'A') + desplazamiento) % 26) + 'A');
                mensajeCifrado += letraCifrada;
            }
            else
            {
                mensajeCifrado += caracter;
            }
        }

        return mensajeCifrado;
    }

    static string DescifrarCesar(string mensajeCifrado, int desplazamiento)
    {
        string mensajeDescifrado = "";

        foreach (char caracter in mensajeCifrado)
        {
            if (char.IsLetter(caracter))
            {
                char letraDescifrada = (char)((((caracter - 'A') - desplazamiento + 26) % 26) + 'A');
                mensajeDescifrado += letraDescifrada;
            }
            else
            {
                mensajeDescifrado += caracter;
            }
        }

        return mensajeDescifrado;
    }
}
