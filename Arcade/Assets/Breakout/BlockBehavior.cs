using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("A was pressed");
        }

        if (Input.GetKeyUp("a"))
        {
            Debug.Log("A was released");
        }

        if (Input.GetKeyDown("d"))
        {
            Debug.Log("D was pressed");
        }

        if (Input.GetKeyUp("d"))
        {
            Debug.Log("D was released");
        }

    }

    // int speed = 5;
}
