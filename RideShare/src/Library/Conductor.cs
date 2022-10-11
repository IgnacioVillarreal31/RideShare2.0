using System;
using System.Collections.Generic;
namespace Ridesharing;
using TwitterUCU;
using CognitiveCoreUCU;

public class Conductor : Users
{
    public string Vehicle {get; set;}
    public string Bio {get; set;}
    public Conductor(string vehicle, string bio, string name, string surname, int id) : base (name, surname, id) 
    {
        this.Vehicle = vehicle;
        this.Bio = bio;
    }
    public override string Info ()
    {
        return $"{Name}. Bio : {Bio}";
    }
    public override void FoundFace(CognitiveFace cog)
    {
        if (cog.FaceFound)
        {
            if (cog.SmileFound)
            {
                this.foundFace = true;
            }
        }
        else
        {
            this.foundFace = false;
        }
    }            
}