using System;
using System.Collections.Generic;
namespace Ridesharing;

public class ConductorComun : Conductor
{
    public int CantidadPasajeros = 1;
    public string Type = "Comun";
    public ConductorComun(string vehicle, string bio, string name, string surname, int id) : base (vehicle, bio, name, surname, id) 
    {

    }
    public override string Info ()
    {
        return $"{Name} {Surname}.\nConductor de tipo {Type}.\nBio : {Bio}.";
    } 
}