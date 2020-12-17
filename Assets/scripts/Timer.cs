using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 180;
    public bool timerIsRunning = true;
    public Text timeText;
    public AudioSource watchBeep;
    public bool watchBeeping;
    public bool twoMinutes = false;
    public bool twoMinutesStop = false;
    public bool oneMinute = false;
    public GameObject endMenu2;
    public GameObject phone;

   

    void Update()
    {
        

        // this part runs the actual timer
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                // makes watch beep at 2 minutes
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
                // makes watch beep at one minute
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
            //stops timer and beeps when time run out
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
                watchBeep.Stop();
                phone.SetActive(false);
                endMenu2.SetActive(true);

            }
        }

        
    }
    //this bit makes it displayable as a text element
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
