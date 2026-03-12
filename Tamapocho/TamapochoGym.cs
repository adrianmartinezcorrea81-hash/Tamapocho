public class TamapochoGymBro: Tamapocho, IGymbro
{
    public double FuerzaTama; //En el minijuego que tenga si no tiene la fuerza suficiente para yo que se mover algo que lo tengas que chetar mas 

    public TamapochoGymBro(string nombreTama, int vidaTama, Jugador duenyo, int energia, int felicidad, int fuerzaTama, double Nivel,bool vivo):base( nombreTama,  vidaTama,  duenyo,  energia,  felicidad, Nivel,vivo)
    {
        FuerzaTama=fuerzaTama;
        
    }
    public double entrenar() //cada vez que entrene pues se le va subiendo la fuerza y además esto tmbn cambiará el valor del enum
    {
        return 0.2;
    }

    public override string ToString()
    {
        return $"Información de tu tamapocho\nTipo= {this.GetType()}\nNivel= {Nivel} \nNombre= '{NombreTama}'\nVida= {VidaTama}\nDueño= '{Duenyo.NombreJug},{Duenyo.EdadJug}'\nEnergia= {Energia}\nFelicidad= {Felicidad}\nFuerza= {FuerzaTama}";
    }    

    public void IniciarJuegoGym(TamapochoGymBro tamaGym)
    {
            JuegoTam.Texto($"Bienvenido {Duenyo.NombreJug}, has elegido a tu tamapocho a continuación tendrás su información:");
            Console.WriteLine(tamaGym);

    }
}
   
    
