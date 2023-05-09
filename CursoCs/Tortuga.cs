using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCInternet.Zoo
{
    class Tortuga : Oviparo, Animal
    {
        public Tortuga()
        {

        }
        
        public Tortuga(string Nombre) {
            this.Nombre = Nombre;
        }

        public override int PonerHuevos()
        {
            Random random = new Random();
            int numeroDeHuevos = random.Next(8);
            HuevosTotales += numeroDeHuevos;
            return numeroDeHuevos;
        }

        public void Comer()
        {
            Console.WriteLine("{0} esta comiendo lechuga", Nombre);
        }

        public void Nacer()
        {
            Console.WriteLine("El animal nacio: ",DateTime.Now);
        }




    }
}
