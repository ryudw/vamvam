using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPcUnitMovementBase : UnitMovementBase
{
    void Start()
    {
        GameControl.aInstance.aOnMoving += HandleMoving;
        GameControl.aInstance.aOnMoveStart += HandleMoveStart;
        GameControl.aInstance.aOnMoveEnd += HandleMoveEnd;
    }

    void OnDestroy()
    {
        GameControl.aInstance.aOnMoving -= HandleMoving;
        GameControl.aInstance.aOnMoveStart -= HandleMoveStart;
        GameControl.aInstance.aOnMoveEnd -= HandleMoveEnd;
    }

    private void HandleMoving(Vector3 pDirect)
    {
        transform.position += pDirect * mSpeed * Time.deltaTime;
        mRotationTransform.rotation = Quaternion.RotateTowards(mRotationTransform.rotation, Quaternion.LookRotation(pDirect), mRotationSpeed * Time.deltaTime);
    }

    private void HandleMoveStart()
    {
        if(mAnimator != null)
        {
            mAnimator.CrossFade("RUN", 0.1f);
        }
    }

    private void HandleMoveEnd()
    {
        if (mAnimator != null)
        {
            mAnimator.CrossFade("IDLE", 0.1f);
        }
    }
}
