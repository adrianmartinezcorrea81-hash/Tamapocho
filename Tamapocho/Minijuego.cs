public class Minijuego
{

    public static int MinijuegoCunyao()
    {
        Random aleatorio = new Random();

        int refran = aleatorio.Next(1, 7);
        int respuesta;

        Console.Clear();
        JuegoTam.TextoMas("----Adivina El Refrán----");
        switch (refran)
        {
            case 1:
                Console.WriteLine("A caballo regalado... ");
                Console.WriteLine("1) no le mires el diente.\n2) no le limpies las herraduras.\n3) siempre le corre el viento.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 2:
                Console.WriteLine("Al mal tiempo...");
                Console.WriteLine("1) buena cara.\n2) buen paraguas.\n3) duerme en la cama.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }

                break;
            case 3:
                Console.WriteLine("A quien madruga...");
                Console.WriteLine("1) el sueño le dura.\n2) la tienda le madura\n3) Dios le ayuda.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 4:
                Console.WriteLine("Dime con quién andas...");
                Console.WriteLine("1)  y te diré qué vendes\n2) y te diré quién eres.\n3) y sabré de qué pie cojeas.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 5:
                Console.WriteLine("No dejes para mañana...");
                Console.WriteLine("1)  el dinero que tienes hoy.\n2) lo que puedas hacer hoy.\n3) la cena que te sobró hoy.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 6:
                Console.WriteLine("De tal palo...");
                Console.WriteLine("1)  tal astillero.\n2) tal costilla.\n3) tal astilla.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 7:
                Console.WriteLine("Más vale maña...");
                Console.WriteLine("1)  que fuerza.\n2) que pereza.\n3) que destreza.");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            default:
                return 0;
        }
    }

    public static int MinijuegoGym(TamapochoGymBro tamagym)
    {
        Console.Clear();
        JuegoTam.TextoMas("----Entrenamiento----");
        JuegoTam.TextoMas("----Elige un ejercicio y Peso----");
        Console.WriteLine("Elige un ejercicio:\n1-Press Banca\n2-Curl Martillo\n3-Jalón al pecho");
        int ejercicio = Convert.ToInt32(Console.ReadLine());
        switch (ejercicio)
        {
            case 1:
                Console.WriteLine($"Segun la fuerza de tu tamapocho({tamagym.FuerzaTama}) Elige entre estos pesos: \n1-60kg\n2-80kg\n3-90kg\n4-100\n5-140kg");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == 1)
                {
                    Console.WriteLine("60kg levantados sin problema.");
                    return 1;
                }
                else if (eleccion == 2)
                {
                    if (tamagym.FuerzaTama >= 10)
                    {
                        Console.WriteLine("80kg levantados!!");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion == 3)
                {
                    if (tamagym.FuerzaTama >= 20)
                    {
                        Console.WriteLine("90kg levantados!!");
                        return 3;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion == 4)
                {
                    if (tamagym.FuerzaTama >= 30)
                    {
                        Console.WriteLine("100kg  levantados!!");
                        return 4;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion == 5)
                {
                    if (tamagym.FuerzaTama >= 40)
                    {
                        Console.WriteLine("80kg levantados!!");
                        return 5;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Opción No Valida");
                    return 0;
                }




            case 2:
                Console.WriteLine($"Segun la fuerza de tu tamapocho({tamagym.FuerzaTama}) Elige entre estos pesos: \n1-10kg\n2-15kg\n3-20kg\n4-30\n5-40kg");
                int eleccion2 = Convert.ToInt32(Console.ReadLine());
                if (eleccion2 == 1)
                {
                    Console.WriteLine("10kg levantados sin problema.");
                    return 1;
                }
                else if (eleccion2 == 2)
                {
                    if (tamagym.FuerzaTama >= 10)
                    {
                        Console.WriteLine("15kg levantados!!");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion2 == 3)
                {
                    if (tamagym.FuerzaTama >= 20)
                    {
                        Console.WriteLine("20kg levantados!!");
                        return 3;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion2 == 4)
                {
                    if (tamagym.FuerzaTama >= 30)
                    {
                        Console.WriteLine("30kg  levantados!!");
                        return 4;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion2 == 5)
                {
                    if (tamagym.FuerzaTama >= 40)
                    {
                        Console.WriteLine("40kg levantados!!");
                        return 5;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Opción No Validad");
                    return 0;
                }




            case 3:
                Console.WriteLine($"Segun la fuerza de tu tamapocho({tamagym.FuerzaTama}) Elige entre estos pesos: \n1-40kg\n2-55kg\n3-75kg\n4-90\n5-110kg");
                int eleccion3 = Convert.ToInt32(Console.ReadLine());
                if (eleccion3 == 1)
                {
                    Console.WriteLine("40kg levantados sin problema.");
                    return 1;
                }
                else if (eleccion3 == 2)
                {
                    if (tamagym.FuerzaTama >= 10)
                    {
                        Console.WriteLine("55kg levantados!!");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion3 == 3)
                {
                    if (tamagym.FuerzaTama >= 20)
                    {
                        Console.WriteLine("75kg levantados!!");
                        return 3;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion3 == 4)
                {
                    if (tamagym.FuerzaTama >= 30)
                    {
                        Console.WriteLine("90kg  levantados!!");
                        return 4;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else if (eleccion3 == 5)
                {
                    if (tamagym.FuerzaTama >= 40)
                    {
                        Console.WriteLine("110kg levantados!!");
                        return 5;
                    }
                    else
                    {
                        Console.WriteLine("Aún eres debil para este peso....Te has lesionado.");
                        tamagym.VidaTama -= 10;
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Opción No Validad");
                    return 0;
                }



            default:
                return 0;



        }

    }
    public static int MinijuegoHippie()
    {
        Random aleatorio = new Random();

        int refran = aleatorio.Next(1, 7);
        int respuesta;

        Console.Clear();
        JuegoTam.TextoMas("----Canciones Bob Marley....----");
        switch (refran)
        {
            case 1:
                Console.WriteLine("No woman no cry.... - ¿Qué dice la siguiente frase?");
                Console.WriteLine("1) Don't worry, be happy\n2) Every little thing is gonna be alright\n3) We are the world");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 2:
                Console.WriteLine("One Love... - ¿Cómo empieza la canción?");
                Console.WriteLine("1) One love, one heart\n2) One love, one soul\n3) One love, one dream");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }

                break;
            case 3:
                Console.WriteLine("Redemption Song - ¿De qué habla la canción?");
                Console.WriteLine("1) Del amor perdido\n2) De la liberación de la esclavitud mental\n3) De la naturaleza jamaicana");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 4:
                Console.WriteLine("Buffalo Soldier... - ¿Quién era el Buffalo Soldier?");
                Console.WriteLine("1) Un guerrero africano\n2) Un soldado robado de África llevado a América\n3)Un cazador de búfalos");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            case 5:
                Console.WriteLine("Is This Love...- ¿Qué quiere hacer Bob en la canción?");
                Console.WriteLine("1) Bailar toda la noche contigo\n2) Compartir su única cama contigo\n3) Viajar por el mundo contigo");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2)
                {
                    Console.WriteLine("Respuesta correcta!!!");
                    Console.WriteLine("Recibes 2 TamCoins");
                    return 2;

                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta");
                    return 0;
                }
                break;
            default:
                return 0;
        }
        return 0;

    }
    public static int MinijuegoInfor()
    {
        Random aleatorio = new Random();

        int codigo = aleatorio.Next(1, 6);
        int respuesta;

        Console.Clear();
        JuegoTam.TextoMas("----Adivina El Codigo Incorrecto----");
        switch (codigo)
        {
            case 1:
                Console.WriteLine("1) int x = 5;\n2) Console.WriteLine(\"Hola mundo\");\n3) string nombre = 42;");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3) { Console.WriteLine("Respuesta correcta!!!\nRecibes 2 TamCoins"); return 2; }
                else { Console.WriteLine("Respuesta incorrecta"); return 0; }
            case 2:
                Console.WriteLine("1) int[] numeros = new int[5];\n2) string saludo = \"Buenos dias\";\n3) bool activo = \"true\";");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3) { Console.WriteLine("Respuesta correcta!!!\nRecibes 2 TamCoins"); return 2; }
                else { Console.WriteLine("Respuesta incorrecta"); return 0; }
            case 3:
                Console.WriteLine("1) Console.Write(\"Introduce tu edad: \");\n2) int edad = Console.ReadLine();\n3) string nombre = Console.ReadLine();");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 2) { Console.WriteLine("Respuesta correcta!!!\nRecibes 2 TamCoins"); return 2; }
                else { Console.WriteLine("Respuesta incorrecta"); return 0; }
            case 4:
                Console.WriteLine("1) int resultado = 10 + 5;\n2) Console.WriteLine(resultado);\n3) int resultado = 20 + 3;");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3) { Console.WriteLine("Respuesta correcta!!!\nRecibes 2 TamCoins"); return 2; }
                else { Console.WriteLine("Respuesta incorrecta"); return 0; }
            case 5:
                Console.WriteLine("1) for(int i = 0; i < 5; i++)\n2) Console.WriteLine(i);\n3) int i = Console.ReadLine();");
                respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 3) { Console.WriteLine("Respuesta correcta!!!\nRecibes 2 TamCoins"); return 2; }
                else { Console.WriteLine("Respuesta incorrecta"); return 0; }
            default:
                return 0;
        }
    }
    public static int MinijuegoTikTok(TamapochoTikTok tamaTik)
    {
        Random aleatorio = new Random();

        int tiktok = aleatorio.Next(1, 4);
        int respuesta;
        if (tamaTik.Sexo == Genero.MUJER)
        {



            Console.Clear();
            JuegoTam.TextoMas("----Elige El Trending Topic----");
            switch (tiktok)
            {
                case 1:
                    Console.WriteLine("¿Qué trend arrasa esta semana?");
                    Console.WriteLine("1) Tutorial de maquillaje degradado\n2) Receta de pasta con nata\n3) Reto de fitness en 30 días");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == 1)
                    {
                        Console.WriteLine("Respuesta correcta!!!");
                        Console.WriteLine("Recibes 2 TamCoins");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        return 0;
                    }
                    break;
                case 2:
                    Console.WriteLine("¿Qué hashtag está en el top?");
                    Console.WriteLine("1) #Aesthetic\n2) #Minecraft\n3) #Futbol");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == 1)
                    {
                        Console.WriteLine("Respuesta correcta!!!");
                        Console.WriteLine("Recibes 2 TamCoins");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        return 0;
                    }

                    break;
                case 3:
                    Console.WriteLine("¿Qué canción está en todos los TikToks?");
                    Console.WriteLine("1) Bohemian Rhapsody\n2) Motomami - Rosalía - Queen\n3) Thunderstruck - AC/DC");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == 2)
                    {
                        Console.WriteLine("Respuesta correcta!!!");
                        Console.WriteLine("Recibes 2 TamCoins");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        return 0;
                    }
                    break;
                default:
                    return 0;
            }
            return 0;
        }
        else//Hombre
        {

            Console.Clear();
            JuegoTam.TextoMas("----Elige El Trending Topic----");
            switch (tiktok)
            {
                case 1:
                    Console.WriteLine("¿Qué trend arrasa esta semana?");
                    Console.WriteLine("1) Tutorial skincare\n2) Crossbar challenge\n3) Receta de galletas");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == 2)
                    {
                        Console.WriteLine("Respuesta correcta!!!");
                        Console.WriteLine("Recibes 2 TamCoins");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        return 0;
                    }
                    break;
                case 2:
                    Console.WriteLine("¿Qué hashtag está en el top?");
                    Console.WriteLine("1) #Maquillaje\n2) #F1\n3) #Yoga");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == 2)
                    {
                        Console.WriteLine("Respuesta correcta!!!");
                        Console.WriteLine("Recibes 2 TamCoins");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        return 0;
                    }

                    break;
                case 3:
                    Console.WriteLine("¿Qué canción está en todos los TikToks?");
                    Console.WriteLine("1) Blank Space-Taylor Swift\n2) Como Antes-Bad Bunny\n3) Sigma-Phonk");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == 3)
                    {
                        Console.WriteLine("Respuesta correcta!!!");
                        Console.WriteLine("Recibes 2 TamCoins");
                        return 2;

                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        return 0;
                    }
                    break;
                default:
                    return 0;
            }
            return 0;

        }
    }




}