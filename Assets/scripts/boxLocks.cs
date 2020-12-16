using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxLocks : MonoBehaviour
{
    public Text Number1;
    public Text Number2;
    public Text Number3;
    public Text Number4;
    public Text correctNumber1;
    public Text correctNumber2;
    public Text correctNumber3;
    public Text correctNumber4;
    public GameObject codeLock;
    public bool codesolved;
    public GameObject keyLock;
    public bool keySolved;
    
    // Update is called once per frame
    void Update()
    {
        if (Number1.text == correctNumber1.text && Number2.text == correctNumber2.text && Number3.text == correctNumber3.text && Number4.text == correctNumber4.text)
        {
            codeLock.SetActive(false);
            codesolved = true;
        }

        
   

}

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Key")
        {
            keyLock.SetActive(false);
            keySolved = true;
        }
        
    }
}
