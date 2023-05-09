using System;

namespace DCInternet.Zoo
{
    class Aguila:Oviparo, Animal
    {
        static private int HuevosTotales = 0;
        public override int PonerHuevos()
        {
            Random random = new Random();
            var numeroDeHuevos = random.Next(8);
            Oviparo.HuevosTotales += numeroDeHuevos;
            HuevosTotales += numeroDeHuevos;
            return numeroDeHuevos;
        }

        static public int getHuevosTotales()
        {
            return HuevosTotales;
        }

        public void Comer()
        {
            Console.WriteLine("{0} esta comiendo ratones",Nombre);
        }

        public void Nacer()
        {

        }


    }
}
