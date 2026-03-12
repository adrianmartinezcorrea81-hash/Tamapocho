public class TamapochoHippie : Tamapocho , ITamHippie
{
    public double NivelHigh;
    private bool Vivo; //Será la condicion para que puedas jugar
    public enum EstadoHigh
    
    {
        Normal, Castañuela, Empastrao, Tofu, Brote
    }
    public TamapochoHippie(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double nivelHigh, double Nivel, bool vivo):base( nombreTama,  vidaTama,  duenyo,  energia,  felicidad, Nivel, vivo)
    {
        NivelHigh=nivelHigh;
        Vivo=true;
    }
    public double Fumar() //Cada vez que fume devolvera 0.5 que mas tarde se le sumará a NivelHigh
    {
        return 0.5;
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
            Vivo=false;
        }
    }
}



