using System;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;

namespace Ridesharing;

public class RegistroTwitter 
{
    public static void Registro(Users user, string foto)
    {   
        String text = user.Info();
        CognitiveFace cog = new CognitiveFace(false);
        cog.Recognize(foto);
        user.FoundFace(cog);
        Boolean calidad = user.foundFace;

        if (calidad)
        {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter(text,foto));
        }
    }     
}