
//el namespace el cual contiene toda mi app
namespace pitMain
{
    //esta es la clase la cual da acceso a las funciones de la aplicacion
    public class program()
    {
        //agreggo un objeto de tipo AppWeb, con el cual voy a instanciar o llamar al otro metodo constructor        AppWeb appWeb = new AppWeb();

        static void Main()
        {
            Helper H = new Helper();
            H.Menu();
        }

    }

    //puedo crear otro archivo en el cual puedo poner otra clase con sus atributos y metodos, tiene que estar dentro del mismo namespace para poder usarse sin problemas y ambas tienen que ser publicas
}