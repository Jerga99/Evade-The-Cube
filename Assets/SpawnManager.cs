using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float m_SpawnInterval = 2.0f;
    private float m_Timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab);
    }

    // Update is called once per frame
    void Update()
    {

        m_Timer += Time.deltaTime;

        if (m_Timer >= m_SpawnInterval)
        {
            Instantiate(enemyPrefab);
            m_Timer = 0;
        }
        
    }
}
