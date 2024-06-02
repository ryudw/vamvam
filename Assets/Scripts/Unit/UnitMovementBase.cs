using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovementBase : MonoBehaviour
{
    public float mSpeed = 5.0f;
    public Transform mRotationTransform;
    public float mRotationSpeed = 400.0f;
    public Animator mAnimator;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 inowPostion = transform.position + new Vector3(0, 100, 0);
        Vector3 iDirection = new Vector3(0, -1, 0);
        RaycastHit hit;
        int layermask = 1 << LayerMask.NameToLayer("Terrain");
        if(Physics.Raycast(inowPostion, iDirection, out hit, 200, layermask))
        {
            float iheight = hit.point.y;
            Vector3 iNewPos = transform.position;
            iNewPos.y = iheight;
            transform.position = iNewPos;
        }
    }
}
