using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePoolManager
{
    private static GamePoolManager sInstance = null;

    public static GamePoolManager aInstance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = new GamePoolManager();
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
