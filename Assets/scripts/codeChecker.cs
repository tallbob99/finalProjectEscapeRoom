using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeChecker : MonoBehaviour
{
    public Text Number1;
    public Text Number2;
    public Text Number3;
    public Text Number4;
    public Text correctNumber1;
    public Text correctNumber2;
    public Text correctNumber3;
    public Text correctNumber4;
    public MeshCollider interactableCollider;
    public MeshCollider staticCollider;
    public GameObject Lock;
    public bool codeSolved = false;
    // Update is called once per frame
    void Update()
    {
        //compares entered code to correct code
        if (codeSolved == false)
        {
            if (Number1.text == correctNumber1.text && Number2.text == correctNumber2.text && Number3.text == correctNumber3.text && Number4.text == correctNumber4.text)
            {

               
                Debug.Log("code correct");
                
                //allows interaction with locker door
                interactableCollider.enabled = true;
                staticCollider.enabled = false;
                //disables lock
                Lock.SetActive(false);



            }
        }
    }
}
