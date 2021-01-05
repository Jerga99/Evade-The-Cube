using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // is called on consistent frame rate
    // manipulate physics
    // for example: to manipulate "rigidbody" component
    void FixedUpdate()
    {
        Debug.Log(Time.fixedDeltaTime);
    }

    // Update is called once per frame
    // is not consistent
    // one frame can take longer than other
    // you can use update:
    // to receive input from the user
    // do operation with timers
    // manipulate non physics objects
    void Update()
    {
    }

    // is called after update
    // for example: manipulate camera
    void LateUpdate()
    {
    }
}
