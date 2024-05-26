using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMStateBase
{
    public EFSMStageStateType mCurrentStateType { get; protected set; }

    public FSMStateBase(EFSMStageStateType inType)
    {
        mCurrentStateType = inType;
    }

    public virtual void OnEnter()
    {

    }

    public virtual void OnExit() 
    { 
    
    }

    public virtual void ChangeState(FSMStateBase inFsmStateBase)
    {

    }

    public virtual void OnProgress(float inDeltaTime)
    {

    }
}
