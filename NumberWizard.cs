using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        int guess = 500;

        Debug.Log("Hello Player");
        Debug.Log("We will play a game, you will think of a number, and I have to guess it.");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Is your number higher or lower than " + guess + " ?");
        Debug.Log("Arrow Up = Higher - Arrow Down = Lower - Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
