using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMStageController
{
    private static FSMStageController sInstance = null;
    private FSM mStageFSM = null;

    public static FSMStageController aInstance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = new FSMStageController();
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

    public void EnterStage()
    {
        mStageFSM = new FSM(new FSMStageStateEnter());
    }

    public void ChangeState(FSMStateBase inFSMState)
    {
        if (mStageFSM != null)
        {
            mStageFSM.ChangeState(inFSMState);
        }
    }

    public void OnUpdate(float inDeltaTime)
    {
        if (mStageFSM != null)
        {
            mStageFSM.OnUpdateState(inDeltaTime);
        }
    }
}
