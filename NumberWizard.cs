using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Player");
        Debug.Log("We will play a game, you will think of a number, and I have to guess it.");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Is your number higher or lower than " + guess + " ?");
        Debug.Log("Arrow Up = Higher - Arrow Down = Lower - Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess + " ? ");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess + " ? ");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed the number.");
        }
    }
}
