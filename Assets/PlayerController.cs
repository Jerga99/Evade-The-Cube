using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Transform leftWall;
    public Transform rightWall;

    private Stats m_Stats;

    private void Awake()
    {
        m_Stats = GetComponent<Stats>();
    }

    // if fps is 150 then update is called 150 and position is changes by 150
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalPosition = transform.position.x + horizontalInput * speed * Time.deltaTime;

        float playerSize = transform.localScale.x / 2;

        if (horizontalPosition - playerSize <= leftWall.position.x + leftWall.localScale.x / 2)
        {
            return;
        }

        if (horizontalPosition + playerSize >= rightWall.position.x - rightWall.localScale.x / 2)
        {
            return;
        }


        transform.position = new Vector3(
            horizontalPosition,
            1,
            transform.position.z);
    }

    public void ReceiveDamage()
    {
        m_Stats.UpdateHealth(10);
    }
}
