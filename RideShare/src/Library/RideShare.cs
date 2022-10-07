using System;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;

namespace Ridesharing;

public class Rideshare 
{
    public List<Users> Users = new List<Users>();

    public void Add(Users user, string text, string photo)
    {
        Users.Add(user);
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter(text,photo));
    }   
}