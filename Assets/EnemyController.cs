using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Stats stats;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(stats.health);
        //Stats playerStats = GameObject
        //    .Find("Player")
        //    .GetComponent<Stats>();

        //Debug.Log("Player health: " + playerStats.health);
    }
}
