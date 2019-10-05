

using System;
using System.Collections.Generic;

public class Unlocks
{
    public unlock[] unlockables;

    public static unlock test = new unlock
    {
        name = "test",
        description = "test",
        isUnlocked = false
    };

    public static unlock WideScreen = new unlock
    {
        name = "Widescreen",
        description = "unlocks 16:9 widescreen",
        isUnlocked = false
    };

    public static unlock background = new unlock
    {
        name = "Background",
        description = "Adds background too the game",
        isUnlocked = false
    };

    public static unlock Sound = new unlock
    {
        name = "Sound Effects",
        description = "adds sound effects to the game",
        isUnlocked = false
    };


    public Unlocks()
    {
        unlockables = new unlock[] { WideScreen, background, Sound };
    }





    public unlock UnlockNew()
    {
        return getLocked()[new Random().Next(getLocked().Count)];

    }

    public List<unlock> getLocked()
    {
        List<unlock> toReturn = new List<unlock>();
        foreach(unlock u in unlockables)
        {
            if (!u.isUnlocked)
            {
                toReturn.Add(u);
            }
        }
        return toReturn;
    }

    public List<unlock> getUnLocked()
    {
        List<unlock> toReturn = new List<unlock>();
        foreach (unlock u in unlockables)
        {
            if (u.isUnlocked)
            {
                toReturn.Add(u);
            }
        }
        return toReturn;
    }

    public string getStringOfUnlocks()
    {
        string s = "Character \nPlatforms \nEnemys \nCamera Movment \n ";
        if (WideScreen.isUnlocked)
            s += WideScreen.name + "\n";
        if (background.isUnlocked)
            s += background.name + "\n";
        if (Sound.isUnlocked)
            s += Sound.name + "\n";


        return s;
    }

}

public class unlock
{
    public string name;
    public string description;
    public bool isUnlocked;

    
}
