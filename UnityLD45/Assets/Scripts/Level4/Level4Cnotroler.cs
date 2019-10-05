using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Cnotroler : LevelControllerBase
{

    public GameObject[] enemysToKill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject go in enemysToKill)
        {
            if (go)
            {
                return;
            }
        }
        Debug.Log("Killed");
    }

    public override void OnLocalReset()
    {

    }
}
