using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("You're a Number Wizard, Harry !");
        Debug.Log("For my next trick, I'm going to guess a number you chose in your head.");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Is your number higher or lower than my wizard guess of " + guess + " ?");
        Debug.Log("If it is higher, press the Up Arrow, if it is lower press the Down Arrow, if it is correct indeed, press Enter.");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("A wizard is never late, nor is he early, he guesses numbers in your head precisely when he means to.");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("I see ! Now, is it higher or lower than " + guess + " my lad ? ");
    }
}
