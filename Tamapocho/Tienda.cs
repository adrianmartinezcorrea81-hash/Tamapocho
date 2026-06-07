public class Tienda
{
    private List<Item> items;


    public Tienda()
    {
        items = new List<Item>();
        //Voy a organizar los items por tipso de tamapocho al crearlos, pero que podran comprarlo sin importar el tamampocho que estes jugando,
        //Lo hago asi para aclararme yo, sin mas

        // Tamapochos en general
        Item bocataNocilla = new Item("Bocata de Nocilla", "Bocata de Nocilla el cual la Nocilla desborda hasta del bocadillo...", 5, "Aumentará XP para subir de nivel\nTen en cuenta que lleva mucho Azucar...", TipoEfecto.SubirXP, 10);
        Item Botiquin = new Item("Botiquin", "En ocasiones es necesario invertir en salud para seguir viviendo...", 20, "La vida aumentará hasta estar completa", TipoEfecto.SubirVida, 100);
        Item Almohada = new Item("Almohada", "Dormir es necesario para una persona, para tu tamapocho no es distinto...", 15, "Aumentará en un 20% la Energia de tu tamapocho", TipoEfecto.SubirEnergia, 20);
        Item Pildorafelicidad = new Item("Píldora de la felicidad", "Cuando ni tu compañia anima a tu tamapocho es necesario darle un empujon.", 15, "Aumentará en un 25% la Felicidad de tu tamapocho", TipoEfecto.SubirFelicidad, 25);
        Item Chuchería = new Item("Chuchería", "Un pequeño capricho para tu tamapocho nunca viene mal", 2, "Aumentará un 3% la Felicidad de tu tamapocho pero piensa que llevan mucho azucar...", TipoEfecto.SubirFelicidad, 3);
        Item Vendas = new Item("Vendas", "Pequeña inversion en la salud de tu tamapocho para que pueda recuperarse", 10, "+25% a la estadistica de Vida de tu tamapocho", TipoEfecto.SubirVida, 25);
        Item Cafe = new Item("Cafe", "Pequeña taza de café para dar ese impulso que a veces es necesario", 3, "+25% a la estadistica de Energia de tu tamapocho, muy bien al principio pero luego habrá bajon...", TipoEfecto.SubirEnergia, 25);
        AgregarItem(bocataNocilla);
        AgregarItem(Botiquin);
        AgregarItem(Almohada);
        AgregarItem(Pildorafelicidad);
        AgregarItem(Chuchería);
        AgregarItem(Vendas);
        AgregarItem(Cafe);

        // TamaGymbro
        Item ProteinaEnPolvo = new Item("1KG de Proteína en polvo", "Para llegar al otro nivel la comida no es suficiente ayuda a tu tamapocho a ser ese culturista que quiere ser.", 500, "+25% a la estadistica de Fuerza de tu tamapocho", TipoEfecto.SubirFuerza, 25);
        Item Mancuernas = new Item("Mancuernas de titanio", "Tu tamapocho está deseando buen material para entrenar y estas mancuernas es lo que realmente necesita para llegar a otro nivel.", 1000, "Aumentara la fuerza segun vayas entrenando con este material(Cantidad de usos=200 entrenamientos)", TipoEfecto.SubirFuerza, 40);
        Item Supprohibido = new Item("Suplemento prohibido", "Ya somos conscientes que si de verdad tu tamapocho y tu deseais llegar a la tarima hay que hacer trampas, PIENSALO BIEN.", 6767, "Efectos desconocidos", TipoEfecto.DesbloquearEstado, 0);
        AgregarItem(ProteinaEnPolvo);
        AgregarItem(Mancuernas);
        AgregarItem(Supprohibido);

        // TamaHippie
        Item Porro = new Item("Porro artesanal(5 g)", "Nunca es demasiado grande para el tamapocho hippie pero dale unas caladas y verás como actua...", 500, "Aumentara el Nivel de High de tu tamapocho Hippie", TipoEfecto.SubirNivelHigh, 20);
        Item Grimorio = new Item("Grimorio de Chakras", "Ayuda a que tu tamapocho Hippie conecte consigo mismo y asi pueda ayudar al resto a que se encuentren.", 1200, "Aumentara el Nivel de High de tu tamapocho Hippie poco", TipoEfecto.SubirNivelHigh, 5);
        Item PorroSupremo = new Item("PorroSupremo(Sorpresa g)", "Nunca es demasiado grande para el tamapocho hippie pero este artilugio puede que si, asi que controla la dosis...", 6767, "Aumentara el Nivel de High de tu tamapocho Hippie", TipoEfecto.DesbloquearEstado, 0);
        AgregarItem(Porro);
        AgregarItem(Grimorio);
        AgregarItem(PorroSupremo);

        // TamaTiktoker
        Item AroDeLuz = new Item("Aro de Luz", "Nunca es suficiente luz a la hora de grabar un video.", 500, "Aumentara la cantidad de seguidores que recibas por video.", TipoEfecto.SubirSeguidores, 15);
        Item FiltroEx = new Item("Filtro Exclusivo de Videos", "Llega el punto donde a tu tamapocho no le sirve unicamente tener buena iluminacion y quiere ir a mas.", 1150, "Aumentara la cantidad de seguidores que recibas por video, con mas impacto que el Aro de Luz", TipoEfecto.SubirSeguidores, 30);
        Item NuevoMovil = new Item("Nuevo Movil De Ultima Generacion", "Este articulo es sin duda el salto de calidad que estan pidiendo tus videos para llegar a la cima", 6767, "Aumentara la cantidad de seguidores de forma exponente, casi de forma ilógica", TipoEfecto.SubirSeguidores, 200);
        AgregarItem(AroDeLuz);
        AgregarItem(FiltroEx);
        AgregarItem(NuevoMovil);

        // TamapochoInformatico
        Item Aricularescab = new Item("Auriculares con cable", "Un verdadero informatico detesta unos auriculares inhalambrico, \"Ese tipo de auriculares para los normies que quieren tener peor calidad de audio...\"", 500, "Aumentara el estado de energia de tu Tamapocho Informatico muy poco.", TipoEfecto.SubirCafeina, 5);
        Item MonsterNormal = new Item("Monster Verde(normal)", "Un verdadero informatico podria estar todo el dia bebiendo monsters", 500, "Aumentara el estado de energia de tu Tamapocho Informatico pero cuidado con el azucar", TipoEfecto.SubirCafeina, 20);
        Item MonsterBlanco = new Item("Monster Blanco(sin azucar)", "Un verdadero informatico podria estar todo el dia bebiendo monsters, pero bueno si tu Tamapocho Informatico le importa el azucar esta es tu opcion", 500, "Aumentara el estado de energia de tu Tamapocho Informatico pero cuidado con el azucar", TipoEfecto.SubirCafeina, 15);
        Item SetUp = new Item("SetUp con RGB", "Un verdadero informatico necesita su SetUp hasta arriba de RGB y esta es la mejor opcion sin duda en cuanto a perifericos y RGB...", 1150, "Incrementará la energia de tu Tamapocho hasta el fin del juego a la hora de beber monsters", TipoEfecto.SubirEnergia, 30);
        Item SudaderaDeLinux = new Item("Sudadera De Linux", "Con este articulo tu tamapocho ya ha alcanzado el nivel mas alto de un informatico, ya puedes darlo por perdido....", 6767, "Si decidiste comprar este articulo no sabrás el efecto hasta que lo veas con tus propios ojos...", TipoEfecto.DesbloquearEstado, 0);
        AgregarItem(Aricularescab);
        AgregarItem(MonsterNormal);
        AgregarItem(MonsterBlanco);
        AgregarItem(SetUp);
        AgregarItem(SudaderaDeLinux);

        // TamapochoCunyao
        Item PalilloMad = new Item("Palillo de Madera", "Un cuñao de verdad siempre lleva su palillo en la boca durante los 365 dias del año(es el mismo siempre)", 500, "Aumentara el estado de cuñao de tu Tamapocho Cuñao muy poco y al contar chistes darás mas gracia (Duracion= 100Chistes.)", TipoEfecto.SubirNivelChistes, 10);
        Item CamiAtl = new Item("Camiseta del Atleti", "La camiseta por excelencia de los cuñaos, regalasela a tu Tamapocho sin pensarlo, le encantará sin duda.(NO ORIGINAL)", 1200, "Aumentara el estado de cuñao de tu Tamapocho Cuñao muy poco y al contar chistes darás mas gracia (Duracion= 200Chistes.)", TipoEfecto.SubirNivelChistes, 20);
        Item Riñonera = new Item("Riñonera", "Accesorio que no le debe faltar a tu Tamapocho Cuñao si de verdad quieres que la gente se ria con sus chistes, o de el.", 1800, "Aumentara el estado de cuñao de tu Tamapocho Cuñao muy poco y al contar chistes darás mas gracia (Duracion= 220Chistes.)", TipoEfecto.SubirNivelChistes, 25);
        Item PacksCerves = new Item("PackCerves", "Con la excusa de \"Estos dos Pack de Cervezas me duran todo el puente tu tamapocho\" se beberá estas dos cervezas como dice el de \"una sentada\"", 1800, "Ir tan borracho para este de Tamapocho es INSUFRIBLE descubre tu mismo los efectos", TipoEfecto.DesbloquearEstado, 0);
        AgregarItem(PalilloMad);
        AgregarItem(CamiAtl);
        AgregarItem(Riñonera);
        AgregarItem(PacksCerves);




    }

    public void AgregarItem(Item item)
    {
        items.Add(item);
    }

    public void MostrarItems()
    {
        Console.WriteLine("=== TIENDA ===");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {items[i].Nombre} - {items[i].Precio} monedas");
            Console.WriteLine($"{items[i].Descripcion}");
            Console.WriteLine($"Efecto: {items[i].Efecto}");
            Console.WriteLine("");
            Console.WriteLine("");


        }
    }

    public void Comprar(int numProduct, Jugador comprador, Tamapocho tama)
    {
        if (numProduct < 0 || numProduct >= items.Count)
        {
            Console.WriteLine("Producto no encontrado.");
            return;
        }
        if (comprador.Dinero < items[numProduct].Precio)
        {
            Console.WriteLine($"Necesitas {items[numProduct].Precio - comprador.Dinero} Tamacoins para poder comprar este producto ");
        }
        else
        {
            Console.WriteLine($"Éxito en la compra del producto {items[numProduct].Nombre}");


            comprador.Dinero -= items[numProduct].Precio;//Le descontamos el dinero al comprador 
            comprador.Items.Add(items[numProduct]);
            AplicarEfecto(items[numProduct], tama);
            JuegoTam.SubirXP(tama, 2); // Asi cuando compras ganas xp


        }
    }
    public void AplicarEfecto(Item item, Tamapocho tama)
    {
        switch (item.TipoEfecto)
        {
            case TipoEfecto.SubirVida:
                tama.VidaTama += (int)(tama.VidaTama * item.ValorEfecto / 100.0);
                Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto}% de Vida");
                break;

            case TipoEfecto.SubirEnergia:
                tama.Energia += (int)(tama.Energia * item.ValorEfecto / 100.0);
                Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto}% de Energía");

                //Me he fijado que no le habia puesto el subefecto ni al Cafe ni a la chuche
                if (item.Nombre == "Cafe")
                {
                    tama.VidaTama -= 5;
                    tama.Felicidad -= 5;
                    Console.WriteLine("El bajón del café ha reducido 5 de Vida y 5 de Felicidad...");
                }
                break;

            case TipoEfecto.SubirFelicidad:
                tama.Felicidad += (int)(tama.Felicidad * item.ValorEfecto / 100.0);
                Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto}% de Felicidad");
                if (item.Nombre == "Chuchería")
                {
                    tama.VidaTama -= 3;
                    Console.WriteLine("Tanta azúcar ha reducido 3 de Vida...");
                }
                break;

            case TipoEfecto.SubirXP:
                tama.Nivel += item.ValorEfecto;
                Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto} de XP");
                break;

            case TipoEfecto.SubirFuerza:
                if (tama is TamapochoGymBro gym) //HE BUSCADO ESTA SINTAXIS PORQUE NO SABIA COMO COMPROBAR EL TIPO DE TAMAPOCHO QUE ESTABA COMPRANDO EL ITEM
                { //ESTA CONDICIONAL LO QUE HACE ES QUE EL TAMAPOCHO PASADO POR PARAMETRO SEA UN TAMAPOCHO DECLARADO EN LA CONDICION QUE ES EL TIPO DE TAMAPOCHO QUE ESTAMOS BUSCANDO
                    gym.FuerzaTama += (int)(gym.FuerzaTama * item.ValorEfecto / 100.0);
                    Console.WriteLine($"Tu tamapocho ha obtenido un plus de{item.ValorEfecto}% de Fuerza");
                }
                else Console.WriteLine("Este item es solo para el Gymbro.");
                break;

            case TipoEfecto.SubirNivelHigh:
                if (tama is TamapochoHippie hippie)
                {
                    hippie.NivelHigh += item.ValorEfecto;
                    Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto} de Nivel High");
                }
                else Console.WriteLine("Este item es solo para el Hippie.");
                break;

            case TipoEfecto.SubirCafeina:
                if (tama is TamapochoInformatico infor)
                {
                    infor.NivelCafeina += item.ValorEfecto;
                    Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto} de Cafeína");
                }
                else Console.WriteLine("Este item es solo para el Informático.");
                break;

            case TipoEfecto.SubirSeguidores:
                if (tama is TamapochoTikTok tiktok)
                {
                    tiktok.Seguidores += item.ValorEfecto;
                    Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto} Seguidores");
                }
                else Console.WriteLine("Este item es solo para el TikToker.");
                break;

            case TipoEfecto.SubirNivelChistes:
                if (tama is Tamapochocunyao cunyao)
                {
                    cunyao.NivelChistes += item.ValorEfecto;
                    Console.WriteLine($"Tu tamapocho ha obtenido un plus de {item.ValorEfecto} de Nivel Chistes");
                }
                else Console.WriteLine("Este item es solo para el Cuñao.");
                break;




            case TipoEfecto.DesbloquearEstado:
                //GymBro a chuzao
                if (tama is TamapochoGymBro tamapochoGymBro)
                {
                    tamapochoGymBro.EstadoEnForma = TamapochoGymBro.NivelCulturista.CHUZAO;
                    Console.WriteLine("Tu Gymbro ha tomado el suplemento prohibido... HA DEJADO DE SER NATTY");

                }
                //Hippie a Brote 
                else if (tama is TamapochoHippie tamapochoHippie)
                {
                    tamapochoHippie.EstadoFum = TamapochoHippie.EstadoHigh.Brote;
                    Console.WriteLine("Tu Hippie ha tenido un brote... esto ya si que no tiene vuelta atrás");

                }
                //Informatico a Sennior 
                else if (tama is TamapochoInformatico tamapochoInformatico)
                {
                    tamapochoInformatico.estadoEnergetico = TamapochoInformatico.EstadoEnergetico.SENIOR;
                    Console.WriteLine("Tu Informático ya es un Sennior de manual. ¿Premio o Castigo?");


                }
                //Cunyao a INSUFRIBLE
                else if (tama is Tamapochocunyao tamapochocunyao)
                {
                    tamapochocunyao.RangoCunyao = Tamapochocunyao.EstadodeCunyao.INSUFRIBLE;
                    Console.WriteLine("Tu Cuñao se ha bebido los dos packs de una sentada, ahora es completamente insufrible y puede que alcoholico.");


                }
                break;
        }
    }

}