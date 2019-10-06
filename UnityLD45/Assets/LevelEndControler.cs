using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelEndControler : MonoBehaviour
{

    public Text text_AlreadyUnlocked;
    public Text text_NewUnlock;
    public Scene[] scenes;
    public Button nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetString("Next Level");
        if (LevelControllerBase.unlockOnEndOfLevel)
        {
            text_NewUnlock.text = "UNLOCKED\n" + LevelControllerBase.myUnlocks.UnlockNew().name;
        } else
        {
            text_NewUnlock.text = "UNLOCKED\nNOTHIN";
        }
        text_AlreadyUnlocked.text = "Already Unlocked:\n" + LevelControllerBase.myUnlocks.getStringOfUnlocks();
        nextLevel.onClick.AddListener(OnNewLevelClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnNewLevelClick()
    {
        SceneManager.LoadScene("Level6");
    }
}
