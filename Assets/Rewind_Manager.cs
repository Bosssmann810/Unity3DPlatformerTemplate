using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.InputSystem;

public class Rewind_Manager : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem timeEfffect;
    public List<GameObject> rewindable = new List<GameObject>();
    public GameObject rewindEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        GameObject rewindHolder = GameObject.FindGameObjectWithTag("RewindHolder");
        foreach(Transform Child in rewindHolder.transform)
        {
            rewindable.Add(Child.gameObject);
        }
        if (rewindable.Contains(rewindHolder))
        {
            rewindable.Remove(rewindHolder);
        }
        

                // foreach(Transform child in rewindHolder.transform)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnRewind(InputValue value)
    {
        if (value.isPressed)
        {
            //timeEfffect.Play();
            Debug.Log("Rewinding");
            rewindEffect.SetActive(true);
            foreach (GameObject thing in rewindable)
            {
                
                Rewind_initiator rewinder = thing.GetComponent<Rewind_initiator>();
                rewinder.StartRewind();

            }
        }
        if (value.isPressed == false)
        {
            //timeEfffect.Stop();
            Debug.Log("stopping");
            rewindEffect.SetActive(false);
            foreach (GameObject thing in rewindable)
            {
                Rewind_initiator rewinder = thing.GetComponent<Rewind_initiator>();
                rewinder.EndRewind();

            }

        }
    }

}
