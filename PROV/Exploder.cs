using System;

namespace PROV;

public class Exploder : Lemming
{
    public int Timer;
    public bool IsActivated;
    public void Activate()
    {

    }
    public void Update()
    {
        
        if (Timer < 0)
        {
            Console.WriteLine("Kaboom!");
        }
        else 
        {

        }
    }
}
