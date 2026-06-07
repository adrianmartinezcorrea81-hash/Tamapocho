using System.Globalization;
using System.Text.Json;
public class JuegoTam
{

    public static void GameOver(Tamapocho tama)
    {
        Console.WriteLine($"Has perdido, tu tamapocho {tama.NombreTama} ha muerto");
    }

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

        //VOY A COMPROBAR QUE HAYA PARTIDA ANTES DE PEDIR LOS DATOS AL JUGADOR
        if (File.Exists("partida.json"))
        {
            Texto("Se ha encontrado una partida guardada, ¿Quieres jugarla?\n1-Sí\n2-No");
            int eleccionCarga = Convert.ToInt32(Console.ReadLine());
            if (eleccionCarga == 1)
            {
                string json = File.ReadAllText("partida.json");
                DatosPartida datos = JsonSerializer.Deserialize<DatosPartida>(json);
                Jugador criadorCargado = new Jugador(datos.NombreJugador, datos.EdadJugador);
                criadorCargado.Dinero = datos.Dinero;

                switch (datos.TipoTamapocho)
                {
                    case "Hippie":

                        TamapochoHippie tamaHip = new TamapochoHippie(datos.NombreTama, datos.VidaTama, criadorCargado, datos.Energia, datos.Felicidad, datos.AtributoEspecial, datos.Nivel, true, TamapochoHippie.EstadoHigh.Normal);
                        tamaHip.IniciarJuegoHipp(tamaHip);
                        break;


                    case "Gym":

                        TamapochoGymBro tamaGym = new TamapochoGymBro(datos.NombreTama, datos.VidaTama, criadorCargado, datos.Energia, datos.Felicidad, (int)datos.AtributoEspecial, datos.Nivel, true, TamapochoGymBro.NivelCulturista.FLAKITO);
                        tamaGym.IniciarJuegoGym(tamaGym);
                        break;


                    case "Infor":

                        TamapochoInformatico tamaInfor = new TamapochoInformatico(datos.NombreTama, datos.VidaTama, criadorCargado, datos.Energia, datos.Felicidad, datos.AtributoEspecial, datos.Nivel, true, TamapochoInformatico.EstadoEnergetico.DEPRIMIDO);
                        tamaInfor.IniciarJuegoInfor(tamaInfor);
                        break;


                    case "Cunyao":

                        Tamapochocunyao tamaCunya = new Tamapochocunyao(datos.NombreTama, datos.VidaTama, criadorCargado, datos.Energia, datos.Felicidad, datos.AtributoEspecial, datos.Nivel, true, Tamapochocunyao.EstadodeCunyao.Normal);
                        tamaCunya.IniciarJuegoCunyao(tamaCunya);
                        break;


                    case "TikTok":

                        Genero genero;

                        if (datos.Estado == "MUJER")
                        {
                            genero = Genero.MUJER;
                        }
                        else
                        {
                            genero = Genero.HOMBRE;
                        }

                        TamapochoTikTok tamaTik = new TamapochoTikTok(datos.NombreTama, datos.VidaTama, criadorCargado, datos.Energia, datos.Felicidad, datos.Nivel, true, genero, (int)datos.AtributoEspecial);
                        tamaTik.IniciarJuegoTikToker(tamaTik);

                        break;
                }
                return;
            }
        }

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

                TamapochoHippie miTamapochoHip = new TamapochoHippie(nombreTamaHip, 100, criador, 100, 100, 0, 0, true, TamapochoHippie.EstadoHigh.Normal);
                miTamapochoHip.IniciarJuegoHipp(miTamapochoHip);

                break;

            case 2:
                Texto("Has elegido al Tamapocho Gymbro \nEspero que tengas ganas de levantar esos hierros jeje");
                TextoMas("Nombre="); string nombreTamaGym = Console.ReadLine();

                TamapochoGymBro miTamapochoGym = new TamapochoGymBro(nombreTamaGym, 100, criador, 100, 100, 5, 0, true, TamapochoGymBro.NivelCulturista.FLAKITO);
                miTamapochoGym.IniciarJuegoGym(miTamapochoGym);
                break;

            case 3:
                Texto("Has elegido al Tamapocho Informatico \nEspero que estés rapido programando jeje y preparate para beber muchas monsters");
                TextoMas("Nombre="); string nombreTamaInfor = Console.ReadLine();

                TamapochoInformatico miTamapochoInfor = new TamapochoInformatico(nombreTamaInfor, 100, criador, 100, 100, 0, 0, true, TamapochoInformatico.EstadoEnergetico.DEPRIMIDO);
                miTamapochoInfor.IniciarJuegoInfor(miTamapochoInfor);
                break;


            case 4:
                Texto("Has elegido al Tamapocho Cuñao \nEspero que tengas bien entrenadas esas bromas pasadas de moda jeje");
                TextoMas("Nombre="); string nombreTamaCunyao = Console.ReadLine();
                Tamapochocunyao miTamapochoCunyao = new Tamapochocunyao(nombreTamaCunyao, 100, criador, 100, 100, 0, 0, true, Tamapochocunyao.EstadodeCunyao.Normal);
                miTamapochoCunyao.IniciarJuegoCunyao(miTamapochoCunyao);
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
                    generoTamaTiktok = Genero.HOMBRE;
                }
                TextoMas("Nombre="); string nombreTamaTik = Console.ReadLine();
                TamapochoTikTok miTamaTikTok = new TamapochoTikTok(nombreTamaTik, 100, criador, 100, 100, 0, true, generoTamaTiktok, 0);
                miTamaTikTok.IniciarJuegoTikToker(miTamaTikTok);

                break;

            default:
                TextoMas("El numero introducido no se corresponde con ningún Tamapocho, volverás a empezar.");
                break;

        }




    }

    public static void SubirXP(Tamapocho tama, int cantidad)
    {
        tama.XP += cantidad;
        Console.WriteLine($"+{cantidad} XP! XP actual= {tama.XP}");

        if (tama.XP >= tama.Nivel * 10) // cada nivel necesita 10 XP más que el anterior
        {
            tama.Nivel += 1;
            tama.XP = 0; // resetea el XP al subir de nivel
            Console.WriteLine($"¡NIVEL {tama.Nivel} ALCANZADO!");

            if (tama.Nivel % 10 == 0)
            {
                Console.WriteLine("¡HITO! Recibes 20 TamCoins y tus stats suben!");
                tama.Duenyo.Dinero += 20;
                tama.VidaTama += 10;
                tama.Energia += 10;
                tama.Felicidad += 10;
            }
        }
    }


}







