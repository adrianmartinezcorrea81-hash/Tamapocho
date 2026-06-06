public class Tamapochocunyao : Tamapocho, Itamcunyao
{

    public double NivelChistes; //Cada vez que el tamapocho cuente un chiste se le sumara a este nivel, al igual que en el metodo de GrabarTikTok
    private bool Vivo; //Será la condicion para que puedas jugar

    public EstadodeCunyao RangoCunyao;

    public enum EstadodeCunyao
    {

        Normal, ConPalilloEnLaboca, ExpertoEnCriptos, AsadorDeBarbacoas, Tolosa, INSUFRIBLE //Tolosa(To lo sabe)
    }

    public Tamapochocunyao(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double NivelChistes, double Nivel, bool vivo, EstadodeCunyao RangoCunyao) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        this.NivelChistes = NivelChistes;
        this.RangoCunyao = RangoCunyao;
        Vivo = true;
    }

    public double ContarChistes() //Cada vez que cuente un chiste se le sumara al nivel de chistes
    {
        //Con un Random voy a crear chistes distintos para que el juego no sea tan monotono
        Random aleatorio = new Random();

        int chiste = aleatorio.Next(1, 7);


        switch (chiste)
        {
            case 1:
                Console.WriteLine("Por qué el portero del Athletic no pasa frío?\nporque juega con 10 mantas");
                break;
            case 2:
                Console.WriteLine("Van un negro, un moro y un gitano en un coche.\n¿Quien conduce?\nLa Guardia Civil.");
                break;
            case 3:
                Console.WriteLine("Un chico le dice a una chica: dame tu movil.\nLa chica le contesta: si y yo con que llamo?");
                break;
            case 4:
                Console.WriteLine("hijo:mama mama en el cole me llaman quiere lo todo\nmadre: va que les den morcilla!\nhijo: y para mi que???");
                break;
            case 5:
                Console.WriteLine("Esto es un esqueleto que entra en un bar y dice: perdone me pone una cerveza, y una fregona");
                break;
            case 6:
                Console.WriteLine("-Papa papa! Quiero ir al circo!!\n- No hijo, quien quiera verte que venga a casa.");
                break;
            case 7:
                Console.WriteLine("- Mamá, mamá, tengo hambre.\n- Pues fríete un huevo, hijo.\n- Ostia, mamá…. ¿por que no te fríes tú una teta?");
                break;
        }

        return 0.5;
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel}\nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nNivel de Chistes= {NivelChistes}";
    }


    public void IniciarJuegoInfor(Tamapochocunyao tamaCunya)
    {


        while (Vivo)
        {
            JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
            Console.WriteLine(tamaCunya);

            Console.WriteLine($"1-Ver Estado Actual De {tamaCunya.NombreTama}\n2-Contar Un Chiste\n3-Tienda\n4-SALIR");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 1)
            {
                Console.WriteLine(tamaCunya);
            }
            else if (eleccion == 2)
            {
                tamaCunya.NivelChistes += ContarChistes();
                if (tamaCunya.NivelChistes <= 5)
                {
                    tamaCunya.RangoCunyao = EstadodeCunyao.Normal;
                }
                else if (tamaCunya.NivelChistes <= 10)
                {
                    tamaCunya.RangoCunyao = EstadodeCunyao.ConPalilloEnLaboca;
                }
                else if (tamaCunya.NivelChistes <= 15)
                {
                    tamaCunya.RangoCunyao = EstadodeCunyao.AsadorDeBarbacoas;
                }
                else if (tamaCunya.NivelChistes <= 20)
                {
                    tamaCunya.RangoCunyao = EstadodeCunyao.ExpertoEnCriptos;
                }
                else if (tamaCunya.NivelChistes <= 25)
                {
                    tamaCunya.RangoCunyao = EstadodeCunyao.Tolosa;
                }
                else
                {
                    tamaCunya.RangoCunyao = EstadodeCunyao.INSUFRIBLE;
                }
                Console.WriteLine($"Rango de cuñao Actual = {tamaCunya.RangoCunyao}");

            }
            else if (eleccion == 3)
            {
                Tienda tiendacunyao = new Tienda();

                tiendacunyao.MostrarItems();
                Console.WriteLine($"¿Que articulo deseas comprar?\n(escriba el numero)\nMonedas Disponibles={Duenyo.Dinero}");
                int numArticulo = Convert.ToInt32(Console.ReadLine());
                tiendacunyao.Comprar(numArticulo, Duenyo, tamaCunya);
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
