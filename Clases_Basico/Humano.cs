using System;
namespace Clases_Basico
{
    public class Humano
    {

            //Miembro variable
         public string primerNombre;
        public string apellido;
        
        //Miembro método
        public void presentarme()
        {
            Console.WriteLine("Hola, soy {0} {1} " , primerNombre, apellido);
        }
    }
}
