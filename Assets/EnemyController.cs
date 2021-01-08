using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float m_TresholdPositionZ = -20.0f;
    private Transform m_PlayerTransform;
    public float speed;

    private void Start()
    {
        m_PlayerTransform = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - speed * Time.deltaTime);

        // measure distance between the enemy and player position

        if (Vector3.Distance(m_PlayerTransform.position, transform.position) < 1.0f) {
            Destroy(gameObject);
        } else if (transform.position.z <= m_TresholdPositionZ)
        {
            Destroy(gameObject);
        }
    }
}
