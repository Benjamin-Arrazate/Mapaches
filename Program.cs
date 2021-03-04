using System;

namespace Animals
{
     class Program
    {
        // En POO, las funciones y procedimientos se llaman métodos
        // En todo programa, se debe incluir un punto inicial
        // El nombre estándar para el método que inicia un programa
        // es "main": static void Main
        // 
        // void -> no devuelve ningún valor (es un procedimiento)
        // static -> entorno estático; trabajando a nivel clase en vez de objeto
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DecirHolaMundo();

        
            Mapache mapache1 = new Mapache(false, 40f, 3.5f, "gris", "ALUCARD");

            Mapache mapache2 = new Mapache(false, 45f, 4f, "Cafe", "Carlos");

            Mapache mapache3 = new Mapache(true, 30f, 7f, "Negro", "Joanna");
            {

                mapache3.DitunombreJoanna();
                mapache3.DitucolorJoanna();
                mapache3.ComerJoanna();
                mapache3.HablarJoanna();
                mapache3.MoverseJoanna();
                mapache3.TreparJoanna();
                mapache3.informacionJoanna();


            }

             Mapache Mapache4 = new Mapache(false, 60f, 20f, "Cafe con negro", "Jorge"); 
            {

                Mapache4.DitunombreJorge();
                Mapache4.ditucolorjorge();
                Mapache4.ComerJorge();
                Mapache4.HablarJorge();
                Mapache4.MoverseJorge();
                Mapache4.TreparJorge();
                Mapache4.informacionJorge();


            }


            
            
            
        }

        static string ObtenerTextoAMostrar()
        {
            return "Hello World!";
        }
        
        static void DecirHolaMundo()
        {
            string textoAMostrar = ObtenerTextoAMostrar();
            Console.WriteLine(textoAMostrar);
        }




    }
}