public enum Genero
{
    HOMBRE, MUJER
}

public class TamapochoTikTok : Tamapocho
{
    public Genero Sexo;
    public int Seguidores; //He pensado que seria interesante que al igual que en los otros tamapochos hay niveles de algo este no sea menos asi que lo hare segun los seguidores que pueden ir aumentando grabando ttks

    public TamapochoTikTok(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double Nivel, bool vivo, /*Exclu*/ Genero sexo,int seguidores) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        Sexo = sexo;
        Seguidores=seguidores;
    }
    public double GrabarTikTok()
    {
        return 0; //provisional esto tengo que pensarlo
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel} \nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nGenero= {this.Sexo.ToString().ToUpper()}";
    }

}
