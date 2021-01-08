using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float m_TresholdPositionZ = -20.0f;
    public float speed;

    private void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - speed * Time.deltaTime);

        if (transform.position.z <= m_TresholdPositionZ)
        {
            Destroy(gameObject);
        }
    }
}
