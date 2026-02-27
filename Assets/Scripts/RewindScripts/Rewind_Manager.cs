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
    public AudioSource backgroundMusic;
    public AudioSource rewindStaticSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        //make sure everything needed to run is acsessed
        GameObject rewindHolder = GameObject.FindGameObjectWithTag("RewindHolder");
        //find the rewindholder, get every child and add it to the rewindable list
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
        //when the button is pressed
        if (value.isPressed)
        {
            //reverse the music
            backgroundMusic.pitch = -1f;
            //play the static sound
            rewindStaticSound.Play();
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
            rewindStaticSound.Stop();
            backgroundMusic.pitch = 1f;
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
