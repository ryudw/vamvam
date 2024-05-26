using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl
{
    private static GameControl sInstance = null;

    public static GameControl aInstance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = new GameControl();
            }

            return sInstance;
        }
    }

    public void Init()
    {

    }

    public void Clear()
    {

    }
}
