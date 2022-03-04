using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    
    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
        Debug.Log("Ya tu sabe como va");
        Debug.Log("Think of a number... (" + min + " min and " + max + " max)");
        Debug.Log("Enter the highest possible number:");
        Debug.Log("Enter the lowest possible number:");
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Instructions: Push Up = Higher, Push Down = Lower, Press Enter = Correct");
        max++;
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
            Debug.Log("I am a genius");
            StartGame();
        }
    }
    
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("What about: " + guess + "?");
    }
}
