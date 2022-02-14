using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("testing");
        if (col.gameObject.name=="Disapperaring Cube")
        {
            Debug.Log("Collision Detected");
            Destroy (col.gameObject,3);
        }
    }
}
