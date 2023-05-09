using System;
using DCInternet.Herramientas;
using DCInternet.Cine;
using DCInternet.Zoo;

namespace DCInternet.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utileria.Separador();
            //Console.WriteLine("Hola Mundo");
            //Console.WriteLine("Hay {0} peliculas", Pelicula.getContador());
            //Pelicula pelicula = new Pelicula();
            //Pelicula pelicula2 = new Pelicula();
            //Pelicula pelicula3;
            //pelicula.Id = 1;
            //pelicula.setNombre("Interestelar");
            //pelicula.Fecha = new DateTime(2015, 02, 23);
            //pelicula.Genero = "Ciencia Ficcion";
            //pelicula.Play();
            //pelicula2.setNombre("Batman");
            //pelicula2.Id = 3;
            //pelicula2.Fecha = new DateTime(2017, 03, 21);
            //pelicula2.Play();
            //pelicula3 = pelicula2;
            //pelicula3.setNombre("Batman y Robin");
            //Console.WriteLine("La pelicula {0}, Se registro el {1}",pelicula3.getNombre(), pelicula3.getFechaRegistro());
            //pelicula3.Play();
            //Pelicula pelicula4 = new Pelicula(4,"Titanic",new DateTime(2002,01,10));
            //Console.WriteLine("Pelicula 4 es: {0}", pelicula4.getNombre());
            //Console.WriteLine("Hay {0} peliculas", Pelicula.getContador());
            //Utileria.Separador('-',30);
            //Pelicula pelicula5 = new Pelicula();
            //pelicula5.setNombre("Pelicula 5");
            //Console.WriteLine("La pelicula {0}, Se registro el {1}", pelicula5.getNombre(), pelicula5.getFechaRegistro());
            //Console.ReadLine();
            //



            Console.WriteLine("Bienvenidos al Zoologico");
            Utileria.Separador();
            Console.WriteLine("Seccion de Oviparos");
            Utileria.Separador('/', 10);
            Console.WriteLine(Oviparo.Descripcion);
            Utileria.Separador('/', 10);
            //Oviparo oviparo = new Oviparo();
            Tortuga tortuga1 = new Tortuga();
            tortuga1.Nombre = "Juana";
            int huevosPuestoTortuga = tortuga1.PonerHuevos();
            Console.WriteLine("{0} ha puesto {1} huevos", tortuga1.Nombre, huevosPuestoTortuga);
            //tortuga1.Comer();
            Utileria.Separador();
            Aguila aguila1 = new Aguila();
            aguila1.Nombre = "Icaro";
            Console.WriteLine("{0} ha puesto {1} huevos", aguila1.Nombre, aguila1.PonerHuevos());
            //aguila1.Comer();
            Utileria.Separador();
            Aguila aguila2 = new Aguila();
            aguila2.Nombre = "Alex";
            Console.WriteLine("{0} ha puesto {1} huevos", aguila2.Nombre, aguila2.PonerHuevos());
            aguila2.Comer();
            Pato pato = new Pato("Paco");
            Pato pato1 = new Pato("Pepe");
            //Oviparo.HuevosTotales--;
            Console.WriteLine("Se recogieron un total de {0} huevos", Oviparo.getHuevosTotales());
            Console.WriteLine($"Visitaste un total de {Oviparo.getAnimalesTotales()} oviparos");
            Console.WriteLine($"Las aguilas pusieron un total de {Aguila.getHuevosTotales()} huevos");
            Utileria.Alimentar(aguila1);
            Utileria.Alimentar(tortuga1);
            Utileria.Alimentar(pato);
            Utileria.Alimentar(new Pato("Pepe"));
            Utileria.Alimentar(pato);
            Console.WriteLine(pato);


            Pato[] patos = { pato, pato1, new Pato("Juan"), new Pato("Boing") };
            Utileria.Alimetar(patos);



            Utileria.Separador();
            Console.WriteLine("Seccion de Felinos");
            Utileria.Separador('/', 10);
            Console.WriteLine(Felino.Descripcion);
            Utileria.Separador('/', 10);
            Ocelote ocelote1 = new Ocelote("Felix",new DateTime(2023,10,12));

            Animal[] animales = { tortuga1, aguila1, aguila2, new Tortuga("Javi"), ocelote1 };
            Utileria.Alimentar(animales);


            Console.ReadLine();
            //contar el numero de oviparo

            //Metodo para dar de comer a los oviparos




            //string nombre = "pato";
            //string result = "";

            //for (int i = nombre.Length-1; i >=0; i--)
            //{
            //    result += nombre[i];
            //}
            //Console.WriteLine(result);


            Console.ReadLine();



        }
    }
}
