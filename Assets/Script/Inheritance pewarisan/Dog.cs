using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public bool isGoodBoy = true;
    public override void MakeSound()
    {
        Debug.Log(Name+" make a sound GUKGUK");
    }

    public void MakeHole()
    {

    }


}
