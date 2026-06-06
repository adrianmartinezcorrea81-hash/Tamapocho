public class TamapochoInformatico : Tamapocho, ITamInfor
{

    public double NivelCafeina;
    private bool Vivo; //Será la condicion para que puedas jugar

    public EstadoEnergetico estadoEnergetico;

    public enum EstadoEnergetico
    {
        DEPRIMIDO, NORMAL, EMOCIONADO, HIPERACTIVO, PAROCARDIACO, SENIOR

    }

    public TamapochoInformatico(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double NivelCafeina, double Nivel, bool vivo, EstadoEnergetico estadoEnergetico) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        this.NivelCafeina = NivelCafeina;
        this.estadoEnergetico = estadoEnergetico;
        Vivo = true;
    }

    public double BeberMonster() //Cada vez que beba una monster se le sumara al nivel de cafeina al igual que en el metodo de Fumar
    {
        return 0.5;
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel}\nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nNivel de Cafeina= {NivelCafeina}\nDinero={Duenyo.Dinero}";
    }


    public void IniciarJuegoInfor(TamapochoInformatico tamaInfor)
    {

            JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
            Console.WriteLine(tamaInfor);

        while (Vivo)
        {

            Console.WriteLine($"1-Ver Estado Actual De {tamaInfor.NombreTama}\n2-Beberse una Monster \n3-Tienda\n4-Jugar Minijuego\n5-SALIR");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 1)
            {
                Console.WriteLine(tamaInfor);
            }
            else if (eleccion == 2)
            {
                bool tieneMonster = false;
                string nombreMonster = "";
                foreach (Item item in Duenyo.Items)
                {
                    if (item.Nombre == "Monster Verde(normal)" || item.Nombre == "Monster Blanco(sin azucar)")
                    {
                        tieneMonster = true;
                        nombreMonster = item.Nombre;
                    }

                }

                if (tieneMonster)
                {

                    bool OtroLevel = false;
                    foreach (Item item in Duenyo.Items)
                    {
                        if (item.Nombre == "Sudadera De Linux")
                        {
                            OtroLevel = true;
                        }
                    }
                    NivelCafeina += BeberMonster();
                    if (NivelCafeina <= 5)
                    {
                        estadoEnergetico = EstadoEnergetico.DEPRIMIDO;
                    }
                    else if (NivelCafeina <= 15)
                    {
                        estadoEnergetico = EstadoEnergetico.NORMAL;

                    }
                    else if (NivelCafeina <= 25)
                    {
                        estadoEnergetico = EstadoEnergetico.EMOCIONADO;

                    }
                    else if (NivelCafeina <= 35)
                    {
                        estadoEnergetico = EstadoEnergetico.HIPERACTIVO;

                    }
                    else if (NivelCafeina <= 45)
                    {
                        estadoEnergetico = EstadoEnergetico.PAROCARDIACO;

                    }
                    else if (NivelCafeina > 45 && OtroLevel)
                    {
                        estadoEnergetico = EstadoEnergetico.SENIOR;

                    }
                    Console.WriteLine($"Estado energético actual  = {estadoEnergetico}");


                }
                else
                {
                    Console.WriteLine("No tienes nada para beber, ve a la tienda.");
                    continue;
                }


            }
            else if (eleccion == 3)
            {
                Tienda tiendaGym = new Tienda();

                tiendaGym.MostrarItems();
                Console.WriteLine($"¿Que articulo deseas comprar?\n(escriba el numero)\nMonedas Disponibles={Duenyo.Dinero}");
                int numArticulo = Convert.ToInt32(Console.ReadLine());
                tiendaGym.Comprar(numArticulo, Duenyo, tamaInfor);
            }

            else if (eleccion == 4)
            {
                Duenyo.Dinero+=Minijuego.MinijuegoInfor();
            }
            else if (eleccion == 5)
            {
                Vivo = false;
            }
            else
            {
                Console.WriteLine("Eleccion Incorrecta");
                continue;
            }
            if (tamaInfor.VidaTama <= 0)
            {
                JuegoTam.GameOver(tamaInfor);
                Vivo = false;
            }
        }
    }

}