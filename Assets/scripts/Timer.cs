using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool timerRunning = false;
    public float timeRemaining = 10;


    void Start()
    {
        
        timerRunning = true;
    }

    public void Update()
    {
        timer();
    }
    public void timer()
    {
        if (timerRunning == true)
        {
            Debug.Log("you have " + timeRemaining + " seconds left");

            if (timeRemaining > 0)
            { timeRemaining -= Time.deltaTime; }
            //tells timer to output message when time up

            else
            {
                Debug.Log("out of time");
                timeRemaining = 0;
                timerRunning = false;
            }
        }
    }
}
