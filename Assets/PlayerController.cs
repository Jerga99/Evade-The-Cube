using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Awake()
    {
        Stats stats = GetComponent<Stats>();
        Debug.Log(stats.health);
    }
}
