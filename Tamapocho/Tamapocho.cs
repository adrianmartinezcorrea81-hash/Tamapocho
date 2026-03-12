public abstract class Tamapocho //abstract pq un tamapocho necesita un tipo para crear uno 
{
    public double Nivel;
    public string NombreTama;
    public int VidaTama;
    private bool Vivo; //Será la condicion para que puedas jugar

    
    public Jugador Duenyo;

    public int Energia;
    public int Felicidad;

    public Tamapocho(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double nivel, bool vivo)
    {
    
        NombreTama=nombreTama;
        VidaTama=vidaTama;
        Duenyo=duenyo;
        Energia=energia;
        Felicidad=felicidad;
        Nivel=nivel;
        Vivo=vivo;
 
    }


    
}



