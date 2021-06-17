using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnLeftOrRightSide : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);
            // Get left or right position
            if (touch_pos.x > 0)
            {
                // Player has tapped on the right half of the screen
            }
            else if (touch_pos.x < 0)
            {
                // Player has tapped on the right half of the screen
            }

            
            // Get top or bot position
            if (touch_pos.y > 0)
            {
                // Player has tapped on the top half of the screen
            }
            else if (touch_pos.y < 0)
            {
                // Player has tapped on the bottom half of the screen
            }
        }    
    }
}
