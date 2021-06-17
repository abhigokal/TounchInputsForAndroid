using UnityEngine;

public class TeleportOnTouch : MonoBehaviour
{
    void Update()
    {    
        // Teleport gameobject to touch position
        if (Input.touchCount > 0)
        {
            Vector3 touchPos = Input.GetTouch(0).position;
            gameObject.transform.position = touchPos;
        }      
    }
}
