using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour

{
    
    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();

        movementX = v.x;
        movementY = v.y;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

