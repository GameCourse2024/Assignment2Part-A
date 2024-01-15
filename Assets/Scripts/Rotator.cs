using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Tooltip("Spinning Speed")]
    [SerializeField]
    float speed = 100;

    // Update is called once per frame
    void Update()
    {
        // rotates the picture itself 
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.Self);
        
        // rotates to the side
        //transform.Rotate(new Vector3(0 , 0, -0.5f));
    }
}
