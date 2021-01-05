using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float m_AccuTime = 0;
    private float m_Fps = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_AccuTime += Time.deltaTime;
        m_Fps++;

        if (m_AccuTime >= 1)
        {
            Debug.Log("BUM " + m_AccuTime);
            Debug.Log("FPS " + m_Fps);
            m_Fps = 0;
            m_AccuTime = 0;
        }
    }
}
