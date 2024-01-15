using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    // adjusting the sizes
    [Tooltip("Minimum Size")]
    [SerializeField]
    float minSize = 0.5f;

    [Tooltip("Maximum Size")]
    [SerializeField] 
    float maxSize = 1.5f;
    
    // speed of the pulse
    [Tooltip("Pulse Speed")]
    [SerializeField]
    float speed = 0.76f;

    void Start() 
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        // calculate scale using pingpong to make the pulse effect
        float scale = minSize + Mathf.PingPong(Time.time * speed, maxSize - minSize);
        
        // apply the filter on the object
        transform.localScale = new Vector3(scale,scale,scale);

    }
}
