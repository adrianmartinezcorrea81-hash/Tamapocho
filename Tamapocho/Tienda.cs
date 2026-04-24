public class Tienda
{
    private List<Item> items;
    

    public Tienda()
    {
        items = new List<Item>();
        //Voy a organizar los items por tipso de tamapocho al crearlos, pero que podran comprarlo sin importar el tamampocho que estes jugando,
        //Lo hago asi para aclararme yo, sin mas

        //Tamapochos en general

        Item bocataNocilla= new Item("Bocata de Nocilla", "Bocata de Nocilla el cual la Nocilla desborda hasta del bocadillo...",5,"Aumentará XP para subir de nivel\nTen en cuenta que lleva mucho Azucar...");//Al indicar que lleva mucho Azucar planeo que la felicidad aumente pq lleva mucho azucar y la energia tambien pero posiblemente la vida baje debido a que el azucar es malo para la salud
        Item Botiquin= new Item("Botiquin", "En ocasiones es necesario invertir en salud para seguir viviendo...",20,"La vida aumentará hasta estar completa");
        Item Almohada= new Item("Almohada", "Dormir es necesario para una persona, para tu tamapocho no es distinto...",15,"Aumentará en un 20% la Energia de tu tamapocho");
        Item Pildorafelicidad= new Item("Píldora de la felicidad", "Cuando ni tu compañia anima a tu tamapocho es necesario darle un empujon.",15,"Aumentará en un 25% la Felicidad de tu tamapocho");
        Item Chuchería = new Item("Chuchería ", "Un pequeño capricho para tu tamapocho nunca viene mal",2,"Aumentará un 3% la Felicidad de tu tamapocho pero piensa que llevan mucho azucar...");//Bajará un 1.5% la Vida de tu tama muy poco saludable
        Item Vendas = new Item("Vendas ", "Pequeña inversion en la salud de tu tamapocho para que pueda recuperarse",10,"+25% a la estadistica de Vida de tu tamapocho");
        Item Cafe = new Item("Cafe", "Pequeña taza de café para dar ese impulso que a veces es necesario",3,"+25% a la estadistica de Energia de tu tamapocho, muy bien al principio pero luego habrá bajon...");//Puede que le baje un poco la felicidad por el bajon
        AgregarItem(bocataNocilla);
        AgregarItem(Botiquin);
        AgregarItem(Almohada);
        AgregarItem(Pildorafelicidad);
        AgregarItem(Chuchería);
        AgregarItem(Vendas);
        AgregarItem(Cafe);
        //TamaGymbro
        Item ProteinaEnPolvo = new Item("1KG de Proteína en polvo", "Para llegar al otro nivel la comida no es suficiente ayuda a tu tamapocho a ser ese culturista que quiere ser.",500,"+25% a la estadistica de Fuerza de tu tamapocho, muy bien al principio pero luego habrá bajon...");
        Item Mancuernas = new Item("Mancuernas de titanio", "Tu tamapocho está deseando buen material para entrenar y estas mancuernas es lo que realmente necesita para llegar a otro nivel.",1000,"Aumentara la fuerza segun vayas entrenando con este material(Cantidad de usos=200 entrenamientos)");
        Item Supprohibido = new Item("Suplemento prohibido", "Ya somos conscientes que si de verdad tu tamapocho y tu deseais llegar a la tarima hay que hacer trampas, PIENSALO BIEN.",6767,"Efectos desconocidos"); //Dejara de ser natural y asi es como se desbloquea el nivel de chuzao
        AgregarItem(ProteinaEnPolvo);
        AgregarItem(Mancuernas);
        AgregarItem(Supprohibido);
        //TamaHippie
        Item Porro = new Item("Porro artesanal(5 g) ", "Nunca es demasiado grande para el tamapocho hippie pero dale unas caladas y verás como actua...",500,"Aumentara el Nivel de High de tu tamapocho Hippie");
        Item Grimorio = new Item("Grimorio de Chakras", "Ayuda a que tu tamapocho Hippie conecte consigo mismo y asi pueda ayudar al resto a que se encuentren.",1200,"Aumentara el Nivel de High de tu tamapocho Hippie poco");//Pese a aumentar poco el NivelDeHigh el tamapocho llegara a un EstadoDeHigh completamente exclusivo que es el ModoZen
        Item PorroSupremo = new Item("PorroSupremo(Sorpresa g)", "Nunca es demasiado grande para el tamapocho hippie pero este artilugio puede que si, asi que controla la dosis...",6767,"Aumentara el Nivel de High de tu tamapocho Hippie");//Es mucho mas facil llegar al EstadoDeHigh Brote, todavia no tengo pensado cuanto de facil 
        AgregarItem(Porro);
        AgregarItem(Grimorio);
        AgregarItem(PorroSupremo);
        //TamaTiktoker

        Item AroDeLuz = new Item("Aro de Luz", "Nunca es suficiente luz a la hora de grabar un video.",500,"Aumentara la cantidad de seguidores que recibas por video.");
        Item FiltroEx = new Item("Filtro Exclusivo de Videos", "Llega el punto donde a tu tamapocho no le sirve unicamente tener buena iluminacion y quiere ir a mas.",1150,"Aumentara la cantidad de seguidores que recibas por video, con mas impacto que el Aro de Luz");
        Item NuevoMovil = new Item("Nuevo Movil De Ultima Generacion", "Este articulo es sin duda el salto de calidad que estan pidiendo tus videos para llegar a la cima",6767,"Aumentara la cantidad de seguidores de forma exponente,casi de forma ilógica");

        //TamapochoInformatico
        Item Aricularescab = new Item("Auriculares con cable", "Un verdadero informatico detesta unos auriculares inhalambrico,\"Ese tipo de auriculares para los normies que quieren tener peor calidad de audio...\"",500,"Aumentara el estado de energia de tu Tamapocho Informatico muy poco."); 
        Item MonsterNormal = new Item("Monster Verde(normal)", "Un verdadero informatico podria estar todo el dia bebiendo monsters",500,"Aumentara el estado de energia de tu Tamapocho Informatico pero cuidado con el azucar");//Bajara vida por azucar
        Item MonsterBlanco = new Item("Monster Verde(normal)", "Un verdadero informatico podria estar todo el dia bebiendo monsters, pero bueno si tu Tamapocho Informatico le importa el azucar esta es tu opcion",500,"Aumentara el estado de energia de tu Tamapocho Informatico pero cuidado con el azucar");//Bajara muy poco la felicidad por no tener azucar
        Item SetUp = new Item("SetUp con RGB ", "Un verdadero informatico necesita su SetUp hasta arriba de RGB y esta es la mejor opcion sin duda en cuanto a perifericos y RGB...",1150,"Incrementará la energia de tu Tamapocho hasta el fin del juego a la hora de beber monsters");//Pequeña Incrementacion cuando beba monster
        Item SudaderaDeLinux = new Item("Sudadera De Linux", "Con este articulo tu tamapocho ya ha alcanzado el nivel mas alto de un informatico, ya puedes darlo por perdido.... ",6767,"Si decidiste comprar este articulo no sabrás el efecto hasta que lo veas con tus propios ojos...");//Llega al rango maximo que es Senior
        AgregarItem(Aricularescab);
        AgregarItem(MonsterNormal);
        AgregarItem(MonsterBlanco);
        AgregarItem(SetUp);
        AgregarItem(SudaderaDeLinux);
        //TamapochoCunyao

        Item PalilloMad = new Item("Palillo de Madera", "Un cuñao de verdad siempre lleva su palillo en la boca durante los 365 dias del año(es el mismo siempre)",500,"Aumentara el estado de cuñao de tu Tamapocho Cuñao muy poco y al contar chistes darás mas gracia (Duracion= 100Chistes.)"); //Dara mas valor la funcion de ContarChistes
        Item CamiAtl = new Item("Camiseta del Atleti", "La camiseta por excelencia de los cuñaos, regalasela a tu Tamapocho sin pensarlo, le encantará sin duda.(NO ORIGINAL)",1200,"Aumentara el estado de cuñao de tu Tamapocho Cuñao muy poco y al contar chistes darás mas gracia (Duracion= 200Chistes."); //Dara mas valor la funcion de ContarChistes si tiene palillo tambien se sumara con el valor que se aumente a contarchistes
        Item Riñonera = new Item("Riñonera", "Accesorio que no le debe faltar a tu Tamapocho Cuñao si de verdad quieres que la gente se ria con sus chistes, o de el.",1800,"Aumentara el estado de cuñao de tu Tamapocho Cuñao muy poco y al contar chistes darás mas gracia (Duracion= 220Chistes.)"); //Practicamente igual que el resto de objetos de este tama pero este sumara un pco mas que la cami del atleti
        Item PacksCerves = new Item("PackCerves", "Con la excusa de \"Estos dos Pack de Cervezas me duran todo el puente tu tamapocho\" se beberá estas dos cervezas como dice el de \"una sentada\"",1800,"Ir tan borracho para este de Tamapocho es INSUFRIBLE descubre tu mismo los efectos"); //Desbloquea Estado Exclusivo(por pensar que hara)
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

    
}