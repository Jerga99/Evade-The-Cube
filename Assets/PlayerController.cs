using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // if fps is 150 then update is called 150 and position is changes by 150
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = new Vector3(
            transform.position.x + horizontalInput * speed * Time.deltaTime,
            1,
            transform.position.z + verticalInput * speed * Time.deltaTime);
    }
}
