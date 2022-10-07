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
            Users conductor1 = new Conductor("Ford", "hola", "Augusto", "Sbarbaro", 11122233, 1);
            Users conductor2 = new Conductor("McQueen", "adios", "Coscu", "Pelado", 22233344, 3);
            Rideshare viaje = new Rideshare();
            
            viaje.Add(conductor1, "New Employee 1! ",@"bill2.jpg");
            viaje.Add(conductor2, "New Employee 2! ",@"prueba1.jpg");
            viaje.Add(pasajero1, "New Employee 3! ",@"bill2.jpg");
            viaje.Add(pasajero2, "New Employee 4! ",@"prueba1.jpg");
            viaje.Add(pasajero3, "New Employee 5! ",@"prueba1.jpg");

            pasajero1.Qualify(1,"Se");
            pasajero1.Qualify(5,"Se2");
            var cali = pasajero1.CalculoCalificacion();
            Console.WriteLine(cali);
        }
    }
}