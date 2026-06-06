public class Item
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Precio { get; set; } // Todavia no lo usamos, pero lo dejo para implementarlo en un futuro
    public string Efecto { get; set; } // COMO Energia+10 o Felicidad-5

    public TipoEfecto TipoEfecto;
    public int ValorEfecto;

    public Item(string nombre, string descripcion, int precio, string efecto, TipoEfecto tipoEfecto, int valorEfecto)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Efecto = efecto;
        TipoEfecto = tipoEfecto;
        ValorEfecto = valorEfecto;
    }


}