using System;

namespace Animals
{
    public enum TipoNacimiento
    {
        VIVIPARO,

        OVIPARO,
    }
    
    public enum TipoAlimentacion
    {
        CARNIVORO,
        HERBIVORO,
        OMNIVORO
    }

    public class Mapache
    {
        // Qué atributos tiene un mapache?
        // Es macho o hembra?
        // Está vivo?
        // Tamaño
        // Peso
        // Color
        // Es vivíparo u ovíparo?
        // Tipo de alimentación (Carnívoro, Herbívoro, [Omnívoro, Insectívoro])
        public bool hembra;
        
        public string nombre; 
        public bool vivo;
        public float tamanio; //cm
        public float peso; //kg
        public string color;
        // Representa una propiedad de los mapaches en general
        // static => le corresponde a la clase, y no al objeto
        
        
        public bool viviparo = true;

        
        public static TipoAlimentacion tipoAlimentacion = TipoAlimentacion.OMNIVORO;
        public static TipoNacimiento tipoNacimiento = TipoNacimiento.VIVIPARO; 

         public Mapache(bool hembra, float tamanio, float peso, string color, string nombre)
        {
            // Anteponer this. a las variables de los objetos
            // Variables de instancia
            // this -> este objeto (en este caso, el objecto que se está construyendo)
            this.vivo = true;
            this.nombre = nombre;
            // Variables locales
            // bool vivo = false;

            // Variables estáticas
            // Mapache.viviparo = true;

            this.hembra = true;
            
            this.tamanio = tamanio;
            this.peso = peso;
            this.color = color;
        }

        

        // Método constructor
        // Qué hace un mapache?
        // Moverse
        // -- Respirar
        // Comer
        // -- Existir
        // -- Reproducirse
        // Trepar
        // -- Vivir?
        // -- Morir?
        // Comunicarse/Hacer ruidos





         public void DitunombreJoanna()
         {
            Console.WriteLine("*Grrrr mi nombre es " + nombre + " y soy el mapache 3*");
         }
         
         public void MoverseJoanna()
        {
            Console.WriteLine("*Joanna se mueve*");
        }

        public void ComerJoanna()
        {
            Console.WriteLine("*Joanna entra en el bote de basura*");
        }

        public void TreparJoanna()
        {
            Console.WriteLine("*Joanna se sube a un árbol*");
        }

        public void HablarJoanna()
        {
            Console.WriteLine("*Joanna makes mapache noises*");
        }

        public void DitucolorJoanna()
        {
            Console.WriteLine("*Mi color es " + color + "*");
        }

        public void informacionJoanna()
        {
            Console.WriteLine("Yo Joanna soy " + tipoAlimentacion + " y tambien soy " + tipoNacimiento);
        }
        

        public void DitunombreJorge()
         {
            Console.WriteLine("*Grrrr mi nombre es " + nombre + " y soy el mapache 4*");
         }
         
         public void MoverseJorge()
        {
            Console.WriteLine("*Jorge se mueve*");
        }

        public void ComerJorge()
        {
            Console.WriteLine("*Jorge entra en el bote de basura*");
        }

        public void TreparJorge()
        {
            Console.WriteLine("*Jorge se sube a un árbol*");
        }

        public void HablarJorge()
        {
            Console.WriteLine("*Jorge makes mapache noises*");
        }

        public void ditucolorjorge()
        {
            Console.WriteLine("*Mi color es " + color + "*");
        }

        public void informacionJorge()
        {
            Console.WriteLine("Yo Jorge soy " + tipoAlimentacion + " y tambien soy " + tipoNacimiento);
        }
        
    }
}



