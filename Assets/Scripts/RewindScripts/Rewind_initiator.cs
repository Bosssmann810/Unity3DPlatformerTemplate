using NUnit.Framework;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class Rewind_initiator : MonoBehaviour
{
    public List<Vector3> rewindPositions = new List<Vector3>();
    public bool rewinding;
    public GameObject body;
    public Transform currentPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rewinding = false;
    }

    // Update is called once per frame
    void Update()
    {
        //keep track of the current position
        currentPos = body.transform;
        //if we are not rewinding
        if(rewinding == false)
        {
            Debug.Log(currentPos.position);
            //and if the current position has changed
            if (rewindPositions.Contains(currentPos.position))
            {
                //if it hasn't changed do nothing
                return;
            }
            //add the current position to the rewind positions
            rewindPositions.Add(currentPos.position);
        }
        //when rewinding is true
        if (rewinding == true)
        {
            //if nothing is there dont do anything;
           if(rewindPositions.ElementAt(0) == null)
           {
                return;
           }
            //find out the current position at element 0 of the list
            currentPos.position = rewindPositions.ElementAt(0);
            //set the body's transform to the current top element
            body.transform.position = rewindPositions.ElementAt(0);
            //then remove the element at the top
            rewindPositions.Remove(currentPos.position);
            
        }
        
    }
    //this is just here to make my life easier... yes I know it should be in input commands, no i don't care.
    public void RewindButton()//InputAction.CallbackContext context)
    {
        //when the button is pressed
        if(true )//context.performed//)
        {
            //reverse the list
            rewindPositions.Reverse();
            //and begin rewinding
            rewinding = true;

            //also this is where I could add the funky effects.
        }
        //when the button is released
        if (false)//(context.cancele)
        {
            //clear the rewind positions so it can start fresh.
            rewindPositions.Clear();
            //and stop rewinding.
            rewinding = false;
        }
    }
}
