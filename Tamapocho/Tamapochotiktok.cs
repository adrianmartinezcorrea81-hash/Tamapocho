public enum Genero
{
    HOMBRE, MUJER
}

public class TamapochoTikTok : Tamapocho
{
    public Genero Sexo;

    public TamapochoTikTok(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, double Nivel, bool vivo, /*Exclu*/ Genero sexo) : base(nombreTama, vidaTama, duenyo, energia, felicidad, Nivel, vivo)
    {
        Sexo = sexo;
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
