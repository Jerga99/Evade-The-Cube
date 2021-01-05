using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is executed!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update is executed!");
        Debug.Log(Time.deltaTime);
    }
}
