using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Name;

    public virtual void MakeSound()
    {
        Debug.Log("No SOund"); 
    }

    // Start is called before the first frame update
    void Start()
    {
        MakeSound();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
