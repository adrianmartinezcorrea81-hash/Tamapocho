using System.Text.Json;

public class SalirGuardado //Voy a crear un cs para esto para no acumular mas codigo en el menu de cada tamapocho y asi todo se entiende mejor
{
    

    public static bool SalirCunyao(Tamapochocunyao tamapochocunyao, Jugador jugador)
    {
        Console.Clear();
        Console.WriteLine("¿Quieres guardar la partida antes de salir?\n1-Sí\n2-No");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        if (eleccion == 1)
        {
            DatosPartida datos = new DatosPartida
            {
                NombreJugador = jugador.NombreJug,
                EdadJugador = jugador.EdadJug,
                Dinero = jugador.Dinero,
                TipoTamapocho = "Cunyao",
                NombreTama = tamapochocunyao.NombreTama,
                VidaTama = tamapochocunyao.VidaTama,
                Energia = tamapochocunyao.Energia,
                Felicidad = tamapochocunyao.Felicidad,
                Nivel = tamapochocunyao.Nivel,
                AtributoEspecial = tamapochocunyao.NivelChistes,
                Estado = tamapochocunyao.RangoCunyao.ToString()
            };

            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("partida.json", json);
            Console.WriteLine("Partida Guardada....");
            return true;

        }
        else if (eleccion == 2)
        {
            Console.WriteLine("Partida No Guardada");
            return true;

        }
        else
        {
            Console.WriteLine("Respuesta incorrecta ahora te mueres por pringao");
            return false;

        }


    }
    public static bool SalirGym(TamapochoGymBro tamapochoGymBro, Jugador jugador)
    {
        Console.Clear();
        Console.WriteLine("¿Quieres guardar la partida antes de salir?\n1-Sí\n2-No");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        if (eleccion == 1)
        {
            DatosPartida datos = new DatosPartida
            {
                NombreJugador = jugador.NombreJug,
                EdadJugador = jugador.EdadJug,
                Dinero = jugador.Dinero,
                TipoTamapocho = "Gym",
                NombreTama = tamapochoGymBro.NombreTama,
                VidaTama = tamapochoGymBro.VidaTama,
                Energia = tamapochoGymBro.Energia,
                Felicidad = tamapochoGymBro.Felicidad,
                Nivel = tamapochoGymBro.Nivel,
                AtributoEspecial = tamapochoGymBro.FuerzaTama,
                Estado = tamapochoGymBro.EstadoEnForma.ToString()
            };

            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("partida.json", json);
            Console.WriteLine("Partida Guardada....");
            return true;

        }
        else if (eleccion == 2)
        {
            Console.WriteLine("Partida No Guardada");
            return true;

        }
        else
        {
            Console.WriteLine("Respuesta incorrecta ahora te mueres por pringao");
            return false;

        }
    }
    public static bool SalirHippie(TamapochoHippie tamapochoHippie, Jugador jugador)
    {
        Console.Clear();
        Console.WriteLine("¿Quieres guardar la partida antes de salir?\n1-Sí\n2-No");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        if (eleccion == 1)
        {
            DatosPartida datos = new DatosPartida
            {
                NombreJugador = jugador.NombreJug,
                EdadJugador = jugador.EdadJug,
                Dinero = jugador.Dinero,
                TipoTamapocho = "Hippie",
                NombreTama = tamapochoHippie.NombreTama,
                VidaTama = tamapochoHippie.VidaTama,
                Energia = tamapochoHippie.Energia,
                Felicidad = tamapochoHippie.Felicidad,
                Nivel = tamapochoHippie.Nivel,
                AtributoEspecial = tamapochoHippie.NivelHigh,
                Estado = tamapochoHippie.EstadoFum.ToString()
            };

            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("partida.json", json);
            Console.WriteLine("Partida Guardada....");
            return true;

        }
        else if (eleccion == 2)
        {
            Console.WriteLine("Partida No Guardada");
            return true;

        }
        else
        {
            Console.WriteLine("Respuesta incorrecta ahora te mueres por pringao");
            return false;

        }
    }
    public static bool SalirInfor(TamapochoInformatico tamapochoInformatico, Jugador jugador)
    {
        Console.Clear();
        Console.WriteLine("¿Quieres guardar la partida antes de salir?\n1-Sí\n2-No");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        if (eleccion == 1)
        {
            DatosPartida datos = new DatosPartida
            {
                NombreJugador = jugador.NombreJug,
                EdadJugador = jugador.EdadJug,
                Dinero = jugador.Dinero,
                TipoTamapocho = "Infor",
                NombreTama = tamapochoInformatico.NombreTama,
                VidaTama = tamapochoInformatico.VidaTama,
                Energia = tamapochoInformatico.Energia,
                Felicidad = tamapochoInformatico.Felicidad,
                Nivel = tamapochoInformatico.Nivel,
                AtributoEspecial = tamapochoInformatico.NivelCafeina,
                Estado = tamapochoInformatico.estadoEnergetico.ToString()
            };

            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("partida.json", json);
            Console.WriteLine("Partida Guardada....");
            return true;

        }
        else if (eleccion == 2)
        {
            Console.WriteLine("Partida No Guardada");
            return true;

        }
        else
        {
            Console.WriteLine("Respuesta incorrecta ahora te mueres por pringao");
            return false;

        }
    }
    public static bool SalirTikTok(TamapochoTikTok tamapochoTikTok, Jugador jugador)
    {
        Console.Clear();
        Console.WriteLine("¿Quieres guardar la partida antes de salir?\n1-Sí\n2-No");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        if (eleccion == 1)
        {
            DatosPartida datos = new DatosPartida
            {
                NombreJugador = jugador.NombreJug,
                EdadJugador = jugador.EdadJug,
                Dinero = jugador.Dinero,
                TipoTamapocho = "TikTok",
                NombreTama = tamapochoTikTok.NombreTama,
                VidaTama = tamapochoTikTok.VidaTama,
                Energia = tamapochoTikTok.Energia,
                Felicidad = tamapochoTikTok.Felicidad,
                Nivel = tamapochoTikTok.Nivel,
                AtributoEspecial = tamapochoTikTok.Seguidores,
                Estado = tamapochoTikTok.Sexo.ToString()

                
            };

            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("partida.json", json);
            Console.WriteLine("Partida Guardada....");
            return true;

        }
        else if (eleccion == 2)
        {
            Console.WriteLine("Partida No Guardada");
            return true;

        }
        else
        {
            Console.WriteLine("Respuesta incorrecta ahora te mueres por pringao");
            return false;

        }
    }

}