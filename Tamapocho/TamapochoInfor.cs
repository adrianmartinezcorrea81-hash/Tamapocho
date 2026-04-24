public class TamapochoInformatico : Tamapocho , ITamInfor
{
    
    public double NivelCafeina;
    private bool Vivo; //Será la condicion para que puedas jugar

    public enum EstadoEnergitico
    {
        DEPRIMIDO, NORMAL, EMOCIONADO, HIPERACTIVO, PAROCARDIACO

    }

    public TamapochoInformatico(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double NivelCafeina, double Nivel, bool vivo):base( nombreTama,  vidaTama,  duenyo,  energia,  felicidad, Nivel, vivo)
    {
        this.NivelCafeina= NivelCafeina;
        Vivo=true;
    }
    
    public double BeberMonster() //Cada vez que beba una monster se le sumara al nivel de cafeina al igual que en el metodo de Fumar
    {
        return 0.5;
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel}\nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nNivel de Cafeina= {NivelCafeina}";
    }


    public void IniciarJuegoInfor(TamapochoInformatico tamaInfor)
    {
       

        while (Vivo)
        {
            JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
            Console.WriteLine(tamaInfor);

            Vivo=false;
        }
    }
    
}