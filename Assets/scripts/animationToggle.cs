using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationToggle : MonoBehaviour
{
    public GameObject lock1;
    public GameObject lock2;
    public bool Unlocked = false;
    public Animator Animator;


    private void Start()
    {
        //gets animator component from gameObject this script is attached to
        Animator = GetComponent<Animator>();
    }
    void Update()
    {
        //plays animation when both locks unlocked
        if (lock1.activeSelf==false && lock2.activeSelf == false)
        {
            Animator.SetBool("Unlocked", true);
        }
        
    }
}
