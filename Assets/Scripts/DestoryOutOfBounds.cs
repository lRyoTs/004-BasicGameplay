using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    public float topBound = 30f;
    public float lowerBound = -10f;
    
    // Update is called once per frame
    void Update()
    {
        //CHeck if OutOfBound
        if ((transform.position.z > topBound) || (transform.position.z < lowerBound))
        {
            Destroy(gameObject);
        }
    }
}
