using System;

namespace PROV;

public class Jumper : Lemming
{
    public int JumpForce;
    public void Jump()
    {
        JumpForce = 20;
    }
    public void Update()
    {
        if (JumpForce > 0)
        {
            Y++;
            JumpForce--;
        }
        else if (JumpForce < 0 || JumpForce == 0)
        {
            
        }
        
    }
}
