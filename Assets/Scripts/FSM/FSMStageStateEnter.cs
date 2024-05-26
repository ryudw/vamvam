using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMStageStateEnter : FSMStateBase
{
    public FSMStageStateEnter() 
        : base(EFSMStageStateType.StageStart)
    {

    }

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log(message: "Stage State Enter, Call Exit");
        mDurationTime = 0;
    }

    public override void OnProgress(float inDeltaTime)
    {
        base.OnProgress(inDeltaTime);
        mDurationTime += inDeltaTime;
        if (mDurationTime > 1.0f)
        {
            if (mCountDown <= 0)
            {
                FSMStageController.aInstance.ChangeState(new FSMStageStateProgress());
            }
            else
            {
                mCountDown--;
                Debug.Log("Count Down = " + mCountDown);
            }
            mDurationTime = 0.0f;
        }
    }

    private int mCountDown = 3;
    private float mDurationTime = 0;
}
