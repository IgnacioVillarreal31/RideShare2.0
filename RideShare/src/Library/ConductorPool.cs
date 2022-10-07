using System;
using System.Collections.Generic;
namespace Ridesharing;

public class ConductorPool : Conductor
{
    public int CantidadPasajeros {get;set;}
    public string Type = "Pool";
    public ConductorPool(string vehicle, string bio, string name, string surname, int id, int cantidad) : base (vehicle, bio, name, surname, id) 
    {
        this.CantidadPasajeros = cantidad;
    }
}