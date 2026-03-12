public class Jugador
{
    public string NombreJug{get;}
    public int EdadJug;

    public Item [] items;

    public Jugador(string nombreJug, int edadJug)
    {
        NombreJug=nombreJug;
        EdadJug=edadJug;
    }
}