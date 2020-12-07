using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class MovePlayer : MonoBehaviour
{
    public SteamVR_Action_Vector2 moveValue;
    public float maxSpeed;
    public float sensitivity;
    public float distance;
    public Rigidbody head;


    private float speed = 0.0f;


    // Update is called once per frame
    void Update()
    {
        //stops code from running if to close to object
        RaycastHit hit; 
        if (head.SweepTest(Player.instance.hmdTransform.TransformDirection(Vector3.forward),out hit, distance))
        {

        }
        else
        {
            // if joystick is moved forward
            if (moveValue.axis.y > 0)
            {
                //create new vector3 to get direction hmd is facing
                Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(0, 0, moveValue.axis.y));
                //multiplies joystick value by sensitivity value
                speed = moveValue.axis.y * sensitivity;
                //makes sure speed doesnt go to high
                speed = Mathf.Clamp(speed, 0, maxSpeed);
                //move player horizontally in previously specified direction
                transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
            }

        }
       
    }
}
