using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTouch : MonoBehaviour
{
  
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
		        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
			      touchPosition.z = 0f;
			      transform.position = touchPosition;
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            // Finger was picked up
            // Do something
        }
    }
}
