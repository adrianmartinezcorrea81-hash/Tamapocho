public class Tamapochocunyao : Tamapocho , Itamcunyao
{
    
    public double NivelChistes; //Cada vez que el tamapocho cuente un chiste se le sumara a este nivel, al igual que en el metodo de GrabarTikTok
    private bool Vivo; //Será la condicion para que puedas jugar

    public enum EstadodeCunyao
    {
       
        Normal, ConPalilloEnLaboca, ExpertoEnCriptos, AsadorDeBarbacoas, Tolosa //Tolosa(To lo sabe)
    }

    public Tamapochocunyao(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double NivelChistes, double Nivel, bool vivo):base( nombreTama,  vidaTama,  duenyo,  energia,  felicidad, Nivel, vivo)
    {
        this.NivelChistes= NivelChistes;
        Vivo=true;
    }
    
    public double ContarChistes() //Cada vez que cuente un chiste se le sumara al nivel de chistes
    {
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

            Vivo=false;
        }
    }
    
}