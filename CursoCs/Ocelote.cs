using System;

namespace DCInternet.Zoo
{
    class Ocelote : Felino, Animal
    {
        private DateTime FechaNacimiento;
        public Ocelote(string Nombre,DateTime FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.FechaNacimiento = FechaNacimiento;
        }
        public void Comer()
        {
            Console.WriteLine($"{Nombre} esta comiendo carne");
        }
        public void Nacer()
        {
            Console.WriteLine($"Nacio el: {FechaNacimiento}");
        }
    }
}
