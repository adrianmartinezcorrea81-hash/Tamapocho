public class TamapochoHippie : Tamapocho, ITamHippie
{
    public double NivelHigh;
    private bool Vivo; //Será la condicion para que puedas jugar

    public EstadoHigh EstadoFum;

    public enum EstadoHigh

    {
        Normal, Castañuela, Empastrao, Tofu, Brote, ModoZen
    }
    public TamapochoHippie(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double nivelHigh, double Nivel, bool vivo, EstadoHigh EstadoFum) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        NivelHigh = nivelHigh;
        this.EstadoFum = EstadoFum;
        Vivo = true;
    }
    public double Fumar(string itemfum) //Cada vez que fume devolvera 0.5 que mas tarde se le sumará a NivelHigh
    {
        if (itemfum == "Porro artesanal(5 g)")
        {
            Console.WriteLine($"Gracias {Duenyo.NombreJug} por este canelo de 5g ");
            return 0.5;
        }


        Random aleatorio = new Random();
        int gramos = aleatorio.Next(7, 10);
        Console.WriteLine($"Gracias {Duenyo.NombreJug} por este canelo de {gramos}g pero a este paso me matas");
        return gramos / 10;

    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel}\nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nNivel de High= {NivelHigh}";
    }

    //Aqui voy a crear un metodo donde se le pase dicho tamapocho por parametro y que se inicie un juego 

    public void IniciarJuegoHipp(TamapochoHippie tamaH)
    {


        while (Vivo)
        {
            JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
            Console.WriteLine(tamaH);

            Console.WriteLine($"1-Ver Estado Actual De {tamaH.NombreTama}\n2-Fumar\n3-Tienda\n4-SALIR");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 1)
            {
                Console.WriteLine(tamaH);
            }
            else if (eleccion == 2)
            {
                bool tieneBlunt = false;
                string nombreFum = "";
                foreach (Item item in Duenyo.Items)
                {
                    if (item.Nombre == "Porro artesanal(5 g)" || item.Nombre == "PorroSupremo(Sorpresa g)")
                    {
                        tieneBlunt = true;
                        nombreFum = item.Nombre;
                    }
                }

                if (tieneBlunt)
                {
                    NivelHigh += Fumar(nombreFum);
                    if (tamaH.NivelHigh <= 5)
                    {
                        tamaH.EstadoFum = EstadoHigh.Normal;
                    }
                    else if (tamaH.NivelHigh <= 15)
                    {
                        tamaH.EstadoFum = EstadoHigh.Castañuela;

                    }
                    else if (tamaH.NivelHigh <= 25)
                    {
                        tamaH.EstadoFum = EstadoHigh.Empastrao;

                    }
                    else if (tamaH.NivelHigh <= 30)
                    {
                        tamaH.EstadoFum = EstadoHigh.Tofu;

                    }
                    else if (tamaH.NivelHigh <= 45)
                    {
                        tamaH.EstadoFum = EstadoHigh.Brote;

                    }
                    else
                    {
                        tamaH.EstadoFum = EstadoHigh.ModoZen;
                    }
                    Console.WriteLine($"Fumada Actual = {tamaH.EstadoFum}");
                }
                else
                {
                    Console.WriteLine("No tienes nada para fumar, ve a la tienda.");
                    return;
                }

            }
            else if (eleccion == 3)
            {
                Tienda tiendaHippie = new Tienda();

                tiendaHippie.MostrarItems();
                Console.WriteLine($"¿Que articulo deseas comprar?\n(escriba el numero)\nMonedas Disponibles={Duenyo.Dinero}");
                int numArticulo = Convert.ToInt32(Console.ReadLine());
                tiendaHippie.Comprar(numArticulo, Duenyo, tamaH);
            }

            else if (eleccion == 4)
            {
                Vivo = false;
            }
            else
            {
                Console.WriteLine("Eleccion Incorrecta");
                return;
            }
        }
    }
}



