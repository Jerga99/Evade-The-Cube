using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public Transform leftWall;
    public Transform rightWall;

    // if fps is 150 then update is called 150 and position is changes by 150
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("PLayer Z position: " + transform.position.x);
        Debug.Log("Left Wall Z position: " + leftWall.position.x);

        if (transform.position.x <= leftWall.position.x)
        {
            return;
        }

        if (transform.position.x >= rightWall.position.x)
        {
            return;
        }


        transform.position = new Vector3(
            transform.position.x + horizontalInput * speed * Time.deltaTime,
            1,
            transform.position.z);
    }
}
