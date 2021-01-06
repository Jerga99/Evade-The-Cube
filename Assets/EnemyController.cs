using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Stats stats = GetComponent<Stats>();
        Debug.Log(stats.health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
