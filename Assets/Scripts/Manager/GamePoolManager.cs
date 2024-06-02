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
        SkillPool = new Dictionary<SkillData, Queue<SkillBase>>();
    }

    public void Clear()
    {
        SkillPool.Clear();
        SkillPool = null;
    }

    public void EnqueueSkillPool(SkillBase InSkill)
    {
        if(SkillPool == null)
        {
            return;
        }
        if(SkillPool.ContainsKey(InSkill.mSkillData) == false)
        {
            SkillPool.Add(InSkill.mSkillData, new Queue<SkillBase>());
        }

        SkillPool[InSkill.mSkillData].Enqueue(InSkill);

    }

    public SkillBase DequeueSkillPool(SkillData InSkillData)
    {
        if(SkillPool == null)
        {
            return null;
        }

        if(SkillPool.ContainsKey(InSkillData) == false)
        {
            return null;
        }

        return SkillPool[InSkillData].Dequeue();
    }

    private Dictionary<SkillData, Queue<SkillBase>> SkillPool = null;
}
