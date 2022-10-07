using System;
using System.Collections.Generic;
namespace Ridesharing;

public abstract class Users
{
    public Dictionary<int, string> Qualifications = new Dictionary<int, string>();
    public Users(string name, string surname, int id)   
    {
        this.Name = name;
        this.Surname = surname;
        this.ID = id;
    }
    public string Name {get; set;}
    public string Surname {get; set;}
    public int ID {get; set;}
    
    public void Qualify(int value, string comments)
    {
        Qualifications[value] = comments;
    }
    public int CalculoCalificacion()
    {
        int Suma = 0;
        int Total = 0;
        foreach(var Key in Qualifications)
        {
            Suma += Key.Key;
        }
        Total = Suma/Qualifications.Count;
        return Total;
    }  
    public virtual string Info ()
    {
        return Name;
    }
}