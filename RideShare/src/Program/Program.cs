using System;
using System.Collections;
using Ridesharing;
using CognitiveCoreUCU;
using TwitterUCU;
namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!*/

            Users pasajero1 = new Passenger("Jorge", "Iglesias", 54246664);
            Users pasajero2 = new Passenger("Ignacio", "Comunista", 78965433);
            Users pasajero3 = new Passenger("ElEmi","Veganosqui", 00000002);
            Users conductor1 = new ConductorComun("Ford", "hola", "Augusto", "Sbarbaro", 11122233);
            Users conductor2 = new ConductorPool("Lambo", "Solo efectivo", "LaRoca", "Jones", 22233344, 20);
            Users conductor3 = new ConductorComun("Ferrari", "No me gusta Toyota", "Lionel", "Messi", 43227653);
            Rideshare viaje = new Rideshare();
            
            viaje.Add(conductor1,@"bill2.jpg");
            viaje.Add(conductor2,@"BRIAN.jpg");
            viaje.Add(conductor3,@"messi.jpg");
            viaje.Add(pasajero1,@"foto.jpg");
            viaje.Add(pasajero2,@"prueba1.jpg");
            viaje.Add(pasajero3,@"prueba1.jpg");

            pasajero1.Qualify(1,"calificacion 1");
            pasajero1.Qualify(5,"calificacion 2");
            var cali = pasajero1.CalculoCalificacion();
            Console.WriteLine(cali);
        }
    }
}