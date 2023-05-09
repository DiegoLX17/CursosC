using System;
using DCInternet.Zoo;


namespace DCInternet.Herramientas
{
    class Utileria
    {   
        public static void Separador()
        {
            Console.Write("********************");
            Console.WriteLine("");
        }

        public static void Separador(char caracter, int longitud)
        {
            for (int i = 0; i < longitud; i++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine("");
        }

        //Sobrecarga de metodos, se pueden llamar igual los metodos, siempre y cuando los parametros sean distintos.
        //public static void Alimentar(Aguila aguila)
        //{
        //    aguila.Comer();
        //}
        //public static void Alimentar(Tortuga tortuga)
        //{
        //    tortuga.Comer();
        //}

        public static void Alimentar(Animal animales)
        {
            animales.Comer();
        }

        public static void Alimetar(Pato[] patos)
        {
            for (int i = 0; i < patos.Length; i++)
            {
                patos[i].Comer();
            }
        }

        public static void Alimentar(Animal[] animales)
        {
            for (int i = 0; i < animales.Length; i++)
            {
                animales[i].Comer();
            }
        }




    }
}
