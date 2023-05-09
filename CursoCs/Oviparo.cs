using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCInternet.Zoo
{
    abstract public class Oviparo
    {
        private static int contador = 0; 
        public static string Descripcion = "Dicho de un animal: Que pone huevos en los que se desarrollan los embriones; p. ej., las aves, los moluscos, los insectos";
        public string Nombre;
        protected static int HuevosTotales = 0;
        protected static int AnimalesTotales = 0;
        public Oviparo()
        {
            contador++;
            //Console.WriteLine("Haz creado {0} animal(es) oviparos",contador);
        }
        public abstract int PonerHuevos();        

        //public abstract void Comer();
        public static int getHuevosTotales()
        {
            return HuevosTotales;
        }

        public static int getAnimalesTotales()
        {
            return contador;
        }
        


    }

}
