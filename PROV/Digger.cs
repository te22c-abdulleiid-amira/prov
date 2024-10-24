using System;

namespace PROV;

public class Digger : Lemming
{
    public bool IsDigging;
    public void StartDigging()
    {
        IsDigging = true;
    }
    public void Update()
    {
        if (IsDigging  = true)
        {
            Y -= 1;
        }
    }
}
