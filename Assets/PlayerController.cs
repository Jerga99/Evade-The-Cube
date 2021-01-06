using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Stats stats;

    void Awake()
    {
        Debug.Log(stats.health);
        //Stats enemyStats = GameObject
        //    .Find("Enemy")
        //    .GetComponent<Stats>();

        //Debug.Log("Enemy Health " + enemyStats.health);
    }
}
