using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControllerBase : MonoBehaviour
{
    public static Unlocks myUnlocks;
    public static bool unlockOnEndOfLevel = true;
    public static Unlocks myUnlocksInstance;

    public LevelControllerBase() //im sorry mum
    {
        if (myUnlocks == null)
        {
            myUnlocks = new Unlocks(); //initalise on first load and odd failures (Probs just gunna make bugs but yolo
        }
        myUnlocksInstance = myUnlocks;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnReset()
    {
        OnLocalReset();
    }

    public virtual void OnLocalReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
