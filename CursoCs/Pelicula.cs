using System;

namespace DCInternet.Cine
{
    class Pelicula
    {
        public int Id;
        private string Nombre;
        public DateTime Fecha;
        private DateTime fechaRegistro;
        public string Genero { get; set; }
        private static int contador = 0;
        public Pelicula()
        {
            contador++;
            Console.WriteLine("Contador es: {0}", contador);
            fechaRegistro = DateTime.Now;
        }

        public Pelicula(int Id, string Nombre, DateTime Fecha) : this()
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Fecha = Fecha;
            Console.WriteLine("Id {0}, Pelicula {1}, Fecha {2}", Id, Nombre,Fecha);
            //contador++;
        }

        public static int getContador()
        {
            return contador;
        }

        public void Play()
        {
            Console.WriteLine("Su pelicula: {0} , se estreno el:{1}", Nombre, Fecha);
            Console.WriteLine("Disfruta la pelicula");
        }

        public void setNombre(string value)
        {
            Nombre = value.ToUpper();
        }

        public string getNombre()
        {
            return Nombre;
        }

        public DateTime getFechaRegistro()
        {
            return fechaRegistro;
        }




        //public string Genero
        //{
        //    get { return _genero; }
        //    set { _genero = value; }
        //}

        //public void setGenero(string value)
        //{
        //    Genero = value;
        //}

        //public string getGenero()
        //{
        //    return Genero;
        //}




    }
}
