using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockerDoor : MonoBehaviour
{
    public Transform target;
    Rigidbody Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.MovePosition(target.transform.position);
       
    }
}
