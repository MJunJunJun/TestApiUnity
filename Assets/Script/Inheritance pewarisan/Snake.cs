using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{
    public Color color;
    public override void MakeSound()
    {
        Debug.Log(Name+" SSSSStttt Snake have color "+color);
    }
    public void SheedSkin()
    {

    }
 
}
