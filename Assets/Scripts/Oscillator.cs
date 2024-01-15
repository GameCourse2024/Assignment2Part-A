using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("Oscillating movement")]
    [SerializeField]
    float movement = 2f; // movement of the oscillator

    [Tooltip("Oscillating Speed")]
    [SerializeField]
    float speed = 1f;   // speed of oscillator

    Vector3 startingSpot; // mark the object position

    // Start is called before the first frame update
    void Start()
    {
        // set the object current spot
        startingSpot = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // oscillate using sinus 
        float oscillate = Mathf.Cos(Time.time * speed) * movement;
        
        // modify the object location by the oscillation on X axis
        transform.position = startingSpot + new Vector3(oscillate, 0, 0);
    }
}
