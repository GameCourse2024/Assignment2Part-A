using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{

    [Tooltip("Choose key to hide/show component")]
    [SerializeField]
    private KeyCode myKey = KeyCode.Space;
    // component that works on the renderer 
    Renderer showComponent; 
    
    // flag indicates if object is on
    bool isOn = true;

    void Start()
    {
        // link the renderer to the object
        showComponent = GetComponent<Renderer>();
        // shows the object
        showComponent.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // if key is being pressed
        if(Input.GetKeyDown(myKey))
        {
            // indicate the flag
            isOn = !isOn;

            // show / hide
            showComponent.enabled = isOn;
        }
    }
}
