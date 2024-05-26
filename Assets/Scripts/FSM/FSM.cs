using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FSM
{
    public FSM(FSMStateBase inFSMState)
    {
        mCurrentState = inFSMState;
        if (mCurrentState == null)
        {
            inFSMState.OnEnter();
        }
    }

    public void ChangeState(FSMStateBase inFSMBase)
    {
        if (mCurrentState == inFSMBase)
        {
            return;
        }

        if (mCurrentState != null)
        {
            mCurrentState.OnExit();
        }

        mCurrentState = inFSMBase;

        if (mCurrentState != null)
        {
            mCurrentState.OnEnter();
        }
    }

    public void OnUpdateState(float inDeltaTime)
    {
        if (mCurrentState != null)
        {
            mCurrentState.OnProgress(inDeltaTime);
        }
    }

    public FSMStateBase mCurrentState { get; private set; }
}
