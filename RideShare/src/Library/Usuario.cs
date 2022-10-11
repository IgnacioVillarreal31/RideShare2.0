using System;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;

namespace Ridesharing;

public abstract class Users
{
    public Dictionary<int, string> Calificaciones = new Dictionary<int, string>();
    public Users(string name, string surname, int id)   
    {
        this.Name = name;
        this.Surname = surname;
        this.ID = id;
    }
    public string Name {get; set;}
    public string Surname {get; set;}
    public int ID {get; set;}
    public Boolean foundFace {get; set;}
    
    public void Calificar(int value, string comments)
    {
        Calificaciones[value] = comments;
    }
    public double CalculoCalificacion()
    {
        double Suma = 0;
        double Total = 0;
        foreach(var Key in Calificaciones)
        {
            Suma += Key.Key;
        }
        Total = Suma/Calificaciones.Count;
        return Total;
    }  
    public virtual string Info ()
    {
        return Name;
    }

    public virtual void FoundFace(CognitiveFace cog)
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