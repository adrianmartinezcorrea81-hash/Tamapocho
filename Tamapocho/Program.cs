using System.Globalization;

public class JuegoTam
{
    public static void Texto(string texto, int velocidad = 30)
    {
        foreach (char letra in texto)
        {
            Console.Write(letra);
            Thread.Sleep(velocidad); //Se espera un tiempo, definido por parametro, en este caso tiempo para hacer la siguiente iteraccion 
        }
        Console.WriteLine();
    }

    public static void TextoMas(string texto, int velocidad = 15)
    {
        foreach (char letra in texto)
        {
            Console.Write(letra);
            Thread.Sleep(velocidad);
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        
        Texto("Bienvenido a Tamapocho Game");
        Texto("En primer lugar para continuar con tu Aventura deberás asignarte un nombre y tu Edad");
        Console.Write("Nombre= "); string nombre = Console.ReadLine()!;
        Console.Write("Edad= "); int edad = Convert.ToInt32(Console.ReadLine());
        Jugador criador = new Jugador(nombre, edad);

        TextoMas("A continuación deberás elegir el Tamapocho que deseas criar");
        TextoMas("1-Tamapocho Hippie");
        TextoMas("2-Tamapocho Gymbro");
        TextoMas("3-Tamapocho Informatico");
        TextoMas("4-Tamapocho Cuñao");
        TextoMas("5-Tamapocho Tiktoker");

        Console.Write("¿Que Tamapocho vas a escoger?(1 o 2 o 3 o 4 o 5)"); int eleccion = Convert.ToInt32(Console.ReadLine());

        switch (eleccion)
        {
            case 1:
                Texto("Has elegido al Tamapocho hippie \nUna vida llena de paz y hierba te espera....");
                //(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double nivelHigh)

                TextoMas("Nombre="); string nombreTamaHip = Console.ReadLine();

                TamapochoHippie miTamapochoHip = new TamapochoHippie(nombreTamaHip, 100, criador, 100, 100, 0, 0, true);
                miTamapochoHip.IniciarJuegoHipp(miTamapochoHip);

                break;

            case 2:
                Texto("Has elegido al Tamapocho Gymbro \nEspero que tengas ganas de levantar esos hierros jeje");
                TextoMas("Nombre="); string nombreTamaGym = Console.ReadLine();

                TamapochoGymBro miTamapochoGym = new TamapochoGymBro(nombreTamaGym, 100, criador, 100, 100, 5, 0, true);
                miTamapochoGym.IniciarJuegoGym(miTamapochoGym);
                break;

            case 3:
                Texto("Has elegido al Tamapocho Informatico \nEspero que estés rapido programando jeje y preparate para beber muchas monsters");
                TextoMas("Nombre="); string nombreTamaInfor = Console.ReadLine();

                TamapochoInformatico miTamapochoInfor = new TamapochoInformatico(nombreTamaInfor, 100, criador, 100, 100, 0, 0, true);
                miTamapochoInfor.IniciarJuegoInfor(miTamapochoInfor);
                break;


            case 4:
                Texto("Has elegido al Tamapocho Cuñao \nEspero que tengas bien entrenadas esas bromas pasadas de moda jeje");
                TextoMas("Nombre="); string nombreTamaCunyao = Console.ReadLine();
                Tamapochocunyao miTamapochoCunyao = new Tamapochocunyao(nombreTamaCunyao, 100, criador, 100, 100, 0, 0, true);
                miTamapochoCunyao.IniciarJuegoInfor(miTamapochoCunyao);
                break;

            case 5:

                Genero generoTamaTiktok;

                Texto("Has elegido al Tamapocho TikToker \nSuerte en esta aventura grabando TikToks");

                TextoMas("Genero="); string sexoTamaTikTok = Console.ReadLine();

                if (sexoTamaTikTok.ToLower() == "hombre" || sexoTamaTikTok.ToLower() == "macho")
                {
                     generoTamaTiktok = Genero.HOMBRE;
                }
                else if (sexoTamaTikTok.ToLower() == "mujer" || sexoTamaTikTok.ToLower() == "hembra")
                {
                     generoTamaTiktok = Genero.MUJER;

                }
                else
                {
                    Texto("No entedí ese genero");
                    Texto("Será hombre por defecto");
                    generoTamaTiktok=Genero.HOMBRE;
                }
                TextoMas("Nombre="); string nombreTamaTik = Console.ReadLine();
                TamapochoTikTok miTamaTikTok= new TamapochoTikTok(nombreTamaTik,100, criador,100,100,0,true,generoTamaTiktok);
                Console.WriteLine(miTamaTikTok);

                break;

            default:
                TextoMas("El numero introducido no se corresponde con ningún Tamapocho, volverás a empezar.");
                break;

        }




    }
}







