using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager
{
    private static GameDataManager sInstance = null;
    public int mStage { get; private set; }
    private GameObject mMyPc;
    private Transform mSpawnRoot;
    private Transform mSkilRoot;
    private Transform mItemRoot;

    public static GameDataManager aInstance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = new GameDataManager();
            }

            return sInstance;
        }
    }

    public GameObject GetMyPcObject()
    {
        return mMyPc;
    }

    public Transform GetSpawnRootTransform()
    {
        return mSpawnRoot;
    }

    public Transform GetSkilRootTransform()
    {
        return mSkilRoot;
    }

    public Transform GetItemRootTransform()
    {
        return mItemRoot;
    }

    public void Init()
    {

    }

    public void Clear()
    {
        mStage = 0;
        mMyPc = null;
        mSpawnRoot = null;
        mSkilRoot = null;
        mItemRoot = null;
    }

    public void func()
    {
        if (mMyPc == null)
        {
            return;
        }
    }

    public void SetStageData(GameObject inMyPc, Transform inSpawnRoot, Transform inSkilRoot, Transform inItemRoot)
    {
        mMyPc = inMyPc;
        mSpawnRoot = inSpawnRoot;
        mSkilRoot = inSkilRoot;
        mItemRoot = inItemRoot;
    }

    public void SetCurrentStatge(int inStage)
    {
        mStage = inStage;
    }
}

