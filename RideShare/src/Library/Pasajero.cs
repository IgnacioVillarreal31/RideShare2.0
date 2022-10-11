using System;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;
namespace Ridesharing;

public class Passenger : Users
{
    public Passenger(string name, string surname, int id) : base (name, surname, id)
    {

    }
    public override string Info ()
    {
        return $"{Name} {Surname}.\nPasajero.";
    } 

    public override void FoundFace(CognitiveFace cog)
    {
        if (cog.FaceFound)
        {
            this.foundFace = true;
        }
        else
        {
            this.foundFace = false;
        }
    } 
}