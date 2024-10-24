using System;

namespace PROV;

public class Lemming
{
    public int X;
    public int Y;
    public int Direction = 1;
     
    

    
    public void Walk()
    {
        if (X == 20 && Y == -20)
        {
            X--;
            Y++;
        }        
        else if (X > 20 && Y < -20)
        {
            Direction = -1;
        }
        
    }
}
