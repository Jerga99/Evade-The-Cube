using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject playerGo = GameObject.Find("Player");
        Stats playerStats = playerGo.GetComponent<Stats>();
        Debug.Log("Player health: " + playerStats.health);
    }
}
