using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberLock : MonoBehaviour
{
    public Text Number;
    public Text correctNumber;
    public bool numberCorrect;

    // Start is called before the first frame update
    void Start()
    {
        Number.text = "0";
        correctNumber.text = "7";
    }


    public void ButtonToggle() 
    
    {
      if (Number.text == "0") 
       {
            Number.text = "1";
        }
      else if (Number.text == "1")
        {
            Number.text = "2";
        }

      else if (Number.text == "2")
        {
            Number.text = "3";
        }
        else if (Number.text == "3")
        {
            Number.text = "4";
        }
        else if (Number.text == "4")
        {
            Number.text = "5";
        }
        else if (Number.text == "5")
        {
            Number.text = "6";
        }
        else if (Number.text == "6")
        {
            Number.text = "7";
        }
        else if (Number.text == "7")
        {
            Number.text = "8";
        }
        else if (Number.text == "8")
        {
            Number.text = "9";
        }
        else if (Number.text == "9")
        {
            Number.text = "0";
        }

        if (Number.text == correctNumber.text) 
        {
            Debug.Log("correct");
        
        }
    }
}
