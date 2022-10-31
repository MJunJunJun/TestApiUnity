using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public int numberOfLive = 9;
    public override void MakeSound()
    {
        Debug.Log(Name+" Miawww have live "+numberOfLive);
    }
    public void ClimbTree()
    {

    }

}
