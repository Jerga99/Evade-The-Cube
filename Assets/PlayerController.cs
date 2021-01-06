using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Stats stats;

    void Awake()
    {
        stats = GetComponent<Stats>();
    }

    private void Start()
    {
        GameObject enemyGo = GameObject.Find("Enemy");
        EnemyController ec = enemyGo.GetComponent<EnemyController>();

        Debug.Log(ec.stats.health);
    }
}
