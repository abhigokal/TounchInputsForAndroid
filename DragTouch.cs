using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTouch : MonoBehaviour
{
  
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPos = Input.GetTouch(0).position;
            gameObject.transform.position = touchPos;
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            // Finger was picked up
            // Do something
        }
    }
}
