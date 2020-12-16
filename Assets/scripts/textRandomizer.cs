using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textRandomizer : MonoBehaviour
{
    float randomNumber;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 10);
        text.text = (randomNumber.ToString());
    }

  
}
