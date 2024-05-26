using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPcUnit : UnitBase
{
    public int mExp { get; set; }
    public int mMaxExp { get; set; }
    public int mLevel { get; set; }

    void Start()
    {

    }

    public override void InitUnit(int inUnitId, int inHp, int inPower, int inArmor)
    {
        base.InitUnit(inUnitId, inHp, inPower, inArmor);
        mExp = 0;
        mMaxExp = MAX_EXP_FROM_LEVEL_VALUE;
        mLevel = 1;
    }

    public void SetupLevel(int inLevel)
    {
        mLevel = inLevel;
        mExp = 0;
        mMaxExp = MAX_EXP_FROM_LEVEL_VALUE * mLevel;
    }

    public override void onHit(int inDamage)
    {
        base.onHit(inDamage);
    }

    public override void OnDie()
    {
        base.OnDie();
    }

    private void Update()
    {
        
    }

    private const int MAX_EXP_FROM_LEVEL_VALUE = 10000;
}
