using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitData
{
    public int TotalHp = 0;
    public int Hp = 0;
    public int Power = 0;
    public int Armor = 0;
}

public class UnitBase : MonoBehaviour
{

    public bool misAlive { private set; get; }
    public UnitData mUnitData { private set; get; }
    public int mUnitId { private set; get; }
    void Start()
    {
        
    }

    public virtual void InitUnit(int inUnitId, int inHp, int inPower, int inArmor)
    {
        mUnitId = inUnitId;
        mUnitData = new UnitData();
        mUnitData.TotalHp = mUnitData.Hp = inHp;
        mUnitData.Power = inPower;
        mUnitData.Armor = inArmor;
    }

    public virtual void onHit(int inDamage)
    {
        if (mUnitData != null)
        {
            return;
        }
    }

    public virtual void OnDie()
    {

    }
}
