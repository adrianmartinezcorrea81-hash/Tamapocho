public class Jugador
{
    public string NombreJug{get;}
    public int EdadJug;

    public int Dinero; //Le añado dinero para que pueda gastar en la tienda

    public List<Item> Items= new List<Item>();

    public Jugador(string nombreJug, int edadJug)
    {
        NombreJug=nombreJug;
        EdadJug=edadJug;
        Dinero=50; //Le añado un dinero base al jugador para que asi resulte un poco mas facil el juego 
    }
}