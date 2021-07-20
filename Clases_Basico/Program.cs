using System;

namespace Clases_Basico
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //crea un objeto desde mi clase
            //una instancia desde la clase Humano    
            Humano Marco = new Humano("Marco","Huerta", "cafes", 27);
            Humano Antonio = new Humano("Antonio","Huerta", "azules", 1);

            //Acceder desde una variable pública
           /* Marco.primerNombre = "Marco";
            Antonio.primerNombre = "Antonio";

            Marco.apellido = "Huerta";
            Antonio.apellido = "Sánchez";*/


            
            //llama un método desde una clase
            Marco.presentarme();
            Antonio.presentarme();

            Console.Read();
        }

        
    }
}
