using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{

    // Update is called once per frame
     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
    }
}
