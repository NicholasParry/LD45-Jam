using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler_Upgradeable : LevelControllerBase
{
    public SpriteRenderer _32Blocker;
    public SpriteRenderer Background;
    public AudioSource music;
    public AudioSource jumpSound;
    public AudioSource killEnemySound;


    private AudioSource[] soundEffects;
    private Unlocks _unlocks;

    public Animator anim22;

    // Start is called before the first frame update
    void Start()
    {
        soundEffects = new AudioSource[]
        {
            jumpSound,
            killEnemySound
        };
        workoutFeatures();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Unlocks.Sound.isUnlocked)
            {
                jumpSound.Play();
            }
            
        }
    }

    private void workoutFeatures()
    {
        if (Unlocks.WideScreen.isUnlocked)
        {
            _32Blocker.enabled = false;
        }

        if (!Unlocks.background.isUnlocked)
        {
            Background.enabled = false;
        }

        if (!Unlocks.Music.isUnlocked)
        {
            music.mute = true;
        } else
        {
            music.Play();
        }

        if (!Unlocks.Sound.isUnlocked)
        {
            foreach(AudioSource ass in soundEffects)
            {
                ass.mute = true;
            }
        }


    }
}
