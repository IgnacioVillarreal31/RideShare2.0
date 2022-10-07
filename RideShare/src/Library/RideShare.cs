using System;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;

namespace Ridesharing;

public class Rideshare 
{
    public List<Users> Users = new List<Users>();

    public void Add(Users user,string foto)
    {
        Users.Add(user);
        RegistroTwitter.Registro(user,foto);
        
    }   
}