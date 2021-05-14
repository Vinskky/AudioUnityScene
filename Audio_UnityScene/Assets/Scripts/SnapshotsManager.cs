using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SnapshotsManager : MonoBehaviour
{
    public AudioMixer master;
    public AudioMixerSnapshot outside;
    public AudioMixerSnapshot inside;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "Inside":
                inside.TransitionTo(1.0f);
                Debug.Log("Enter Inside");
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Inside":
                outside.TransitionTo(1.0f);
                Debug.Log("Enter Outside");
                break;
        }
    }
}
