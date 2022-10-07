using System;
using System.Collections.Generic;
namespace Ridesharing;

public class Conductor : Users
{
    public string Vehicle {get; set;}
    public string Bio {get; set;}
    public int CantidadPasajeros {get; set;}
    public string Type {get; set;}
    public Conductor(string vehicle, string bio, string name, string surname, int id, int cantidad) : base (name, surname, id) 
    {
        this.Vehicle = vehicle;
        this.Bio = bio;
        this.CantidadPasajeros = cantidad;
        if (CantidadPasajeros == 1)
        {
            this.Type = "Común";
        }
        else if (CantidadPasajeros > 1)
        {
            this.Type = "Pool";
        }
    }
}