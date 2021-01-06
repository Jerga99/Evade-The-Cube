using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Awake()
    {
        GameObject enemyGo = GameObject.Find("Enemy");
        Stats enemyStats = enemyGo.GetComponent<Stats>();
        Debug.Log("Enemy Health " + enemyStats.health);
    }
}
