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
        if (FoundFace(cog))
        {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter(text,foto));
        }
    }   
        static bool FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                    return true;
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
            {
                Console.WriteLine("No Face Found");
            }
            return false;
        }                
}