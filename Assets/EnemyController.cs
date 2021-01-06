using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Stats stats;

    // Start is called before the first frame update
    void Awake()
    {
        stats = GetComponent<Stats>();

        //GameObject enemyGo = GameObject.Find("Player");
        //PlayerController pc = enemyGo.GetComponent<PlayerController>();
        //Debug.Log(pc.stats);

        //// we are getting error here becauase gameobect's
        //// component hasn't has made a reference to it's own component
        //// player controller doesn't have reference to stats component yet
        //Debug.Log(pc.stats.health);
    }

    private void Start()
    {
        GameObject enemyGo = GameObject.Find("Player");
        PlayerController pc = enemyGo.GetComponent<PlayerController>();
        Debug.Log(pc.stats.health);
    }
}
