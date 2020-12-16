using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phoneCode : MonoBehaviour
{
    public Text Number1;
    public Text Number2;
    public Text Number3;
    public Text Number4;
    public Text correctNumber1;
    public Text correctNumber2;
    public Text correctNumber3;
    public Text correctNumber4;
    public GameObject endMenu1;
    public GameObject timer;
    public bool codeSolved = false;
    // Update is called once per frame
    void Update()
    {
        if (codeSolved == false)
        {
            if (Number1.text == correctNumber1.text && Number2.text == correctNumber2.text && Number3.text == correctNumber3.text && Number4.text == correctNumber4.text)
            {


                Debug.Log("code correct");
                endMenu1.SetActive(true);
                timer.SetActive(false);
                codeSolved = true;



            }
        }
    }
}
