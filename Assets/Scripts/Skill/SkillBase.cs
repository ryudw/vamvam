using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour
{
    public SkillData mSkillData { set; get; }

    public virtual void FireSkill(Vector3 InsSartPos, Vector3 InStartDir)
    {

    }

    public virtual void StopSkill()
    {
        gameObject.SetActive(false);
        GamePoolManager.aInstance.EnqueueSkillPool(this);
    }

    public virtual void Update()
    {
        
    }

    public virtual void OnDestroy()
    {

    }


}
