public class DatosPartida
{
    public string NombreJugador { get; set; }
    public int EdadJugador { get; set; }
    public int Dinero { get; set; }
    public string TipoTamapocho { get; set; }
    public string NombreTama { get; set; }
    public int VidaTama { get; set; }
    public int Energia { get; set; }
    public int Felicidad { get; set; }
    public int Nivel { get; set; }
    public double AtributoEspecial { get; set; } // NivelHigh, FuerzaTama, NivelCafeina, Seguidores y NivelChistes
    public string Estado { get; set; } // el enum en string
}