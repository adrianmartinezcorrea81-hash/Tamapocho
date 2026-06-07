public enum Genero
{
    HOMBRE, MUJER
}

public class TamapochoTikTok : Tamapocho, ITamapochotk
{
    public Genero Sexo;
    public int Seguidores; //He pensado que seria interesante que al igual que en los otros tamapochos hay niveles de algo este no sea menos asi que lo hare segun los seguidores que pueden ir aumentando grabando ttks

    private bool Vivo; // añade esto

    public TamapochoTikTok(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, int Nivel, bool vivo, /*Exclu*/ Genero sexo, int seguidores) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        Sexo = sexo;
        Seguidores = seguidores;
        Vivo = true;
    }
    public int GrabarTikTok()
    {


        Random aleatorio = new Random();

        int videotiktok = aleatorio.Next(1, 7);


        if (Sexo == Genero.MUJER)
        {
            Random aleatorioSegM = new Random();

            int cantSeguidores = aleatorioSegM.Next(20, 45);

            switch (videotiktok)
            {
                case 1:
                    Console.WriteLine("TikTok GRWM para el concierto de Bad Bunny grabado!!");
                    break;
                case 2:
                    Console.WriteLine("TikTok Indirecta a tu ex mas que grabado");
                    break;
                case 3:
                    Console.WriteLine("TikTok RedFlags en Hombres grabado check!!");
                    break;
                case 4:
                    Console.WriteLine("Baile trend de TikTok grabado!!");
                    break;
                case 5:
                    Console.WriteLine("TikTok hablando de tu vida grabado!!");
                    break;
                case 6:
                    Console.WriteLine("Rutina de SkinCare Grabada!!!");
                    break;
                case 7:
                    Console.WriteLine("Haul de shein(60kg) grabado y mas que publicado!!!");
                    break;
            }

            return cantSeguidores;
        }
        else
        {

            Random aleatorioSegH = new Random();

            int cantSeguidores = aleatorioSegH.Next(10, 23);
            switch (videotiktok)
            {
                case 1:
                    Console.WriteLine("Crossbar Challenge grabado y publicado!!");
                    break;
                case 2:
                    Console.WriteLine("TikTok De Podcast Improvisado publicado");
                    break;
                case 3:
                    Console.WriteLine("TikTok de tu nuevo coche publicado!!");
                    break;
                case 4:
                    Console.WriteLine("Baile trend de TikTok grabado(has sido obligado)!!");
                    break;
                case 5:
                    Console.WriteLine("Clips de Rocket League con tus colegas publicado!!");
                    break;
                case 6:
                    Console.WriteLine("Rutina de Espalda publicada!!!");
                    break;
                case 7:
                    Console.WriteLine("TikTok Broma a tu colega durmiendo subido!!!");
                    break;
            }


            return cantSeguidores;

        }
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel} \nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nGenero= {this.Sexo.ToString().ToUpper()}\nDinero={Duenyo.Dinero}";
    }
    public void IniciarJuegoTikToker(TamapochoTikTok tamapochoTik)
    {

        JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
        Console.WriteLine(tamapochoTik);


        while (Vivo)
        {
            Console.WriteLine(tamapochoTik);
            Console.WriteLine($"1-Ver Estado Actual De {tamapochoTik.NombreTama}\n2-Grabar TikTok\n3-Tienda\n4-Jugar Minijuego\n5-SALIR");
            int eleccion = Convert.ToInt32(Console.ReadLine());

            if (eleccion == 1)
            {
                Console.WriteLine(tamapochoTik);
            }
            else if (eleccion == 2)
            {
                int segantes = tamapochoTik.Seguidores;

                bool tieneAro = false;
                foreach (Item item in Duenyo.Items)
                {
                    if (item.Nombre == "Aro de Luz")
                    {
                        tieneAro = true;
                    }

                }
                if (tieneAro == true)
                {
                    Seguidores += (int)(GrabarTikTok() * 1.5);
                }
                else
                {

                    Seguidores += GrabarTikTok();

                }
                Console.WriteLine($"Seguidores ganados = {tamapochoTik.Seguidores - segantes}");


            }
            else if (eleccion == 3)
            {
                Tienda tiendaTik = new Tienda();
                tiendaTik.MostrarItems();
                Console.WriteLine($"¿Que articulo deseas comprar?\n(escriba el numero)\nMonedas Disponibles={Duenyo.Dinero}");
                int numArticulo = Convert.ToInt32(Console.ReadLine());
                tiendaTik.Comprar(numArticulo, Duenyo, tamapochoTik);
            }
            else if (eleccion == 4)
            {
                int monedasGanadas = Minijuego.MinijuegoTikTok(tamapochoTik); // estaba MinijuegoInfor
                Duenyo.Dinero += monedasGanadas;
                if (monedasGanadas > 0)
                {
                    JuegoTam.SubirXP(tamapochoTik, 1);
                }
            }
            else if (eleccion == 5)
            {
                if (SalirGuardado.SalirTikTok(tamapochoTik, Duenyo))
                {
                    Vivo = false;
                }
            }
            else
            {
                Console.WriteLine("Eleccion Incorrecta");
                continue;
            }
            if (tamapochoTik.VidaTama <= 0)
            {
                JuegoTam.GameOver(tamapochoTik);
                Vivo = false;
            }
        }

    }
}
