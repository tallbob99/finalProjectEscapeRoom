﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 180;
    public bool timerIsRunning = false;
    public Text timeText;
    public AudioSource watchBeep;
    public bool watchBeeping;
    public bool twoMinutes = false;
    public bool twoMinutesStop = false;
    public bool oneMinute = false;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        


        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                if (twoMinutes == false)
                {
                    if (watchBeeping == false)
                    {
                        if (timeRemaining < 120)
                        {
                            watchBeep.Play();
                            watchBeeping = true;
                            twoMinutes = true;
                        }
                    }
                }
                else
                {
                    if (twoMinutesStop == false)
                    {
                        if (timeRemaining < 115)
                        {
                            watchBeep.Stop();
                            watchBeeping = false;
                            twoMinutesStop = true;
                        }
                    }
                }

                if (oneMinute == false)
                {
                    if (watchBeeping == false)
                    {
                        if (timeRemaining < 60)
                        {
                            watchBeep.Play();
                            watchBeeping = true;
                            oneMinute = true;
                        }
                    }
                }

            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                watchBeep.Stop();
            }
        }

        
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
