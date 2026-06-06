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
    }
}