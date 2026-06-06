using System.Transactions;

public class TamapochoGymBro : Tamapocho, IGymbro
{
    public double FuerzaTama; //En el minijuego que tenga si no tiene la fuerza suficiente para yo que se mover algo que lo tengas que chetar mas 

    public NivelCulturista EstadoEnForma;
    public enum NivelCulturista
    {
        FLAKITO, CALISTENICO, TIOGRANDE, ENORME, CULTURISTANATTY, CHUZAO //CHUZAO SOLO CON SUPPROHI
    }
    private bool Vivo;

    public TamapochoGymBro(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, int fuerzaTama, double Nivel, bool vivo, NivelCulturista EstadoEnForma) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        FuerzaTama = fuerzaTama;
        this.EstadoEnForma = EstadoEnForma;
        Vivo = true;
    }
    public double entrenar() //cada vez que entrene pues se le va subiendo la fuerza y además esto tmbn cambiará el valor del enum
    {
        string material = "";
        bool tieneMaterial = false;
        foreach (Item item in Duenyo.Items)
        {
            if (item.Nombre == "Mancuernas de titanio")
            {
                tieneMaterial = true;
                material = item.Nombre;
            }
        }

        if (tieneMaterial)
        {
            return 1;
        }
        else
        {

            return 0.5;

        }
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel} \nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nFuerza= {FuerzaTama}";
    }

    public void IniciarJuegoGym(TamapochoGymBro tamaGym)
    {

        while (Vivo)
        {
            JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
            Console.WriteLine(tamaGym);

            Console.WriteLine($"1-Ver Estado Actual De {tamaGym.NombreTama}\n2-Entrenar\n3-Tienda\n4-SALIR");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 1)
            {
                Console.WriteLine(tamaGym);
            }
            else if (eleccion == 2)
            {

                bool NoNatty = false;
                foreach (Item item in Duenyo.Items)
                {
                    if (item.Nombre == "Suplemento prohibido")
                    {
                        NoNatty = true;
                    }
                }
                FuerzaTama += entrenar();
                if (tamaGym.FuerzaTama <= 5)
                {
                    tamaGym.EstadoEnForma = NivelCulturista.FLAKITO;
                }
                else if (tamaGym.FuerzaTama <= 15)
                {
                    tamaGym.EstadoEnForma = NivelCulturista.CALISTENICO;
                }
                else if (tamaGym.FuerzaTama <= 25)
                {
                    tamaGym.EstadoEnForma = NivelCulturista.TIOGRANDE;
                }
                else if (tamaGym.FuerzaTama <= 35)
                {
                    tamaGym.EstadoEnForma = NivelCulturista.ENORME;
                }
                else if (tamaGym.FuerzaTama <= 40)
                {
                    tamaGym.EstadoEnForma = NivelCulturista.CULTURISTANATTY;
                }
                else if (tamaGym.FuerzaTama <= 45 && NoNatty)
                {
                    tamaGym.EstadoEnForma = NivelCulturista.CHUZAO;
                }

                Console.WriteLine($"Tu Estado De Forma Actual = {tamaGym.EstadoEnForma}");


            }
            else if (eleccion == 3)
            {
                Tienda tiendaGym = new Tienda();

                tiendaGym.MostrarItems();
                Console.WriteLine($"¿Que articulo deseas comprar?\n(escriba el numero)\nMonedas Disponibles={Duenyo.Dinero}");
                int numArticulo = Convert.ToInt32(Console.ReadLine());
                tiendaGym.Comprar(numArticulo, Duenyo, tamaGym);
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


