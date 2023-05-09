using System;
using DCInternet.Zoo;


namespace DCInternet.Zoo
{
    class Pato:Oviparo, Animal
    {
        
        public Pato(string Nombre)
        {
            Console.WriteLine("nombre del pato: {0}", Nombre);
            this.Nombre = Nombre;
        }
        public override int PonerHuevos()
        {
            Random random = new Random();
            var numeroDeHuevos = random.Next(8);
            Oviparo.HuevosTotales += numeroDeHuevos;
            return numeroDeHuevos;
        }

        public void Comer()
        {
            Console.WriteLine("{0} esta comiendo apio",Nombre);
        }

        public void Nacer()
        {

        }
    }
}
