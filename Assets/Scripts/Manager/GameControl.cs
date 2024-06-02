using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl
{
    public delegate void OnMoving(Vector3 pDirect);
    public delegate void OnMoveStart();
    public delegate void OnMoveEnd();

    public OnMoving aOnMoving { get; set; }
    public OnMoveStart aOnMoveStart { get; set; }
    public OnMoveEnd aOnMoveEnd { get; set; }
    private static GameControl sInstance = null;

    public static GameControl aInstance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = new GameControl();
            }

            return sInstance;
        }
    }

    public void Init()
    {

    }

    public void SetControlObject(GameObject InGameObject)
    {
        mControlObject = InGameObject;
        mMovementBase = InGameObject.GetComponent<UnitMovementBase>();
    }

    public GameObject GetControlObject()
    {
        return mControlObject;
    }

    public void OnUpdate()
    {
        _UpdateKey();
    }

    public void Clear()
    {

    }

    private void _UpdateKey()
    {
        Vector3 MoveVerctor = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            MoveVerctor += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveVerctor += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            MoveVerctor += new Vector3(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveVerctor += new Vector3(1, 0, 0);
        }

        Vector3 MoveVectorNormal = MoveVerctor.normalized;
        if(MoveVerctor != Vector3.zero)
        {
            if(aOnMoving != null)
            {
                aOnMoving(MoveVectorNormal);
            }
            if(mIsMoving == false)
            {
                if(aOnMoveStart != null)
                {
                    aOnMoveStart();
                }
                mIsMoving = true;
            }
        }
        else
        {
            if (mIsMoving == true)
            {
                if (aOnMoving != null)
                {
                    aOnMoveEnd();
                }
                mIsMoving= false;
            }
        }
    }
    private static GameControl sinstance = null;

    private GameObject mControlObject = null;
    private UnitMovementBase mMovementBase = null;
    private bool mIsMoving = false;
}
